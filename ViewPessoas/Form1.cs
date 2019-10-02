using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DomainPessoa.Entities;
using DomainPessoa.Service;

namespace ViewPessoas
{

    public partial class Form1 : Form
    {
        private ServicePessoa _servicePessoa;
        public Form1()
        {
            InitializeComponent();
            _servicePessoa = new ServicePessoa();
        }

        private void ButtonGetPessoas_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridViewPessoa.DataSource = _servicePessoa.GetCheckedPessoas(_servicePessoa.GetPessoas());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ButtonSelcionado_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridViewSelecionados.DataSource = _servicePessoa.SetListPessoa(ObterSelecionados());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private List<CheckedPessoa> ObterSelecionados()
        {
            List<CheckedPessoa> checkedPessoas = new List<CheckedPessoa>();

            for (int i = 0; i < dataGridViewPessoa.RowCount; i++)
            {
                if (Boolean.Parse(dataGridViewPessoa.Rows[i].Cells[0].Value.ToString()) == true)
                {
                    CheckedPessoa p = new CheckedPessoa();
                    var c = dataGridViewPessoa.Rows[i].Cells[0].Value;
                    var ii = dataGridViewPessoa.Rows[i].Cells[1].Value;
                    var n = dataGridViewPessoa.Rows[i].Cells[2].Value;
                    var nn = dataGridViewPessoa.Rows[i].Cells[3].Value;
                    var cp = dataGridViewPessoa.Rows[i].Cells[4].Value;

                    p.Checked = Boolean.Parse(c.ToString());
                    p.Id = Guid.Parse(ii.ToString());
                    p.PrimeiroNome = n.ToString();
                    p.SegundoNome = nn.ToString();
                    p.Cpf = cp.ToString();

                    checkedPessoas.Add(p);
                }
            }

            return checkedPessoas;
        }

    }
}
