using System;
using System.Collections.Generic;
using System.Text;

namespace Common
{
    public class DateTimeCalculate
    {
        public DateTime DataAnterior24()
        {
            DateTime dataAtual = DateTime.Now;

            int mes = dataAtual.Month;
            int ano = dataAtual.Year;

            int cont24 = 24;

            for(int i = cont24; i > 0; i--)
            {
                mes--;

                if(mes == 0)
                {
                    mes = 12;
                    ano--;
                }
            }

            Console.WriteLine(mes + " " + ano);

            return new DateTime(ano, mes, 1);
        }

        public DateTime DataAnterior12()
        {
            DateTime dataAtual = DateTime.Now;

            int mes = dataAtual.Month;
            int ano = dataAtual.Year;

            int cont12 = 12;

            for (int i = cont12; i > 0; i--)
            {
                mes--;

                if (mes == 0)
                {
                    mes = 12;
                    ano--;
                }
            }

            Console.WriteLine(mes + " " + ano);

            return new DateTime(ano, mes, 1);
        }

        public List<DateTime> DatasEmUmMes(List<DateTime> listDate, int mes, int ano)
        {
            List<DateTime> lista = new List<DateTime>();

            lista = listDate.FindAll(c => c.Year == ano);
            lista = listDate.FindAll(c => c.Month == mes);

            return lista;
        }

        public List<DateTime> DatasMenores(List<DateTime> listDate, DateTime data)
        {
            List<DateTime> lista = new List<DateTime>();

            foreach (var team in listDate.FindAll(x => x <= data))
                lista.Add(team);

            return lista;
        }

        public List<DateTime> DatasMaiores(List<DateTime> listDate, DateTime data)
        {
            List<DateTime> lista = new List<DateTime>();

            foreach (var team in listDate.FindAll(x => x >= data))
                lista.Add(team);

            return lista;
        }
    }
}
