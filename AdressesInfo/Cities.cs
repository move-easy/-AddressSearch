namespace AddressSearch.AdressesInfo
{
    public class Economy
    {
        public string PIB { get; set; }
        public List<string> principais_setores { get; set; }
    }

    public class Tourism
    {
        public List<string> pontos_turisticos { get; set; }
    }

    public class Airport
    {
        public String Nome { get; set; }
        public string Codigo { get; set; }
        public string Tipo { get; set; }
    }

    public class Subway
    {
        public int Linhas { get; set; }
        public double Extensao_km { get; set; }
    }

    public class Bus
    {
        public int Linhas { get; set; }
        public int veiculos { get; set; }

    }


    public class PublicTransportation
    {
        public Subway Metro { get; set; }
        public Bus Onibus { get; set; }

    }

    public class Museum
    {
        public int Museus { get; set; }
        public List<string> Principais_museus { get; set; }

    }

    public class Theater
    {
        public int Teatros { get; set; }
        public List<string> Principais_teatros { get; set; }

    }

    public class Park
    {
        public int Parques { get; set; }
        public List<string> principais_parques { get; set; }

    }

    public class BusStation
    {
        public int Rodoviarias { get; set; }
        public List<string> Principais_rodoviarias { get; set; }

    }

    public class infrastructure
    {
        public List<Airport> Aeroportos { get; set; }
        public PublicTransportation Transportes_publicos { get; set; }
        public Museum Museus { get; set; }
        public Theater Teatro { get; set; }
        public Park Parques { get; set; }
        public BusStation Rodoviarias { get; set; }
    }

    public class Education
    {
        public List<string> Principais_universidades { get; set; }
    }

    public class Health
    {
        public int hospitais { get; set; }
        public List<string> Principais_hospitais { get; set; }

    }

    public class Climate
    {
        public String Tipo { get; set; }
        public double Temperatura_media_anual_celsius { get; set; }
        public double Precipitacao_media_anual_mm { get; set; }
    }

    public class CrimeIndicator
    {
        public double Homicidios_por_100_mil_habitantes { get; set; }
        public double Roubos_por_100_mil_habitantes { get; set; }
        public double Furtos_por_100_mil_habitantes { get; set; }
        public double Veiculos_roubados_por_100_mil_habitantes { get; set; }
    }

    public class Policing
    {
        public int Delegacias { get; set; }
        public int Postos_policiais { get; set; }
        public int Efetivo_policial { get; set; }
    }

    public class Security
    {
        public CrimeIndicator Indicadores_criminalidade { get; set; }
        public Policing Policiamento { get; set; }
        public List<string> programas_de_seguranca { get; set; }

    }

    public class CongestionIndicator
    {
        public int Tempo_medio_deslocamento_minutos { get; set; }
        public int Pico_congestionamento_km { get; set; }
    }

    public class VehicleTraffic
    {
        public List<String> Principais_corredores { get; set; }
        public int Veiculos_registrados { get; set; }
        public CongestionIndicator Indicadores_congestionamento { get; set; }

    }

    public class Home
    {
        public int Aluguel_apartamento_centro_mensal { get; set; }
        public int Aluguel_apartamento_periferia_mensal { get; set; }
        public int Preco_m2_compra_centro { get; set; }
        public int Preco_m2_compra_periferia { get; set; }
    }

    public class Transport
    {
        public double bilhete_unico_metro_onibus { get; set; }
        public int passe_mensal_transporte_publico { get; set; }
        public double gasolina_litro { get; set; }
    }

    public class AverageCost
    {
        public Home Moradia { get; set; }
        public Transport Transporte { get; set; }
    }

    public class City
    {
        public string Nome { get; set; }
        public string Estado { get; set; }
        public string Pais { get; set; }
        public int Populacao { get; set; }
        public double densidade_populacional_km2 { get; set; }
        public Economy Economia { get; set; }
        public Tourism Turismo { get; set; }
        public infrastructure Infrastrutura { get; set; }
        public Education Educacao { get; set; }
        public Health Saude { get; set; }
        public Climate Clima { get; set; }
        public Security Seguranca { get; set; }
        public VehicleTraffic Trafego_veiculos { get; set; }
        public AverageCost Custos_medios { get; set; }

    }

    public class CityInfo
    {
        public City City { get; set; }
    }


    public class Cities
    {
        public CityInfo Data { get; set; }

        public Cities()
        {
            Data = new CityInfo()
            {
                City = new City
                {
                    Nome = "S",
                    Estado = "São Paulo",
                    Pais = "Brasil",
                    Populacao = 12396372,
                    densidade_populacional_km2 = 8144.82,
                    Economia = new Economy()
                    {
                        PIB = "699 bilhões de reais",
                        principais_setores = new List<string> { "Serviços", "Indústria", "Comércio" },
                    },
                    Turismo = new Tourism()
                    {
                        pontos_turisticos = new List<string>
                        {
                            "Avenida Paulista", "Parque Ibirapuera", "Museu de Arte de São Paulo (MASP)",
                            "Catedral da Sé"
                        }
                    },
                    Infrastrutura = new infrastructure()
                    {
                        Aeroportos = new List<Airport>()
                        {
                            new Airport { Nome = "Aeroporto de Congonhas", Codigo = "CGH", Tipo = "doméstico" },
                            new Airport
                            {
                                Nome = "Aeroporto Internacional de Guarulhos", Codigo = "GRU", Tipo = "internacional"
                            }
                        },
                        Transportes_publicos = new PublicTransportation()
                        {
                            Metro = new Subway()
                            {
                                Linhas = 6,
                                Extensao_km = 101.1
                            },
                            Onibus = new Bus()
                            {
                                Linhas = 1500,
                                veiculos = 15000
                            }
                        },
                        Museus = new Museum()
                        {
                            Museus = 110,
                            Principais_museus = new List<string>()
                                { "Museu de Arte de São Paulo (MASP)", "Museu do Ipiranga", "Pinacoteca do Estado" }
                        },
                        Teatro = new Theater()
                        {
                            Teatros = 150,
                            Principais_teatros = new List<string>()
                                { "Teatro Municipal de São Paulo", "Teatro Alfa", "Teatro Sérgio Cardoso" }
                        },
                        Parques = new Park()
                        {
                            Parques = 4,
                            principais_parques = new List<string>
                            {
                                "Terminal Rodoviário Tietê", "Terminal Rodoviário Barra Funda",
                                "Terminal Rodoviário Jabaquara"
                            }
                        },
                        Rodoviarias = new BusStation()
                        {
                            Rodoviarias = 4,
                            Principais_rodoviarias = new List<string>
                            {
                                "Terminal Rodoviário Tietê", "Terminal Rodoviário Barra Funda",
                                "Terminal Rodoviário Jabaquara"
                            }
                        }
                    },
                    Educacao = new Education()
                    {
                        Principais_universidades = new List<string>
                        {
                            "Universidade de São Paulo (USP)", "Universidade Estadual Paulista (UNESP)",
                            "Pontifícia Universidade Católica de São Paulo (PUC-SP)"
                        }
                    },
                    Saude = new Health()
                    {
                        hospitais = 72,
                        Principais_hospitais = new List<string>
                            { "Hospital das Clínicas", "Hospital Sírio-Libanês", "Hospital Albert Einstein" }
                    },
                    Clima = new Climate()
                    {
                        Tipo = "Tropical",
                        Temperatura_media_anual_celsius = 27.9,
                        Precipitacao_media_anual_mm = 146
                    },
                    Seguranca = new Security()
                    {
                        Indicadores_criminalidade = new CrimeIndicator()
                        {
                            Homicidios_por_100_mil_habitantes = 6.4,
                            Roubos_por_100_mil_habitantes = 286.3,
                            Furtos_por_100_mil_habitantes = 400,
                            Veiculos_roubados_por_100_mil_habitantes = 90.3
                        },
                        Policiamento = new Policing()
                        {
                            Delegacias = 80,
                            Postos_policiais = 120,
                            Efetivo_policial = 40000
                        },
                        programas_de_seguranca = new List<string>
                            { "Vizinhança Solidária", "Polícia Comunitária", "Patrulha do Bairro" }
                    },
                    Trafego_veiculos = new VehicleTraffic()
                    {
                        Principais_corredores = new List<string>
                            { "Marginal Tietê", "Marginal Pinheiros", "Avenida 23 de Maio", "Avenida Paulista" },
                        Veiculos_registrados = 800000,
                        Indicadores_congestionamento = new CongestionIndicator()
                        {
                            Tempo_medio_deslocamento_minutos = 45,
                            Pico_congestionamento_km = 240
                        }
                    },
                    Custos_medios = new AverageCost()
                    {
                        Moradia = new Home()
                        {
                            Aluguel_apartamento_centro_mensal = 3500,
                            Aluguel_apartamento_periferia_mensal = 2200,
                            Preco_m2_compra_centro = 12000,
                            Preco_m2_compra_periferia = 7500
                        },
                        Transporte = new Transport()
                        {
                            bilhete_unico_metro_onibus = 4.50,
                            passe_mensal_transporte_publico = 220,
                            gasolina_litro = 6.0
                        }
                    }
                }
            };
        }
        
        public object GetCityData()
        {
            return new
            {
                data = Data
            };
        }
    }
}