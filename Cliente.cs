namespace AtividadeOO130323
{
    class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string NomePai { get; set; }
        public string NomeMae { get; set; }
        public Endereco Endereco { get; set; }

        public override string ToString()
        {
            return "[" +
                "Id: " + Id +
                "\nNome: " + Nome +
                "\nTelefone: " + Telefone +
                "\nNomePai: " + NomePai +
                "\nNomeMae: " + NomeMae +
                "\nEndereco: " + Endereco
                + "]";
        }

    }
}
