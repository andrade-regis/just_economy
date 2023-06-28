using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace just_economy
{
    /// <summary>
    /// Interação lógica para frmInício.xam
    /// </summary>
    public partial class frmInício : UserControl
    {
        public frmInício()
        {
            InitializeComponent();

            //DataTable Tabela = new DataTable();

            //Tabela.Columns.Add("Data");
            //Tabela.Columns.Add("Grupo");
            //Tabela.Columns.Add("Descrição");

            //for(int linhas = 1; linhas <= 10; linhas++)
            //{
            //    DataRow Linha = Tabela.NewRow();

            //    Linha["Data"] = "HOJE";
            //    Linha["Grupo"] = "HOJE";
            //    Linha["Descrição"] = "HOJE";

            //    Tabela.Rows.Add(Linha);
            //}

            //dataGrid.ItemsSource = Tabela.DefaultView;

        }
    }
}
