using CursoFundamentosOOP_Solid;
using CursoFundamentosOOP_Solid.Métodos_de_Extensão;
using CursoFundamentosOOP_Solid.Métodos_Estáticos;

#region Encapsulamento e Modelo de Domínio

//ClienteRico cliente = new ClienteRico(-1, "", null);
//Console.WriteLine($"{cliente.Id} {cliente.Nome} {cliente.Endereco}");


static ClienteAnemico ClienteAnemicoTeste()
{
    ClienteAnemico cliente = new ClienteAnemico();

    cliente.Nome = "";
    cliente.Endereco = null;
    cliente.Id = -1;

    return cliente;
}

#endregion

#region Métodos Estáticos

//Não há necessidade de se instanciar o objeto da classe para 
//acessar o método quando esse método é static
//Viola os paradgmas da POO
//Console.WriteLine("Soma = "+ Calculadora.Somar(2,4));
//Console.WriteLine("Soma = "+ Calculadora.Subtrair(4,2));

#endregion

#region Métodos de Extensão

var texto1 = "curso";
var texto2 = "madalena";

texto1 = texto1.CaixaAltaPrimeiraLetra();
texto2 = texto2.CaixaAltaPrimeiraLetra();
Console.WriteLine(texto1);
Console.WriteLine(texto2);

#endregion


Console.ReadLine();