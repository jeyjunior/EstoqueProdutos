using EP.Data.Entidades;
using EP.Data.Interfaces;
using Estoque.Telas_Usuario;
using EstoqueProdutos.Formatacao;
using EstoqueProdutos.Gerenciamento;
using Microsoft.Data.SqlClient;
using System.Data;

namespace Estoque.Telas_Produto
{
    public partial class UCUsuario : Estoque.Telas_Base.UCGerenciadorDeTelas
    {
        private readonly ISetorRepositorio setorRepositorio;
        private readonly ICargoRepositorio cargoRepositorio;
        private readonly IUsuarioRepositorio usuarioRepositorio;

        private BindingSource bsCargo = new BindingSource();

        private IEnumerable<Usuario> usuarios;
        private Usuario usuarioSelecionado;
        public UCUsuario()
        {
            InitializeComponent();
            AtualizarPropriedades();

            setorRepositorio = DIRepositorios.Container.GetInstance<ISetorRepositorio>();
            cargoRepositorio = DIRepositorios.Container.GetInstance<ICargoRepositorio>();
            usuarioRepositorio = DIRepositorios.Container.GetInstance<IUsuarioRepositorio>();
        }

        #region Metodos
        private void InicializarComponentes()
        {
            try
            {
                BindComboBoxSetor();
                BindComboBoxCargo();
                txtNome.Text = "";
                txtNome.Focus();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Falha sql\n\n" + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao executar essa operação\n\n" + ex.Message);
            }
        }
        private void BindComboBoxSetor()
        {
            var resultado = setorRepositorio.ObterTabela().ToList();
            resultado.Insert(0,
                new Setor
                {
                    PK_Setor = 0,
                    NomeSetor = "Nenhum"
                });

            if (resultado != null)
            {
                cboSetor.DataSource = resultado;
                cboSetor.DisplayMember = "NomeSetor";
                cboSetor.ValueMember = "PK_Setor";
                cboSetor.SelectedIndex = 0;
            }
        }
        private void BindComboBoxCargo()
        {
            var result = cargoRepositorio.ObterTabela().ToList();
            result.Insert(0,
                new Cargo
                {
                    PK_Cargo = 0,
                    FK_Setor = 0,
                    NomeCargo = "Nenhum"
                });

            if (result != null)
            {
                bsCargo.DataSource = result;
                cboCargo.DataSource = FiltrarCargos();
                cboCargo.DisplayMember = "NomeCargo";
                cboCargo.ValueMember = "PK_Cargo";
            }
        }
        private void BindDataGridView()
        {
            if (usuarios != null)
            {
                Cursor.Current = Cursors.WaitCursor;
                dtgUsuarios.Rows.Clear();
                usuarios.ToList().ForEach(usuario =>
                {
                    dtgUsuarios.Rows.Add(
                        usuario.PK_Usuario,
                        usuario.NomeCompleto,
                        usuario.NomeAbreviado,
                        usuario.Email,
                        usuario.Setor.PK_Setor,
                        usuario.Setor.NomeSetor,
                        usuario.Cargo.PK_Cargo,
                        usuario.Cargo.NomeCargo
                        );
                });
            }
        }
        private void LimparComponentes()
        {
            txtNome.Text = "";

            cboSetor.SelectedValue = 0;
            cboCargo.SelectedValue = 0;

            if (dtgUsuarios.Rows.Count > 0)
                dtgUsuarios.Rows.Clear();
        }
        private void ObterUsuarioDaLinhaSelecionar()
        {
            try
            {
                if (dtgUsuarios.Rows.Count <= 0)
                {
                    MessageBox.Show("Selecione um usuário");
                    return;
                }

                DataGridViewRow linhaSelecionada = dtgUsuarios.SelectedRows[0];

                var pkUsuario = Convert.ToInt32(linhaSelecionada.Cells["colPK_Usuario"].Value);
                var nomeCompleto = linhaSelecionada.Cells["colNomeCompleto"].Value.ToString();
                var nomeAbreviado = linhaSelecionada.Cells["colNomeAbreviado"].Value.ToString();
                var email = linhaSelecionada.Cells["colEmail"].Value.ToString();
                var fkSetor = Convert.ToInt32(linhaSelecionada.Cells["colFK_Setor"].Value);
                var fkCargo = Convert.ToInt32(linhaSelecionada.Cells["colFK_Cargo"].Value);

                usuarioSelecionado = new Usuario
                {
                    PK_Usuario = pkUsuario,
                    NomeCompleto = nomeCompleto,
                    NomeAbreviado = nomeAbreviado,
                    Email = email,
                    FK_Setor = fkSetor,
                    FK_Cargo = fkCargo
                };

                if (usuarioRepositorio != null)
                {
                    txtNome.Text = usuarioSelecionado.NomeCompleto;
                    cboSetor.SelectedValue = usuarioSelecionado.FK_Setor;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu uma falha ao tentar obter linha selecionada");
            }
        }

        private int ObterCboSetorSelecionado()
        {
            return cboSetor.SelectedValue != null ? (int)cboSetor.SelectedValue : 0;
        }
        private int ObterCboCargoSelecionado()
        {
            return cboCargo.SelectedValue != null ? (int)cboCargo.SelectedValue : 0;
        }
        private IEnumerable<Cargo> FiltrarCargos()
        {
            if (cboSetor != null && bsCargo != null && cboSetor.SelectedItem is Setor setor)
            {
                return bsCargo.OfType<Cargo>().Where(c =>
                {
                    if (c.Setor != null)
                    {
                        return c.Setor.PK_Setor == setor.PK_Setor;
                    };

                    return false;
                }).ToList();
            }

            return null;
        }


        private void ExcluirUsuarioSelecionado()
        {
            try
            {
                string mensagem = "Tem certeza que excluir esse usuário?\n";
                string usuario = "\nDeletar: " + txtNome.Text.Trim();

                var resultado = MessageBox.Show(mensagem + usuario,
                                            "Deletar",
                                            MessageBoxButtons.YesNo,
                                            MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    var resultadoInsert = usuarioRepositorio.ExcluirUsuario(new Usuario()
                    { PK_Usuario = usuarioSelecionado.PK_Usuario });

                    if (resultadoInsert)
                    {
                        MessageBox.Show("Cargo excluído com sucesso!");
                        LimparComponentes();
                        btnPesquisar.PerformClick();
                    }
                }
                else
                {
                    txtNome.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion Metodos

        #region Eventos
        /* Form */
        private void UCProdutos_Load(object sender, EventArgs e)
        {
            InicializarComponentes();
            btnPesquisar.PerformClick();
        }
        private void UCProdutos_ParentChanged(object sender, EventArgs e)
        {
            LimparComponentes();
        }

        /* Cbos */
        private void cboSetor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboSetor != null)
            {
                cboCargo.DataSource = FiltrarCargos();
                cboCargo.Enabled = ObterCboCargoSelecionado() > 0;
            }
        }
        private void cboCargo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (cboCargo != null
            //    && cboCargo.Items.Count > 0
            //    && cboCargo.SelectedItem is Cargo cargoSelecionado)
            //{
            //    if (cboCargo.SelectedIndex <= 0)
            //    {
            //        cboSetor.DataSource = bindingSourceSetor;
            //    }
            //    else
            //    {
            //        cboSetor.DataSource = bindingSourceSetor.
            //            Cast<Setor>().Where(s => s.PK_Setor == cargoSelecionado.FK_Setor).ToList();
            //    }
            //}
        }


        /*  Botoes */
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            usuarios = usuarioRepositorio.ObterTabelaFiltroTelaUsuarios(new Usuario
            {
                NomeCompleto = txtNome.TextoFormatoLikeSQL(),
                FK_Setor = ObterCboSetorSelecionado(),
                FK_Cargo = ObterCboCargoSelecionado()
            });

            BindDataGridView();
        }
        private void btnCadastrarUsuario_Click(object sender, EventArgs e)
        {
            AbrirTela(typeof(FrmCadastrarUsuario), this, true, FilhoFechado);
        }
        private void btnSetorCargo_Click(object sender, EventArgs e)
        {
            AbrirTela(typeof(FrmCadastrarSetorCargo), this, true, FilhoFechado);
        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            ObterUsuarioDaLinhaSelecionar();
            ExcluirUsuarioSelecionado();
        }


        private void btnAlterar_Click(object sender, EventArgs e)
        {
            ObterUsuarioDaLinhaSelecionar();

            if (usuarioSelecionado != null)
            {
                ObjetoGenerico = usuarioSelecionado;
                AbrirTela(typeof(FrmAlterarUsuario), this, true, FilhoFechado);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparComponentes();
        }

        /* Filhos */
        private void FilhoFechado(object? sender, FormClosedEventArgs e)
        {
            InicializarComponentes();
        }

        #endregion Eventos

    }
}
