using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCalculo
{
    public class calculaFaixaImpostoDeRenda
    {
        public calculaFaixaImpostoDeRenda()
        {

        }

        public double CalculaFaixaImposto(double valor)
        {
            if (valor > 2112 && valor < 2826.65)
            {
                Console.WriteLine();
                Console.WriteLine("IRRF");
                Console.WriteLine("*Alíquota: 7,5% \n*Dedução: R$158.40 \n ");
                var resultado = ((valor * 7.5) / 100) - 158.40;
                resultado = valor - resultado;
                Console.WriteLine("Valor corrigido: " + resultado);
                return resultado;
            }
            else if (valor > 2826.66 && valor < 3751.05)
            {
                Console.WriteLine();
                Console.WriteLine("IRRF");
                Console.WriteLine("*Alíquota: 15% \n*Dedução: R$370.40 \n");
                var resultado = ((valor * 15) / 100) - 370.40;
                resultado = valor - resultado;
                Console.WriteLine("Valor corrigido: " + resultado);
                return resultado;
            }
            else if (valor > 3751.06 && valor < 4664.68)
            {
                Console.WriteLine();
                Console.WriteLine("IRRF");
                Console.WriteLine("*Alíquota: 22,5% \n*Dedução: R$651,73 \n");
                var resultado = ((valor * 22.5) / 100) - 651.73;
                resultado = valor - resultado;
                Console.WriteLine("Valor corrigido: " + resultado);

                return resultado;
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("IRRF");
                Console.WriteLine("*Teto do IRRF: R$ 884,96");
                var resultado = ((valor * 27.5) / 100) - 884.96;
                return resultado;
            }
        }
    }
}
