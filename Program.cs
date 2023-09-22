

using AppCalculo;

var inss = new calculaFaixaInss();
var irrf = new calculaFaixaImpostoDeRenda();
Console.WriteLine(inss.faixaInss(3856.95));
Console.WriteLine(irrf.CalculaFaixaImposto(3856.95));


