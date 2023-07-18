using EstoqueProdutos.Ajudantes.Componentes;
using EstoqueProdutos.SQLServer.Procedures;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstoqueProdutos.Ajudantes.Bind
{
    /// <summary>
    /// Caso os dados não sejam carregados corretamente, desabilita um btn de ação do formulario
    /// ex.: Bloqueia a opção de cadastrar produto caso um cbo não seja populado
    /// </summary>
    public static class Tabela
    {
        public static bool AtribuirData(this ComboBox cbo, DataTable dt)
        {
            return AtribuirData(cbo, dt, new Button());
        }
        
        public static bool AtribuirData(this ComboBox cbo, DataTable dt, Button btn)
        {
            try
            {
                if (dt.Rows.Count <= 0)
                    throw new Exception();

                cbo.ValueMember = dt.Columns[0].ColumnName;
                cbo.DisplayMember = dt.Columns[1].ColumnName;
                cbo.DataSource = dt;

                HabilitarComponente.Habilitar(cbo, btn);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Falha ao carregar dados!");
                HabilitarComponente.Desabilitar(cbo, btn);
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao executar operação!\n\nErro: " + ex.Message);
                HabilitarComponente.Desabilitar(cbo, btn);
                return false;
            }

            return true;
        }

        public static bool AtribuirDataOperador(this ComboBox cbo, DataTable dt)
        {
            return AtribuirDataOperador(cbo, dt, new Button());
        }
        
        public static bool AtribuirDataOperador(this ComboBox cbo, DataTable dt, Button btn)
        {
            try
            {
                if (dt.Rows.Count <= 0)
                    throw new Exception();

                cbo.ValueMember = dt.Columns[0].ColumnName;
                cbo.DisplayMember = dt.Columns[2].ColumnName;
                cbo.DataSource = dt;

                HabilitarComponente.Habilitar(cbo, btn);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Falha ao carregar dados!");
                HabilitarComponente.Desabilitar(cbo, btn);
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao executar operação!\n\nErro: " + ex.Message);
                HabilitarComponente.Desabilitar(cbo, btn);
                return false;
            }

            return true;
        }

    }
}
