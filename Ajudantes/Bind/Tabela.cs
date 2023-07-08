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
    public static class Tabela
    {
        public static bool ObterDataSource(DataTable dt, ComboBox cbo)
        {
            return ObterDataSource(dt, cbo, new Button());
        }
        public static bool ObterDataSource(DataTable dt, ComboBox cbo, Button btn)
        {
            try
            {
                //DataTable dt = Pr_ObterUnidadeMedida.Obter();

                if (dt.Rows.Count <= 0)
                    throw new Exception();

                cbo.ValueMember = dt.Columns[0].ColumnName;
                cbo.DisplayMember = dt.Columns[1].ColumnName;
                cbo.DataSource = dt;

                Componente.Habilitar(cbo, btn);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Falha ao carregar dados!");
                Componente.Desabilitar(cbo, btn);
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao executar operação!\n\nErro: " + ex.Message);
                Componente.Desabilitar(cbo, btn);
                return false;
            }
            
            return true;
        }
    }
}
