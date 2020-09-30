using CadastroDeEmpresas.CadastroDeEmpresas.Domain.Shared;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace CadastroDeEmpresas.CadastroDeEmpresas.Domain.Entities
{
    public class CompanyModel : ICompany
    {
        // Properties:

        // WebService Information Properties
        public string CnpjRequired { get; set; }
        [JsonProperty("status")]
        public string Status { get; private set; }
        [JsonProperty("billing")]
        public Billing Billing { get; private set; }

        // Main Information Properties:
        [JsonProperty("cnpj")]
        public string Cnpj { get; private set; }
        [JsonProperty("tipo")]
        public string Type { get; private set; }
        [JsonProperty("porte")]
        public string Size { get; private set; }
        [JsonProperty("abertura")]
        public string Opening { get; private set; }
        [JsonProperty("nome")]
        public string Name { get; private set; }
        [JsonProperty("fantasia")]
        public string FantasyName { get; private set; }
        [JsonProperty("atividade_principal")]
        public List<MainActivity> MainActivity { get; private set; }
        [JsonProperty("atividades_secundarias")]
        public List<SecondaryActivity> SecundaryActivities { get; private set; }
        [JsonProperty("natureza_juridica")]
        public string JudicialNature { get; private set; }

        // Contact and location Properties:
        [JsonProperty("logradouro")]
        public string Street { get; private set; }
        [JsonProperty("numero")]
        public string Number { get; private set; }
        [JsonProperty("complemento")]
        public string Complement { get; private set; }
        [JsonProperty("cep")]
        public string ZipCode { get; private set; }
        [JsonProperty("bairro")]
        public string Neighborhood { get; private set; }
        [JsonProperty("municipio")]
        public string City { get; private set; }
        [JsonProperty("uf")]
        public string State { get; private set; }
        [JsonProperty("email")]
        public string Email { get; private set; }
        [JsonProperty("telefone")]
        public string Telephone { get; private set; }

        // Others Information Properties:
        [JsonProperty("efr")]
        public string ResponsibleFederativeEntity { get; private set; }
        [JsonProperty("situacao")]
        public string Situation { get; private set; }
        [JsonProperty("data_situacao")]
        public string DateSituation { get; private set; }
        [JsonProperty("motivo_situacao")]
        public string ReasonSituation { get; private set; }
        [JsonProperty("situacao_especial")]
        public string SpecialSituation { get; private set; }
        [JsonProperty("data_situacao_especial")]
        public string DateSpecialSituation { get; private set; }
        [JsonProperty("capital_social")]
        public string SocialCapital { get; private set; }
        [JsonProperty("qsa")]
        public List<Qsa> MembershipAndAdministrators { get; private set; }
        [JsonProperty("ultima_atualizacao")]
        public string LastUpdate { get; private set; }


        // Constructors:

        public CompanyModel()
        {
        }

        public CompanyModel(string cnpj,
                            string type,
                            string size,
                            string opening,
                            string name,
                            string fantasyName,
                            string judicialNature,
                            string street,
                            string number,
                            string complement,
                            string zipCode,
                            string neighborhood,
                            string city,
                            string state,
                            string email,
                            string telephone,
                            string responsibleFederativeEntity,
                            string situation,
                            string dateSituation,
                            string reasonSituation,
                            string specialSituation,
                            string dateSpecialSituation,
                            string socialCapital,
                            string lastUpdate)
        {
            Cnpj = cnpj;
            Type = type;
            Size = size;
            Opening = opening;
            Name = name;
            FantasyName = fantasyName;
            JudicialNature = judicialNature;
            Street = street;
            Number = number;
            Complement = complement;
            ZipCode = zipCode;
            Neighborhood = neighborhood;
            City = city;
            State = state;
            Email = email;
            Telephone = telephone;
            ResponsibleFederativeEntity = responsibleFederativeEntity;
            Situation = situation;
            DateSituation = dateSituation;
            ReasonSituation = reasonSituation;
            SpecialSituation = specialSituation;
            DateSpecialSituation = dateSpecialSituation;
            SocialCapital = socialCapital;
            LastUpdate = lastUpdate;
        }


        // Methods:

        public CompanyModel GetDataCompany()
        {
            var company = new CompanyModel();
            return company;
        }

        public void SetCnpj(string cnpj)
        {
            Cnpj = cnpj;
        }

        public CompanyModel SetDataCompany(string cnpj,
                            string type,
                            string size,
                            string opening,
                            string name,
                            string fantasyName,
                            string judicialNature,
                            string street,
                            string number,
                            string complement,
                            string zipCode,
                            string neighborhood,
                            string city,
                            string state,
                            string email,
                            string telephone,
                            string responsibleFederativeEntity,
                            string situation,
                            string dateSituation,
                            string reasonSituation,
                            string specialSituation,
                            string dateSpecialSituation,
                            string socialCapital,
                            string lastUpdate)
        {
            var company = new CompanyModel()
            {
                Cnpj = cnpj,
                Type = type,
                Size = size,
                Opening = opening,
                Name = name,
                FantasyName = fantasyName,
                JudicialNature = judicialNature,
                Street = street,
                Number = number,
                Complement = complement,
                ZipCode = zipCode,
                Neighborhood = neighborhood,
                City = city,
                State = state,
                Email = email,
                Telephone = telephone,
                ResponsibleFederativeEntity = responsibleFederativeEntity,
                Situation = situation,
                DateSituation = dateSituation,
                ReasonSituation = reasonSituation,
                SpecialSituation = specialSituation,
                DateSpecialSituation = dateSpecialSituation,
                SocialCapital = socialCapital,
                LastUpdate = lastUpdate
            };
            return company;
        }
    }
}
