using CursoFundamentosOOP_Solid;






ClienteRico cliente = new ClienteRico(-1,"", null);

Console.WriteLine($"{cliente.Id} {cliente.Nome} {cliente.Endereco}");


static ClienteAnemico ClienteAnemicoTeste()
{
    ClienteAnemico cliente = new ClienteAnemico();

    cliente.Nome = "";
    cliente.Endereco = null;
    cliente.Id = -1;

    return cliente;
}