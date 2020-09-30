namespace CadastroDeEmpresas.CadastroDeEmpresas.Domain.Entities
{
    public class SecondaryActivity
    {
        // Properties:

        public string Text { get; set; }
        public string Code { get; set; }


        // Constructors:

        public SecondaryActivity()
        {
        }

        public SecondaryActivity(string text, string code)
        {
            Text = text;
            Code = code;
        }


        // Overrides:

        public override string ToString()
        {
            return $"{Code} - {Text}";
        }
    }
}
