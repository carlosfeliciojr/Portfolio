namespace CadastroDeEmpresas.CadastroDeEmpresas.Domain.Entities
{
    public class Qsa
    {
        // Properties:

        public string Qual { get; set; }
        public string Name { get; set; }
        public string OriginCountry { get; set; }


        // Constructors:

        public Qsa()
        {
        }

        public Qsa(string qual, string name, string originCountry)
        {
            Qual = qual;
            Name = name;
            OriginCountry = originCountry;
        }


        // Overrides:

        public override string ToString()
        {
            return $"Qualificação: {Qual} - Nome: {Name} - Origem: {OriginCountry}"; 
        }
    }
}
