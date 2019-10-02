using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DomainPessoa.Entities;
using DomainPessoa.Service;

namespace ViewPessoas
{
    public partial class Form3 : Form
    {
        private ServicePessoa _servicePessoa;
        public Form3()
        {
            InitializeComponent();
            _servicePessoa = new ServicePessoa();
        }

        private void ButtonCarregar_Click(object sender, EventArgs e)
        {
            try
            {
                //gridControlPessoa.DataSource = _servicePessoa.GetCheckedPessoas(_servicePessoa.GetPessoas());

                gridControlPessoa.DataSource = _servicePessoa.GetPessoas();

                //SelecionaLinhasPeloIndice();
                //SelecionarLinhaPorValor();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SelecionarLinhaPorValor()
        {
            for (int i = 0; i < gridView1.RowCount; i++)
            {
                if(gridView1.GetRowCellValue(i, "PrimeiroNome").ToString() == "Luciana" || gridView1.GetRowCellValue(i, "PrimeiroNome").ToString() == "Sueli" || gridView1.GetRowCellValue(i, "PrimeiroNome").ToString() == "Tomás")
                {
                    //Transfomra as linhas do GridView em um array manipulável
                    ColumnView view = gridControlPessoa.MainView as ColumnView;
                    //Seleciona uma linha em uma GridView()
                    view.SelectRow(i);
                }
            }
        }

        private void SelecionaLinhasPeloIndice()
        {
            for (int i = 0; i < gridView1.RowCount; i++)
            {
                
                //_______________________ACESSAR DADOS DE UMA LINHA DE UM GRIDVIEW______________________\\

                //Acessa um valor de um GRIDVIEW especificando a linha e o Parametro desejado
                //string s = gridView1.GetRowCellValue(i, "PrimeiroNome").ToString();

                //_____________________CONVERTE LINHA DE GRIDVIEW EM OBJETO DE CLASSE____________________\\

                //Transforma a linha especificada em uma Classe
                //Pessoa rec = view.GetRow(i) as Pessoa;
                //Imprime informações de acordo com os parâmetros especificados
                //MessageBox.Show(rec.PrimeiroNome.ToString() + " , " + rec.SegundoNome);

                // ___________________SELECIONA UMA LINHA_______________________________________\\

                //Transfomra as linhas do GridView em um array manipulável
                ColumnView view = gridControlPessoa.MainView as ColumnView;
                //Seleciona uma linha em uma GridView()
                view.SelectRow(i);
            }
        }

        private void ObterLinhasSelecionadas()
        {
            Int32[] selectedRowHandles = gridView1.GetSelectedRows();
            List<Pessoa> pessoas = new List<Pessoa>();

            for(int i = 0; i < selectedRowHandles.Length; i++)
            {
                //Transforma a linha especificada em uma Classe
                Pessoa rec = gridView1.GetRow(selectedRowHandles[i]) as Pessoa;
                //Adciona pessoas a lista
                pessoas.Add(rec);
            }

            gridControlPessoaSelecionada.DataSource = pessoas;
        }

        private void RemoverPessoas()
        {
            List<Pessoa> pessoasSelecionadas = new List<Pessoa>();

            for (int i = 0; i < gridView2.RowCount; i++)
            {
                pessoasSelecionadas.Add(gridView2.GetRow(i) as Pessoa);
            }

            gridControlPessoaSelecionada.DataSource = _servicePessoa.RemovePessoas(pessoasSelecionadas);
        }

        private void ButtonSelecionados_Click(object sender, EventArgs e)
        {
            try
            {
                ObterLinhasSelecionadas();
                gridView1.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ButtonRemover_Click(object sender, EventArgs e)
        {
            try
            {
                RemoverPessoas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
