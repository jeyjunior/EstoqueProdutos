using EP.Data.Entidades;
using EP.Data.Interfaces;
using Estoque.Controladores;
using Estoque.Enums;
using Estoque.GerenciamentoTelas;
using Estoque.Interfaces;
using Estoque.Telas_Modelos;
using EstoqueProdutos.Formatacao;
using EstoqueProdutos.Gerenciamento;
using EstoqueProdutos.Repositorios;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estoque.Telas_Usuario
{
    public partial class UCUsuarios : Estoque.Telas_Base.UCGerenciadorDeTelas
    {
        #region Interfaces 
        private readonly ISetorRepositorio setorRepositorio;
        private readonly ICargoRepositorio cargoRepositorio;
        private readonly IUsuarioRepositorio usuarioRepositorio;
        #endregion Interfaces

        #region Propriedades
        private BindingSource bsCargo = new BindingSource();
        private IEnumerable<Usuario> usuarios;
        private Usuario usuarioSelecionado;
        #endregion Propriedades
        public UCUsuarios()
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
                BindComboBoxAtivo();
                txtNome.Text = "";
                txtNome.Focus();
                btnPesquisar.PerformClick();
            }
            catch (Exception ex)
            {
                Mensagem.Erro("Erro: " + ex.Message);
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

            if (result != null)
            {
                bsCargo.DataSource = result;
                cboCargo.DataSource = FiltrarCargos();
                cboCargo.DisplayMember = "NomeCargo";
                cboCargo.ValueMember = "PK_Cargo";
            }
        }
        private void BindComboBoxAtivo()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("Ativo", typeof(string));

            DataRow r1 = dt.NewRow();
            r1["ID"] = 1;
            r1["Ativo"] = "Ativado";
            dt.Rows.Add(r1);

            DataRow r2 = dt.NewRow();
            r2["ID"] = 0;
            r2["Ativo"] = "Desativado";
            dt.Rows.Add(r2);

            cboAtivo.DataSource = dt;
            cboAtivo.DisplayMember = "Ativo";
            cboAtivo.ValueMember = "ID";
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
                        usuario.Cargo.NomeCargo,
                        usuario.FK_Imagem
                        );
                });
            }
        }
        private void LimparComponentes()
        {
            txtNome.Text = "";

            cboSetor.SelectedValue = 0;
            cboCargo.SelectedValue = 0;
            cboAtivo.SelectedValue = 1;

            if (dtgUsuarios.Rows.Count > 0)
                dtgUsuarios.Rows.Clear();
        }
        private void ObterUsuarioDaLinhaSelecionar()
        {
            try
            {
                if (dtgUsuarios.Rows.Count <= 0)
                {
                    Alerta.Aviso("Selecione um usuário");
                    return;
                }

                DataGridViewRow linhaSelecionada = dtgUsuarios.SelectedRows[0];

                var pkUsuario = Convert.ToInt32(linhaSelecionada.Cells["colPK_Usuario"].Value);
                var nomeCompleto = linhaSelecionada.Cells["colNomeCompleto"].Value.ToString();
                var nomeAbreviado = linhaSelecionada.Cells["colNomeAbreviado"].Value.ToString();
                var email = linhaSelecionada.Cells["colEmail"].Value.ToString();
                var fkSetor = Convert.ToInt32(linhaSelecionada.Cells["colFK_Setor"].Value);
                var fkCargo = Convert.ToInt32(linhaSelecionada.Cells["colFK_Cargo"].Value);
                var fkImagem = Convert.ToInt32(linhaSelecionada.Cells["colFK_Imagem"].Value);

                usuarioSelecionado = new Usuario
                {
                    PK_Usuario = pkUsuario,
                    NomeCompleto = nomeCompleto,
                    NomeAbreviado = nomeAbreviado,
                    Email = email,
                    FK_Setor = fkSetor,
                    FK_Cargo = fkCargo,
                    FK_Imagem = fkImagem
                };

                if (usuarioRepositorio != null)
                {
                    txtNome.Text = usuarioSelecionado.NomeCompleto;
                    cboSetor.SelectedValue = usuarioSelecionado.FK_Setor;
                }
            }
            catch (Exception ex)
            {
                Mensagem.Erro("Erro: " + ex.Message);
            }
        }
        private IEnumerable<Cargo> FiltrarCargos()
        {
            if (cboSetor != null && bsCargo != null && cboSetor.SelectedItem is Setor setor)
            {
                var resultado = bsCargo.OfType<Cargo>().Where(c =>
                {
                    if (c.Setor != null)
                    {
                        return c.Setor.PK_Setor == setor.PK_Setor;
                    };

                    return false;
                })
                .OrderBy(c => c.PK_Cargo)
                .ToList();

                resultado.Insert(0,
                    new Cargo
                    {
                        PK_Cargo = 0,
                        FK_Setor = 0,
                        NomeCargo = "Nenhum"
                    });

                return resultado;
            }

            return null;
        }
        private void DesativarUsuarioSelecionado()
        {
            try
            {
                string mensagem = "Desativar esse usuário?\n";
                string usuario = txtNome.Text.Trim();

                var resultado = Mensagem.Pergunta(mensagem + usuario, "Desativar");

                if (resultado == RespostaCaixaDialogo.Sim)
                {
                    var resultadoInsert = usuarioRepositorio.AlterarAtivoUsuario(new Usuario()
                    {
                        PK_Usuario = usuarioSelecionado.PK_Usuario,
                        Ativo = false
                    });

                    if (resultadoInsert)
                    {
                        Alerta.Confirmacao("Usuário desativado com sucesso!");
                    }
                }
                else
                {
                    txtNome.Focus();
                }
            }
            catch (Exception ex)
            {
                Mensagem.Erro("Erro: " + ex.Message);
            }
        }
        private void AtivarUsuarioSelecionado()
        {
            try
            {
                string mensagem = "Ativar esse usuário?\n";
                string usuario = txtNome.Text.Trim();

                var resultado = Mensagem.Pergunta(mensagem + usuario, "Ativar");

                if (resultado == RespostaCaixaDialogo.Sim)
                {
                    var resultadoInsert = usuarioRepositorio.AlterarAtivoUsuario(new Usuario()
                    {
                        PK_Usuario = usuarioSelecionado.PK_Usuario,
                        Ativo = true
                    });

                    if (resultadoInsert)
                    {
                        Alerta.Confirmacao("Usuário ativado com sucesso!");
                    }
                }
                else
                {
                    txtNome.Focus();
                }
            }
            catch (Exception ex)
            {
                Mensagem.Erro("Erro: " + ex.Message);
            }
        }


        private void AtualizarTotalRegistrado()
        {
            int total = setorRepositorio.ObterTotalSetoresRegistrados();
            lblTotalRegistrado.Text = "Registrados: " + total;
        }
        private void AtualizarTotalPesquisado()
        {
            lblTotalPesquisado.Text = "Pesquisado: " + dtgUsuarios.Rows.Count;
        }
        #endregion Metodos

        #region Eventos
        private void UCUsuarios_Load(object sender, EventArgs e)
        {
            InicializarComponentes();
        }
        private void UCUsuarios_ParentChanged(object sender, EventArgs e)
        {
            LimparComponentes();
        }
        private void cboSetor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboSetor != null)
            {
                cboCargo.DataSource = FiltrarCargos();
                cboCargo.Enabled = ((Setor)cboSetor.SelectedItem).PK_Setor > 0;
            }
        }
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            usuarios = usuarioRepositorio.ObterTabelaFiltroTelaUsuarios(new Usuario
            {
                NomeCompleto = txtNome.TextoFormatoLikeSQL(),
                FK_Setor = ((Setor)cboSetor.SelectedItem).PK_Setor,
                FK_Cargo = ((Cargo)cboCargo.SelectedItem).PK_Cargo,
                Ativo = Convert.ToBoolean((int)cboAtivo.SelectedValue)
            });

            if ((int)cboAtivo.SelectedIndex == 0)
            {
                btnDesativar.Enabled = true;
                btnAtivar.Enabled = false;
            }
            else
            {
                btnDesativar.Enabled = false;
                btnAtivar.Enabled = true;
            }

            BindDataGridView();
        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparComponentes();
            btnPesquisar.PerformClick();
        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            ObterUsuarioDaLinhaSelecionar();
            DesativarUsuarioSelecionado();
        }
        private void btnAtivar_Click(object sender, EventArgs e)
        {
            ObterUsuarioDaLinhaSelecionar();
            AtivarUsuarioSelecionado();
        }
        private void btnSetorCargo_Click(object sender, EventArgs e)
        {
            AbrirTela(typeof(FrmCadastrarSetores_Cargos), this, true, FilhoFechado);
        }
        private void btnCadastrarUsuario_Click(object sender, EventArgs e)
        {
            AbrirTela(typeof(FrmCadastrarUsuario), this, true, FilhoFechado);
        }
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            ObterUsuarioDaLinhaSelecionar();

            if (usuarioSelecionado != null)
            {
                ObjetoGenerico = usuarioSelecionado;
                AbrirTela(typeof(FrmAlterarUsuarioNovo), this, true, FilhoFechado);
            }
        }

        /* Filhos */
        private void FilhoFechado(object? sender, FormClosedEventArgs e)
        {
            InicializarComponentes();
        }
        #endregion Eventos
        private void tlpCentral_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                btnPesquisar.PerformClick();

                AtualizarTotalRegistrado();
                AtualizarTotalPesquisado();
            }
        }
    }
}
