using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AppCalculo

{
    internal class calculaFaixaInss
    {
        double salario = 0;
        public calculaFaixaInss()
        {

        }
        public double faixaInss(double valor)
        {
            if (valor == 1320) return valor = (valor * 7.5) / 100;
            else if (valor > 1320 && valor < 2571.29) return valor = (valor * 9) / 100;
            else if (valor > 2571.30 && valor < 3856.94) return valor = (valor * 12) / 100;
            else return valor = (valor * 14) / 100;
        }

    }
}
