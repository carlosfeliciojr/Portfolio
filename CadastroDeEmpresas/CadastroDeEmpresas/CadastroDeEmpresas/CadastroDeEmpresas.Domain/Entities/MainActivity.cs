namespace CadastroDeEmpresas.CadastroDeEmpresas.Domain.Entities
{
    public class MainActivity
    {
        // Properties:

        public string Text { get; set; }
        public string Code { get; set; }


        // Constructors:

        public MainActivity()
        {
        }

        public MainActivity(string text, string code)
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
