using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AppCalculo

{
    public class calculaFaixaInss
    {
        public double faixaInss(double valor)
        {
            if (valor <= 1320)
            {
                Console.WriteLine();
                Console.WriteLine("INSS");
                Console.WriteLine("Alíquota de 7.5%");
                double calculo = (valor * 7.5) / 100;
                valor = valor - calculo;
                Console.WriteLine("Salário com ajuste do INSS " + valor);
                Console.WriteLine("Desconto INSS " + calculo);
                return valor;
            }
            else if (valor > 1320 && valor < 2571.29)
            {
                Console.WriteLine();
                Console.WriteLine("INSS");
                Console.WriteLine("Alíquota de 9%");
                double calculo = (valor * 9) / 100;
                valor = valor - calculo;
                Console.WriteLine("Salário com ajuste do INSS " + valor);
                Console.WriteLine("Desconto INSS " + calculo);
                return valor;
            }
            else if (valor > 2571.30 && valor < 3856.94)
            {
                Console.WriteLine();
                Console.WriteLine("INSS");
                Console.WriteLine("Alíquota de 12%");
                double calculo = (valor * 12) / 100;
                valor = valor - calculo;
                Console.WriteLine("Salário com ajuste do INSS " + valor);
                Console.WriteLine("Desconto INSS " + calculo);
                return valor;
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("INSS");
                Console.WriteLine("Alíquota de 14%");
                double calculo = (valor * 14) / 100;
                valor = valor - calculo;
                Console.WriteLine("Salário com ajuste do INSS " + valor);
                Console.WriteLine("Desconto INSS " + calculo);
                return valor;
            }
        }

    }
}
