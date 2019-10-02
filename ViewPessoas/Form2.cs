using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DomainPessoa.Service;

namespace ViewPessoas
{
    public partial class Form2 : Form
    {
        private ServicePessoa _servicePessoa;
        public Form2()
        {
            InitializeComponent();
            _servicePessoa = new ServicePessoa();
        }

        private void ButtonPessoa_Click(object sender, EventArgs e)
        {
            try
            {
                gridControlPessoas.DataSource = _servicePessoa.GetCheckedPessoas(_servicePessoa.GetPessoas());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ButtonSelecionados_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
