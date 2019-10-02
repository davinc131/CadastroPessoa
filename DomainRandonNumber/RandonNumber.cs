using System;
using System.Collections.Generic;
using System.Text;

namespace DomainRandonNumber
{
    public class RandonNumber
    {
        public int NumberA { get; set; }
        public int NumberB { get; set; }
        public string Sinal { get; set; }
        public float Response { get; set; }

        public RandonNumber(int a, int b, string sinal)
        {
            NumberA = a;
            NumberB = b;
            Sinal = sinal;

            switch (Sinal)
            {
                case "+":
                    Soma();
                    break;
                case "-":
                    Subtracao();
                    break;
                case "*":
                    Multiplicacao();
                    break;
                case "/":
                    Divisão();
                    break;
            }
        }

        private float Soma()
        {
            return Response = NumberA + NumberB;
        }

        private float Subtracao()
        {
            return Response = NumberA - NumberB;
        }

        private float Multiplicacao()
        {
            return Response = (float)NumberA * (float)NumberB;
        }

        private float Divisão()
        {
            return Response = (float)NumberA / (float)NumberB;
        }
    }
}
