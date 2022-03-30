namespace CursoFundamentosOOP_Solid;

class ClienteRico
{
    public int Id { get; private set; }
    public string Nome { get; private set; }
    public string Endereco { get; private set; }

    public ClienteRico(int id, string nome, string endereco)
    {

        DomainExceptionValidation.When(id < 0, "Id Inválido");

        DomainExceptionValidation.When(string.IsNullOrEmpty(nome), 
            "Campo nome não pode ser vazio");

        DomainExceptionValidation.When(string.IsNullOrEmpty(endereco), 
            "Campos não podem ser vazios");

        this.Id = id;
        this.Nome = nome;
        this.Endereco = endereco;
    }
}
