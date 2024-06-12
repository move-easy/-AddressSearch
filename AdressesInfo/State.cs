namespace AddressSearch.AdressesInfo
{
    public class CityIdentification
    {
        public string Cep { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
    }

    public class State
    {
        public List<CityIdentification> Data { get; set; }
        public int QuantidadeCidades { get; set; }

        public State(String param)
        {
            Data = new List<CityIdentification>
            {
                new CityIdentification { Cep = "29102345", Cidade = "Vila Velha", Estado = param.ToUpper() },
                new CityIdentification { Cep = "29102355", Cidade = "Vitória", Estado = param.ToUpper() },
                new CityIdentification { Cep = "29102333", Cidade = "Serra", Estado = param.ToUpper() },
                new CityIdentification { Cep = "29102333", Cidade = "Serra", Estado = param.ToUpper() }
            };

            QuantidadeCidades = Data.Count;
        }

        public object GetStateData()
        {
            return new
            {
                data = Data,
                quantidade_cidades = QuantidadeCidades
            };
        }
    }
}