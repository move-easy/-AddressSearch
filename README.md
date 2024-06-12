# AddressSearch

## Endpoints
>[!IMPORTANT]
>
> The values ​​are mocked

### Get City information
- **Router:** [get] `/api/info/{zip-code}`

- **Response:**
```json
{
    "data": {
        "city": {
            "nome": "S",
            "estado": "São Paulo",
            "pais": "Brasil",
            "populacao": 12396372,
            "densidade_populacional_km2": 8144.82,
            "economia": {
                "pib": "699 bilhões de reais",
                "principais_setores": [
                    "Serviços",
                    "Indústria",
                    "Comércio"
                ]
            },
            "turismo": {
                "pontos_turisticos": [
                    "Avenida Paulista",
                    "Parque Ibirapuera",
                    "Museu de Arte de São Paulo (MASP)",
                    "Catedral da Sé"
                ]
            },
            "infrastrutura": {
                "aeroportos": [
                    {
                        "nome": "Aeroporto de Congonhas",
                        "codigo": "CGH",
                        "tipo": "doméstico"
                    },
                    {
                        "nome": "Aeroporto Internacional de Guarulhos",
                        "codigo": "GRU",
                        "tipo": "internacional"
                    }
                ],
                "transportes_publicos": {
                    "metro": {
                        "linhas": 6,
                        "extensao_km": 101.1
                    },
                    "onibus": {
                        "linhas": 1500,
                        "veiculos": 15000
                    }
                },
                "museus": {
                    "museus": 110,
                    "principais_museus": [
                        "Museu de Arte de São Paulo (MASP)",
                        "Museu do Ipiranga",
                        "Pinacoteca do Estado"
                    ]
                },
                "teatro": {
                    "teatros": 150,
                    "principais_teatros": [
                        "Teatro Municipal de São Paulo",
                        "Teatro Alfa",
                        "Teatro Sérgio Cardoso"
                    ]
                },
                "parques": {
                    "parques": 4,
                    "principais_parques": [
                        "Terminal Rodoviário Tietê",
                        "Terminal Rodoviário Barra Funda",
                        "Terminal Rodoviário Jabaquara"
                    ]
                },
                "rodoviarias": {
                    "rodoviarias": 4,
                    "principais_rodoviarias": [
                        "Terminal Rodoviário Tietê",
                        "Terminal Rodoviário Barra Funda",
                        "Terminal Rodoviário Jabaquara"
                    ]
                }
            },
            "educacao": {
                "principais_universidades": [
                    "Universidade de São Paulo (USP)",
                    "Universidade Estadual Paulista (UNESP)",
                    "Pontifícia Universidade Católica de São Paulo (PUC-SP)"
                ]
            },
            "saude": {
                "hospitais": 72,
                "principais_hospitais": [
                    "Hospital das Clínicas",
                    "Hospital Sírio-Libanês",
                    "Hospital Albert Einstein"
                ]
            },
            "clima": {
                "tipo": "Tropical",
                "temperatura_media_anual_celsius": 27.9,
                "precipitacao_media_anual_mm": 146
            },
            "seguranca": {
                "indicadores_criminalidade": {
                    "homicidios_por_100_mil_habitantes": 6.4,
                    "roubos_por_100_mil_habitantes": 286.3,
                    "furtos_por_100_mil_habitantes": 400,
                    "veiculos_roubados_por_100_mil_habitantes": 90.3
                },
                "policiamento": {
                    "delegacias": 80,
                    "postos_policiais": 120,
                    "efetivo_policial": 40000
                },
                "programas_de_seguranca": [
                    "Vizinhança Solidária",
                    "Polícia Comunitária",
                    "Patrulha do Bairro"
                ]
            },
            "trafego_veiculos": {
                "principais_corredores": [
                    "Marginal Tietê",
                    "Marginal Pinheiros",
                    "Avenida 23 de Maio",
                    "Avenida Paulista"
                ],
                "veiculos_registrados": 800000,
                "indicadores_congestionamento": {
                    "tempo_medio_deslocamento_minutos": 45,
                    "pico_congestionamento_km": 240
                }
            },
            "custos_medios": {
                "moradia": {
                    "aluguel_apartamento_centro_mensal": 3500,
                    "aluguel_apartamento_periferia_mensal": 2200,
                    "preco_m2_compra_centro": 12000,
                    "preco_m2_compra_periferia": 7500
                },
                "transporte": {
                    "bilhete_unico_metro_onibus": 4.5,
                    "passe_mensal_transporte_publico": 220,
                    "gasolina_litro": 6
                }
            }
        }
    }
}
```

### Get list cities of State 
- **Router:** [get] `/api/info/{sigla}`

- **Response:**
 ```json
{
    "data": [
        {
            "cep": "29102345",
            "cidade": "Vila Velha",
            "estado": "ES"
        },
        {
            "cep": "29102355",
            "cidade": "Vitória",
            "estado": "ES"
        },
        {
            "cep": "29102333",
            "cidade": "Serra",
            "estado": "ES"
        },
        {
            "cep": "29102333",
            "cidade": "Serra",
            "estado": "ES"
        }
    ],
    "quantidade_cidades": 4
}
```

