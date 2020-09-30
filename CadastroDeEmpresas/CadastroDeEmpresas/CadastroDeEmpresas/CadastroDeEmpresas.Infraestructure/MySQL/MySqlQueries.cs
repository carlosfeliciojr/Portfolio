using CadastroDeEmpresas.CadastroDeEmpresas.Domain.Shared;
using CadastroDeEmpresas.CadastroDeEmpresas.Infraestructure.Shared;
using System.Data;

namespace CadastroDeEmpresas.CadastroDeEmpresas.Infraestructure.MySQL
{
    public class MySqlQueries : AbstractQueries, IQueries
    {
        // Dependency Injection.

        private ICompany _company;

        public MySqlQueries(ICompany companyModel)
        {
            _company = companyModel;
        }


        // Methods:

        public override void RegisterCompany(ICompany company)
        {
            _sql = "insert into empresas(cnpj, " +
                                        "tipo, " +
                                        "abertura, " +
                                        "nome, " +
                                        "fantasia, " +
                                        "natureza_juridica, " +
                                        "logradouro," +
                                        "numero, " +
                                        "complemento, " +
                                        "cep, " +
                                        "bairro, " +
                                        "municipio, " +
                                        "porte, " +
                                        "uf, " +
                                        "email, " +
                                        "telefone, " +
                                        "efr, " +
                                        "situacao," +
                                        "data_situacao, " +
                                        "motivo_situacao, " +
                                        "situacao_especial, " +
                                        "data_situacao_especial, " +
                                        "capital_social)" +
                                       $"values('" +
                                       $"{company.GetDataCompany().Cnpj}','" +
                                       $"{company.GetDataCompany().Type}','" +
                                       $"{company.GetDataCompany().Opening}','" +
                                       $"{company.GetDataCompany().Name}','" +
                                       $"{company.GetDataCompany().FantasyName}','" +
                                       $"{company.GetDataCompany().JudicialNature}','" +
                                       $"{company.GetDataCompany().Street}','" +
                                       $"{company.GetDataCompany().Number}','" +
                                       $"{company.GetDataCompany().Complement}','" +
                                       $"{company.GetDataCompany().ZipCode}','" +
                                       $"{company.GetDataCompany().Neighborhood}','" +
                                       $"{company.GetDataCompany().City}','" +
                                       $"{company.GetDataCompany().Size}','" +
                                       $"{company.GetDataCompany().State}','" +
                                       $"{company.GetDataCompany().Email}','" +
                                       $"{company.GetDataCompany().Telephone}','" +
                                       $"{company.GetDataCompany().ResponsibleFederativeEntity}','" +
                                       $"{company.GetDataCompany().Situation}','" +
                                       $"{company.GetDataCompany().DateSituation}','" +
                                       $"{company.GetDataCompany().ReasonSituation}','" +
                                       $"{company.GetDataCompany().SpecialSituation}','" +
                                       $"{company.GetDataCompany().DateSpecialSituation}','" +
                                       $"{company.GetDataCompany().SocialCapital}')";
            _dal.ExecuteSqlCommand(_sql);
        }

        public override ICompany ConsultCompany(string cnpj)
        {
            string cnpjFormatted = FormatCnpjCpf.FormatCnpj(cnpj);
            _sql = $"select * from empresas where cnpj = '{cnpjFormatted}'";
            DataTable data = _dal.ReturnDataTable(_sql);
            _company.SetDataCompany
            (data.Rows[0]["cnpj"].ToString(),
             data.Rows[0]["type"].ToString(),
             data.Rows[0]["size"].ToString(),
             data.Rows[0]["opening"].ToString(),
             data.Rows[0]["name"].ToString(),
             data.Rows[0]["fantasyName"].ToString(),
             data.Rows[0]["judicialNature"].ToString(),
             data.Rows[0]["street"].ToString(),
             data.Rows[0][" number"].ToString(),
             data.Rows[0]["complement"].ToString(),
             data.Rows[0]["zipCode"].ToString(),
             data.Rows[0]["neighborhood"].ToString(),
             data.Rows[0]["city"].ToString(),
             data.Rows[0]["state"].ToString(),
             data.Rows[0]["email"].ToString(),
             data.Rows[0]["telephone"].ToString(),
             data.Rows[0]["responsibleFederativeEntity"].ToString(),
             data.Rows[0]["situation"].ToString(),
             data.Rows[0]["dateSituation"].ToString(),
             data.Rows[0]["reasonSituation"].ToString(),
             data.Rows[0]["specialSituation"].ToString(),
             data.Rows[0]["dateSpecialSituation"].ToString(),
             data.Rows[0]["socialCapital"].ToString(),
             data.Rows[0]["lastUpdate"].ToString()
            );
            return _company;
        }

        public override void UpdateCompany()
        {
            string cnpjFormatted = FormatCnpjCpf.FormatCnpj(_company.GetDataCompany().Cnpj);
            _sql = "update cliente set " +
                         $"tipo = '{_company.GetDataCompany().Cnpj}', " +
                         $"abertura = '{_company.GetDataCompany().Opening}', " +
                         $"nome = '{_company.GetDataCompany().Name}', " +
                         $"fantasia = '{_company.GetDataCompany().FantasyName}', " +
                         $"natureza_juridica = '{_company.GetDataCompany().JudicialNature}', " +
                         $"logradouro = '{_company.GetDataCompany().Street}', " +
                         $"numero = '{_company.GetDataCompany().Number}', " +
                         $"complemento = '{_company.GetDataCompany().Complement}', " +
                         $"cep = '{_company.GetDataCompany().ZipCode}', " +
                         $"bairro = '{_company.GetDataCompany().Neighborhood}', " +
                         $"municipio = '{_company.GetDataCompany().City}', " +
                         $"porte = '{_company.GetDataCompany().Size}', " +
                         $"uf = '{_company.GetDataCompany().State}', " +
                         $"email = '{_company.GetDataCompany().Email}', " +
                         $"telefone = '{_company.GetDataCompany().Telephone}', " +
                         $"efr = '{_company.GetDataCompany().ResponsibleFederativeEntity}', " +
                         $"situacao = '{_company.GetDataCompany().Situation}', " +
                         $"data_stuacao = '{_company.GetDataCompany().DateSituation}', " +
                         $"motivo_situacao = '{_company.GetDataCompany().ReasonSituation}', " +
                         $"situacao_especial = '{_company.GetDataCompany().SpecialSituation}', " +
                         $"data_situacao_especial = '{_company.GetDataCompany().DateSpecialSituation}', " +
                         $"capital_social = '{_company.GetDataCompany().SocialCapital}' " +
                         $"where cnpj = '{cnpjFormatted}'";
            _dal.ExecuteSqlCommand(_sql);
        }

        public override void ExcludeCompany(string cnpj)
        {
            _sql = $"delete from empresas where cnpj = '{cnpj}'";
            _dal.ExecuteSqlCommand(_sql);
        }
    }
}
