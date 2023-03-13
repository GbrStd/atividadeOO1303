namespace AtividadeOO130323
{
    class Endereco
    {
        public int Id { get; set; }
        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public int Numero { get; set; }
        public string CEP { get; set; }

        public override string ToString()
        {
            return "[" +
                "Id: " + Id +
                "\nLogradouro: " + Logradouro +
                "\nBairro: " + Bairro +
                "\nNumero: " + Numero +
                "\nCEP: " + CEP +
                "]";
        }

    }
}
