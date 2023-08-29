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

        private BindingSource bindingSourceCargos = new BindingSource();
        private BindingSource bindingSourceSetor = new BindingSource();

        private IEnumerable<Usuario> usuarios;

        public UCUsuario()
        {
            InitializeComponent();
            AtualizarPropriedades();

            setorRepositorio = DIRepositorios.Container.GetInstance<ISetorRepositorio>();
            cargoRepositorio = DIRepositorios.Container.GetInstance<ICargoRepositorio>();
            usuarioRepositorio = DIRepositorios.Container.GetInstance<IUsuarioRepositorio>();
        }

        private void InicializarComponentes()
        {
            try
            {
                BindComboBoxSetor();
                BindComboBoxCargo();
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
            var result = setorRepositorio.ObterTabela().ToList();
            result.Insert(0,
                new Setor
                {
                    PK_Setor = 0,
                    NomeSetor = "Nenhum"
                });

            if (result != null)
            {
                bindingSourceSetor.DataSource = result;
                cboSetor.DataSource = bindingSourceSetor;
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
                bindingSourceCargos.DataSource = result;
                cboCargo.DataSource = bindingSourceCargos;
                cboCargo.DisplayMember = "NomeCargo";
                cboCargo.ValueMember = "PK_Cargo";
                cboCargo.SelectedIndex = 0;
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
                        usuario.Setor.NomeSetor,
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

        private int ObterSetorSelecionado()
        {
            if (cboSetor != null && cboSetor.Items.Count > 0)
            {
                var setorSelecionado = (Setor)cboSetor.SelectedItem;
                return setorSelecionado.PK_Setor;
            }

            return 0;
        }

        private int ObterCargoSelecionado()
        {
            if (cboCargo != null && cboCargo.Items.Count > 0)
            {
                var cargoSelecionado = (Cargo)cboCargo.SelectedItem;
                return cargoSelecionado.PK_Cargo;
            }

            return 0;
        }

        private void UCProdutos_Load(object sender, EventArgs e)
        {
            InicializarComponentes();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.TextoFormatoLikeSQL();

            var usuarioParametros = new Usuario()
            {
                NomeCompleto = nome,
                FK_Setor = ObterSetorSelecionado(),
                FK_Cargo = ObterCargoSelecionado()
            };

            usuarios = usuarioRepositorio.ObterTabelaFiltroTelaUsuarios(usuarioParametros);
            BindDataGridView();
        }

        private void UCProdutos_ParentChanged(object sender, EventArgs e)
        {
            LimparComponentes();
        }

        private void btnCadastrarUsuario_Click(object sender, EventArgs e)
        {
            AbrirTela(typeof(FrmCadastrarUsuario), this, true);
        }

        private void cboSetor_SelectedIndexChanged(object sender, EventArgs e)
        {
            int PK_SetorSelecionado = ObterSetorSelecionado();

            if (PK_SetorSelecionado <= 0)
            {
                cboCargo.DataSource = bindingSourceCargos;
            }
            else
            {
                cboCargo.DataSource = bindingSourceCargos
                    .Cast<Cargo>()
                    .Where(c => (c.FK_Setor == PK_SetorSelecionado) || (c.FK_Setor == 0))
                    .ToList();
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

        private void btnSetorCargo_Click(object sender, EventArgs e)
        {
            AbrirTela(typeof(FrmCadastrarSetorCargo), this, true);
        }
    }
}
