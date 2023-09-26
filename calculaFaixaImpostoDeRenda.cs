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
            if (valor <= 1903.28)
            {
                Console.WriteLine();
                Console.WriteLine("IRRF Isento");
                return valor;
            }
            else if (valor > 1903.99 && valor <= 2826.65)
            {
                Console.WriteLine();
                Console.WriteLine("IRRF");
                Console.WriteLine("Alíquota: 7,5% \nDedução: R$142.80 \n ");
                var resultado = (((valor * 7.5) / 100) - 142.80);
                Console.WriteLine("Desconto IRRF " + resultado);
                resultado = valor - resultado;
                Console.WriteLine("Valor corrigido: " + resultado);
                return resultado;
            }
            else if (valor >= 2826.66 && valor <= 3751.05)
            {
                Console.WriteLine();
                Console.WriteLine("IRRF");
                Console.WriteLine("Alíquota: 15% \nDedução: R$354.80 \n");
                var resultado = ((valor * 15) / 100) - 354.80;
                Console.WriteLine("Desconto IRRF " + resultado);
                resultado = valor - resultado;
                Console.WriteLine("Valor corrigido: " + resultado);
                return resultado;
            }
            else if (valor >= 3751.06 && valor <= 4664.68)
            {
                Console.WriteLine();
                Console.WriteLine("IRRF");
                Console.WriteLine("Alíquota: 22,5% \nDedução: R$636,13 \n");
                var resultado = ((valor * 22.5) / 100) - 636.13;
                Console.WriteLine("Desconto IRRF " + resultado);
                resultado = valor - resultado;
                Console.WriteLine("Valor corrigido: " + resultado);
                return resultado;
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("IRRF");
                Console.WriteLine("Teto do IRRF: R$869.36");
                var resultado = ((valor * 27.5) / 100) - 869.36;
                Console.WriteLine("Desconto IRRF " + resultado);
                resultado = valor - resultado;
                Console.WriteLine("Valor corrigido: " + resultado);
                return resultado;
            }
        }
    }
}
