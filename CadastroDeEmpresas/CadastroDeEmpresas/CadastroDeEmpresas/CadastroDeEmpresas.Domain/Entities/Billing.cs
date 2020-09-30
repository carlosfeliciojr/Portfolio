namespace CadastroDeEmpresas.CadastroDeEmpresas.Domain.Entities
{
    public class Billing
    {
        // Properties:

        public bool Free { get; set; }
        public bool Database { get; set; }


        // Constructors:

        public Billing()
        {
        }

        public Billing(bool free, bool database)
        {
            Free = free;
            Database = database;
        }
    }
}
