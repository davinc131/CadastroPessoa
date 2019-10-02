using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common;

namespace ViewPessoas
{
    public partial class ViewDateTime : Form
    {
        public ViewDateTime()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                DateTimeCalculate dateTimeCalculate = new DateTimeCalculate();

                MessageBox.Show(dateTimeCalculate.DataAnterior12().ToString(), "Data 12");
                MessageBox.Show(dateTimeCalculate.DataAnterior24().ToString(), "Data 24");

                List<DateTime> dateTimes = new List<DateTime>();
                List<DateTimePicker> dateTimePickers = new List<DateTimePicker>();

                dateTimePickers.Add(dateTimePicker1);
                dateTimePickers.Add(dateTimePicker2);
                dateTimePickers.Add(dateTimePicker3);
                dateTimePickers.Add(dateTimePicker4);

                foreach(DateTimePicker dateTimePicker in dateTimePickers)
                {
                    dateTimes.Add(dateTimePicker.Value);
                }

                foreach (DateTime d in dateTimeCalculate.DatasEmUmMes(dateTimes, int.Parse(textBoxMes.Text), int.Parse(textBoxAno.Text)))
                    MessageBox.Show(d.ToString(), "Datas em um mês");

                foreach (DateTime d in dateTimeCalculate.DatasMenores(dateTimes, DateTime.Now))
                    MessageBox.Show(d.ToString(), "Datas Menores");

                foreach (DateTime d in dateTimeCalculate.DatasMaiores(dateTimes, DateTime.Now))
                    MessageBox.Show(d.ToString(), "Datas Maiores");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
