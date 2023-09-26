﻿
using AppCalculo;

Console.WriteLine("Informe o seu salário");
double salario = Convert.ToDouble(Console.ReadLine());
Console.WriteLine();
Console.WriteLine("Escolha uma das opções abaixo: ");
Console.WriteLine();
Console.WriteLine("Tecle 1 para Exibir detalhes do pagamento");
Console.WriteLine("Tecle 2 para Fazer uma simulação de Férias");
Console.WriteLine("Tecle 3 para Calcular 13º");
Console.WriteLine("Tecle 1 para Simular Rescisão de contrato");
Console.WriteLine();
int opcaoEscolhida = Convert.ToInt16(Console.ReadLine());

switch (opcaoEscolhida)
{
    case 1:
        var inss = new calculaFaixaInss().faixaInss(salario);
        Console.WriteLine();
        Console.WriteLine("---------------------------------------------------------------------");
        var irrf = new calculaFaixaImpostoDeRenda().CalculaFaixaImposto(salario);
        Console.WriteLine("Opção escolhida: " + opcaoEscolhida + " Exibir detalhes do pagamento");
        Console.WriteLine("Salário informado R$: " + salario);
        Console.WriteLine("Desconto INSS : " +  inss);
        Console.WriteLine("Desconto IRRF : " + irrf);
        break;
}





