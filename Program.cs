
using AtividadeOO130323;

Cliente c = new Cliente()
{
    Id = 1,
    Nome = "Marquinhos",
    NomePai = "José",
    NomeMae = "Ana",
    Telefone = "(11) 1111-1111",
    Endereco = new Endereco()
    {
        Id = 1,
        Logradouro = "Rua José Mario",
        Bairro = "Jardim dos Peixes",
        Numero = 17,
        CEP = "114323-000"
    }
};

Console.WriteLine(c);

