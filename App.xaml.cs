using MauiAppShowDoMilhao.Models;

namespace MauiAppShowDoMilhao
{
    public partial class App : Application
    {
        List<Pergunta> Perguntas_faceis = new()
{
    new Pergunta
    {
        Id = 1,
        Enunciado = "Em que estado brasileiro nasceu a apresentadora Xuxa?",
        Alternativas = new()
        {
            new Alternativa {Correta = false, Descricao = "RIO DE JANEIRO"},
            new Alternativa {Correta = true, Descricao = "RIO GRANDE DO SUL"},
            new Alternativa {Correta = false, Descricao = "SANTA CATARINA"},
            new Alternativa {Correta = false, Descricao = "GOIÁS"},
        }
    },
    new Pergunta
    {
        Id = 2,
        Enunciado = "Qual é o nome dado ao estado da água em forma de gelo?",
        Alternativas = new()
        {
            new Alternativa {Correta = false, Descricao = "LÍQUIDO"},
            new Alternativa {Correta = true, Descricao = "SÓLIDO"},
            new Alternativa {Correta = false, Descricao = "GASOSO"},
            new Alternativa {Correta = false, Descricao = "VAPOROSO"},
        }
    },
    new Pergunta
    {
        Id = 3,
        Enunciado = "Qual era o apelido da cantora Elis Regina?",
        Alternativas = new()
        {
            new Alternativa {Correta = false, Descricao = "GAUCHINHA"},
            new Alternativa {Correta = false, Descricao = "PAULISTINHA"},
            new Alternativa {Correta = true, Descricao = "PIMENTINHA"},
            new Alternativa {Correta = false, Descricao = "ANDORINHA"},
        }
    },
    new Pergunta
    {
        Id = 4,
        Enunciado = "Quem é a namorada do Mickey?",
        Alternativas = new()
        {
            new Alternativa {Correta = false, Descricao = "MARGARIDA"},
            new Alternativa {Correta = true, Descricao = "MINNIE"},
            new Alternativa {Correta = false, Descricao = "A PEQUENA SEREIA"},
            new Alternativa {Correta = false, Descricao = "OLÍVIA PALITO"},
        }
    },
    new Pergunta
    {
        Id = 5,
        Enunciado = "Qual é o personagem do folclore brasileiro que tem uma perna só?",
        Alternativas = new()
        {
            new Alternativa {Correta = false, Descricao = "CUCA"},
            new Alternativa {Correta = false, Descricao = "NEGRINHO DO PASTOREIO"},
            new Alternativa {Correta = false, Descricao = "BOITATÁ"},
            new Alternativa {Correta = true, Descricao = "SACI-PERERÊ"},
        }
    },
    new Pergunta
    {
        Id = 6,
        Enunciado = "Fidel Castro nasceu em que país?",
        Alternativas = new()
        {
            new Alternativa {Correta = false, Descricao = "JAMAICA"},
            new Alternativa {Correta = true, Descricao = "CUBA"},
            new Alternativa {Correta = false, Descricao = "EL SALVADOR"},
            new Alternativa {Correta = false, Descricao = "MÉXICO"},
        }
    },
    new Pergunta
    {
        Id = 7,
        Enunciado = "Quem proclamou a república no Brasil em 1889?",
        Alternativas = new()
        {
            new Alternativa {Correta = false, Descricao = "DUQUE DE CAXIAS"},
            new Alternativa {Correta = false, Descricao = "MARECHAL RONDON"},
            new Alternativa {Correta = false, Descricao = "DOM PEDRO II"},
            new Alternativa {Correta = true, Descricao = "MARECHAL DEODORO"},
        }
    },
    new Pergunta
    {
        Id = 8,
        Enunciado = "Quem é o patrono do exército brasileiro?",
        Alternativas = new()
        {
            new Alternativa {Correta = true, Descricao = "DUQUE DE CAXIAS"},
            new Alternativa {Correta = false, Descricao = "MARECHAL DEODORO"},
            new Alternativa {Correta = false, Descricao = "BARÃO DE MAUÁ"},
            new Alternativa {Correta = false, Descricao = "MARQUÊS DE POMBAL"},
        }
    },
    new Pergunta
    {
        Id = 9,
        Enunciado = "Quem era o apresentador que reprovava os calouros tocando uma buzina?",
        Alternativas = new()
        {
            new Alternativa {Correta = false, Descricao = "RAUL GIL"},
            new Alternativa {Correta = false, Descricao = "BOLINHA"},
            new Alternativa {Correta = false, Descricao = "FLÁVIO CAVALCANTI"},
            new Alternativa {Correta = true, Descricao = "CHACRINHA"},
        }
    },
    new Pergunta
    {
        Id = 10,
        Enunciado = "O que era Frankenstein, de Mary Shelley?",
        Alternativas = new()
        {
            new Alternativa {Correta = true, Descricao = "MONSTRO"},
            new Alternativa {Correta = false, Descricao = "GORILA"},
            new Alternativa {Correta = false, Descricao = "PRÍNCIPE"},
            new Alternativa {Correta = false, Descricao = "SAPO"},
        }
    },
    new Pergunta
    {
        Id = 11,
        Enunciado = "Qual é o signo do zodíaco de quem nasce no dia do ano-novo?",
        Alternativas = new()
        {
            new Alternativa {Correta = false, Descricao = "VIRGEM"},
            new Alternativa {Correta = false, Descricao = "AQUÁRIO"},
            new Alternativa {Correta = true, Descricao = "CAPRICÓRNIO"},
            new Alternativa {Correta = false, Descricao = "ÁRIES"},
        }
    },
    new Pergunta
    {
        Id = 12,
        Enunciado = "Quem fundou a fábrica de automóveis Ford?",
        Alternativas = new()
        {
            new Alternativa {Correta = false, Descricao = "HARRISON FORD"},
            new Alternativa {Correta = false, Descricao = "GERALD FORD"},
            new Alternativa {Correta = true, Descricao = "HENRY FORD"},
            new Alternativa {Correta = false, Descricao = "ANNA FORD"},
        }
    },
    new Pergunta
    {
        Id = 13,
        Enunciado = "Qual é a cor que se associa com os grupos ecológicos?",
        Alternativas = new()
        {
            new Alternativa {Correta = false, Descricao = "PRETA"},
            new Alternativa {Correta = false, Descricao = "VERMELHA"},
            new Alternativa {Correta = false, Descricao = "AZUL"},
            new Alternativa {Correta = true, Descricao = "VERDE"},
        }
    },
    new Pergunta
    {
        Id = 14,
        Enunciado = "A água ferve a quantos graus centígrados?",
        Alternativas = new()
        {
            new Alternativa {Correta = false, Descricao = "200"},
            new Alternativa {Correta = true, Descricao = "100"},
            new Alternativa {Correta = false, Descricao = "170"},
            new Alternativa {Correta = false, Descricao = "220"},
        }
    },
    new Pergunta
    {
        Id = 15,
        Enunciado = "Quando é comemorado o dia da independência do Brasil?",
        Alternativas = new()
        {
            new Alternativa {Correta = false, Descricao = "21 DE ABRIL"},
            new Alternativa {Correta = false, Descricao = "12 DE OUTUBRO"},
            new Alternativa {Correta = true, Descricao = "7 DE SETEMBRO"},
            new Alternativa {Correta = false, Descricao = "25 DE DEZEMBRO"},
        }
    },
    new Pergunta
    {
        Id = 16,
        Enunciado = "Qual lugar é também chamado de Santa Sé?",
        Alternativas = new()
        {
            new Alternativa {Correta = false, Descricao = "VENEZA"},
            new Alternativa {Correta = false, Descricao = "VITÓRIA"},
            new Alternativa {Correta = false, Descricao = "VANCOUVER"},
            new Alternativa {Correta = true, Descricao = "VATICANO"},
        }
    },
    new Pergunta
    {
        Id = 17,
        Enunciado = "Quem tem por lema a frase: “Sempre alerta”?",
        Alternativas = new()
        {
            new Alternativa {Correta = false, Descricao = "MÉDICOS"},
            new Alternativa {Correta = true, Descricao = "ESCOTEIROS"},
            new Alternativa {Correta = false, Descricao = "BOMBEIROS"},
            new Alternativa {Correta = false, Descricao = "POLICIAIS"},
        }
    },
    new Pergunta
    {
        Id = 18,
        Enunciado = "Qual é a nacionalidade de Che Guevara?",
        Alternativas = new()
        {
            new Alternativa {Correta = false, Descricao = "CUBANA"},
            new Alternativa {Correta = true, Descricao = "ARGENTINA"},
            new Alternativa {Correta = false, Descricao = "MEXICANA"},
            new Alternativa {Correta = false, Descricao = "VENEZUELANA"},
        }
    },
    new Pergunta
    {
        Id = 19,
        Enunciado = "Quem fundou a Microsoft?",
        Alternativas = new()
        {
            new Alternativa {Correta = false, Descricao = "STEVEN SPIELBERG"},
            new Alternativa {Correta = false, Descricao = "BILL CLINTON"},
            new Alternativa {Correta = true, Descricao = "BILL GATES"},
            new Alternativa {Correta = false, Descricao = "STEVEN JOBS"},
        }
    },
    new Pergunta
    {
        Id = 20,
        Enunciado = "Onde vivia o Sultão Harun Al Rachid?",
        Alternativas = new()
        {
            new Alternativa {Correta = false, Descricao = "DAMASCO"},
            new Alternativa {Correta = true, Descricao = "BAGDÁ"},
            new Alternativa {Correta = false, Descricao = "ISTAMBUL"},
            new Alternativa {Correta = false, Descricao = "JERUSALÉM"},

        }
    },
};

        static List<Pergunta> perguntas_medias = new()
        {
            new Pergunta
            {
                Id = 21,
                Enunciado = "A cidade de Pompéia, que foi soterrada por um vulcão fica em qual desses países?",
                Alternativas = new()
                {
                    new Alternativa{ Correta = false, Descricao = "JAPÃO" },
                    new Alternativa{ Correta = false, Descricao = "MÉXICO" },
                    new Alternativa{ Correta = true, Descricao = "ITÁLIA" },
                    new Alternativa{ Correta = false, Descricao = "ESTADOS UNIDOS" },
                }
            },
            new Pergunta
            {
                Id = 22,
                Enunciado = "Como eram chamados os pilotos suicidas da Segunda Guerra?",
                Alternativas = new()
                {
                    new Alternativa{ Correta = true, Descricao = "CAMICASES" },
                    new Alternativa{ Correta = false, Descricao = "SASHIMIS" },
                    new Alternativa{ Correta = false, Descricao = "HARAQUIRIS" },
                    new Alternativa{ Correta = false, Descricao = "SUMÔS" },

                }
            },
            new Pergunta
            {
                Id = 23,
                Enunciado = "Como é chamada a cantora que representa o papel principal em uma ópera?",
                Alternativas = new()
                {
                    new Alternativa{ Correta = false, Descricao = "PRIMEIRA DAMA" },
                    new Alternativa{ Correta = false, Descricao = "DONA-PRIMA" },
                    new Alternativa{ Correta = true, Descricao = "PRIMA-DONA" },
                    new Alternativa{ Correta = false, Descricao = "OBRA-PRIMA" },
                }
            },
            new Pergunta
            {
                Id = 24,
                Enunciado = "Peroba é uma espécie de?",
                Alternativas = new()
                {
                    new Alternativa{ Correta = false, Descricao = "INSETO" },
                    new Alternativa{ Correta = true, Descricao = "ÁRVORE" },
                    new Alternativa{ Correta = false, Descricao = "VERME" },
                    new Alternativa{ Correta = false, Descricao = "VERDURA" },
                }
            },
            new Pergunta
            {
                Id = 25,
                Enunciado = "O Coliseu é um monumento histórico de que cidade européia?",
                Alternativas = new()
                {
                    new Alternativa{ Correta = false, Descricao = "PARIS" },
                    new Alternativa{ Correta = false, Descricao = "COPENHAGUE" },
                    new Alternativa{ Correta = true, Descricao = "ROMA" },
                    new Alternativa{ Correta = false, Descricao = "LONDRES" },
                }
            },
            new Pergunta
            {
                Id = 26,
                Enunciado = "Quem foi eleito presidente da África do Sul em 1994?",
                Alternativas = new()
                {
                    new Alternativa{ Correta = false, Descricao = "NELSON PIQUET" },
                    new Alternativa{ Correta = true, Descricao = "NELSON MANDELA" },
                    new Alternativa{ Correta = false, Descricao = "NELSON NED" },
                    new Alternativa{ Correta = false, Descricao = "JOHN NELSON" },
                }
            },
            new Pergunta
            {
                Id = 27,
                Enunciado = "Quantos quilates tem o ouro puro?",
                Alternativas = new()
                {
                    new Alternativa{ Correta = false, Descricao = "18" },
                    new Alternativa{ Correta = false, Descricao = "20" },
                    new Alternativa{ Correta = true, Descricao = "24" },
                    new Alternativa{ Correta = false, Descricao = "30" },
                }
            },
            new Pergunta
            {
                Id = 28,
                Enunciado = "Segundo a crença popular, a mula-sem-cabeça é mulher de quem?",
                Alternativas = new()
                {
                    new Alternativa{ Correta = false, Descricao = "DO COROINHA" },
                    new Alternativa{ Correta = true, Descricao = "DO PADRE" },
                    new Alternativa{ Correta = false, Descricao = "DO SACRISTÃO" },
                    new Alternativa{ Correta = false, Descricao = "DO BISPO" },
                }
            },
            new Pergunta
            {
                Id = 29,
                Enunciado = "Que atriz protagonizou o filme “Titanic”?",
                Alternativas = new()
                {
                    new Alternativa{ Correta = false, Descricao = "CAMERON DIAZ" },
                    new Alternativa{ Correta = true, Descricao = "KATE WINSLET" },
                    new Alternativa{ Correta = false, Descricao = "BRIDGET FONDA" },
                    new Alternativa{ Correta = false, Descricao = "CATHERINE ZETTA JONES" },
                }
            },
            new Pergunta
            {
                Id = 30,
                Enunciado = "Como é chamada a doença que causa perda desigual da melanina?",
                Alternativas = new()
                {
                    new Alternativa{ Correta = false, Descricao = "ASTIGMATISMO" },
                    new Alternativa{ Correta = false, Descricao = "TENDINITE" },
                    new Alternativa{ Correta = true, Descricao = "VITILIGO" },
                    new Alternativa{ Correta = false, Descricao = "VITINGA" },
                }
            },
            new Pergunta
            {
                Id = 31,
                Enunciado = "No filme, quem era parceiro de crimes da Bonnie?",
                Alternativas = new()
                {
                    new Alternativa{ Correta = false, Descricao = "BILL" },
                    new Alternativa{ Correta = true, Descricao = "CLYDE" },
                    new Alternativa{ Correta = false, Descricao = "JAMES" },
                    new Alternativa{ Correta = false, Descricao = "BUTCH" },
                }
            },
            new Pergunta
            {
                Id = 32,
                Enunciado = "Quem é o parceiro de aventuras de Dom Quixote?",
                Alternativas = new()
                {
                    new Alternativa{ Correta = true, Descricao = "SANCHO PANÇA" },
                    new Alternativa{ Correta = false, Descricao = "GUILHERME TELL" },
                    new Alternativa{ Correta = false, Descricao = "SIGMUND FREUD" },
                    new Alternativa{ Correta = false, Descricao = "LANCELOT" },
                }
            },
            new Pergunta
            {
                Id = 33,
                Enunciado = "Nas histórias do Snoopy, qual é o nome do passarinho?",
                Alternativas = new()
                {
                    new Alternativa{ Correta = false, Descricao = "PIU-PIU" },
                    new Alternativa{ Correta = true, Descricao = "WOODSTOCK" },
                    new Alternativa{ Correta = false, Descricao = "CANARINHO" },
                    new Alternativa{ Correta = false, Descricao = "ROUXINOL" },
                }
            },
            new Pergunta
            {
                Id = 34,
                Enunciado = "Que planta era usada para fabricação de papel no antigo Egito?",
                Alternativas = new()
                {
                    new Alternativa{ Correta = true, Descricao = "PAPIRO" },
                    new Alternativa{ Correta = false, Descricao = "EUCALIPTO" },
                    new Alternativa{ Correta = false, Descricao = "OLIVEIRA" },
                    new Alternativa{ Correta = false, Descricao = "MILHO" },
                }
            },
            new Pergunta
            {
                Id = 35,
                Enunciado = "Quem pintou o quadro “La Gioconda”, conhecido como “Mona Lisa”?",
                Alternativas = new()
                {
                    new Alternativa{ Correta = true, Descricao = "LEONARDO DA VINCI" },
                    new Alternativa{ Correta = false, Descricao = "TICIANO" },
                    new Alternativa{ Correta = false, Descricao = "RAFAEL" },
                    new Alternativa{ Correta = false, Descricao = "MICHELÂNGELO" },
                }
            },
            new Pergunta
            {
                Id = 36,
                Enunciado = "Quando começou e terminou a Primeira Guerra Mundial?",
                Alternativas = new()
                {
                    new Alternativa{ Correta = true, Descricao = "1914-1919" },
                    new Alternativa{ Correta = false, Descricao = "1939-1945" },
                    new Alternativa{ Correta = false, Descricao = "1921-1932" },
                    new Alternativa{ Correta = false, Descricao = "1912-1915" },
                }
            },
            new Pergunta
            {
                Id = 37,
                Enunciado = "Quem introduziu o futebol no Brasil?",
                Alternativas = new()
                {
                    new Alternativa{ Correta = false, Descricao = "PELÉ" },
                    new Alternativa{ Correta = false, Descricao = "JOÃO HAVELANGE" },
                    new Alternativa{ Correta = true, Descricao = "CHARLES MILLER" },
                    new Alternativa{ Correta = false, Descricao = "PAULO MACHADO" },
                }
            },
            new Pergunta
            {
                Id = 38,
                Enunciado = "Que colônia britânica foi devolvida à China em 1997?",
                Alternativas = new()
                {
                    new Alternativa{ Correta = false, Descricao = "PEQUIM" },
                    new Alternativa{ Correta = false, Descricao = "HANÓI" },
                    new Alternativa{ Correta = false, Descricao = "HIROSHIMA" },
                    new Alternativa{ Correta = true, Descricao = "HONG KONG" },
                }
            },
            new Pergunta
            {
                Id = 39,
                Enunciado = "Como é chamado o objeto falsificado vendido como original?",
                Alternativas = new()
                {
                    new Alternativa{ Correta = false, Descricao = "PIRARUCU" },
                    new Alternativa{ Correta = false, Descricao = "PERNETA" },
                    new Alternativa{ Correta = true, Descricao = "PIRATA" },
                    new Alternativa{ Correta = false, Descricao = "PAPAGAIO" },
                }
            },
            new Pergunta
            {
                Id = 40,
                Enunciado = "Qual é o nome original do filme “O médico e o monstro”?",
                Alternativas = new()
                {
                    new Alternativa{ Correta = false, Descricao = "MASTERS E JOHNSON" },
                    new Alternativa{ Correta = true, Descricao = "DR. JEKYLL E MR. HYDE" },
                    new Alternativa{ Correta = false, Descricao = "BONNIE E CLYDE" },
                    new Alternativa{ Correta = false, Descricao = "D. QUIXOTE E SANCHO PANÇA" },
                }
            },
        };

        static List<Pergunta> perguntas_dificeis = new()
        {
            new Pergunta
            {
                Id = 41,
                Enunciado = "Em qual espécie o macho choca os ovos e a fêmea procura alimento?",
                Alternativas = new()
                {
                    new Alternativa{ Correta = false, Descricao = "ANDORINHA" },
                    new Alternativa{ Correta = false, Descricao = "PATO SELVAGEM" },
                    new Alternativa{ Correta = true, Descricao = "PINGÜIM" },
                    new Alternativa{ Correta = false, Descricao = "MARRECO" },

                }
            },
            new Pergunta
            {
                Id = 42,
                Enunciado = "Em qual país está localizado o “Muro das lamentações”?",
                Alternativas = new()
                {
                    new Alternativa{ Correta = false, Descricao = "ALEMANHA" },
                    new Alternativa{ Correta = false, Descricao = "BRASIL" },
                    new Alternativa{ Correta = false, Descricao = "VENEZUELA" },
                    new Alternativa{ Correta = true, Descricao = "ISRAEL" },
                }
            },
            new Pergunta
            {
                Id = 43,
                Enunciado = "Onde nasceu Van Gogh, o grande pintor impressionista?",
                Alternativas = new()
                {
                    new Alternativa{ Correta = false, Descricao = "POLÔNIA" },
                    new Alternativa{ Correta = false, Descricao = "FRANÇA" },
                    new Alternativa{ Correta = false, Descricao = "ITÁLIA" },
                    new Alternativa{ Correta = true, Descricao = "HOLANDA" },
                }
            },
            new Pergunta
            {
                Id = 44,
                Enunciado = "O que significa literalmente Perestroika?",
                Alternativas = new()
                {
                    new Alternativa{ Correta = false, Descricao = "CONVERSÃO" },
                    new Alternativa{ Correta = false, Descricao = "INVOLUÇÃO" },
                    new Alternativa{ Correta = true, Descricao = "REESTRUTURAÇÃO" },
                    new Alternativa{ Correta = false, Descricao = "REGRESSÃO" },
                }
            },
            new Pergunta
            {
                Id = 45,
                Enunciado = "Qual oceano tem o maior volume de água?",
                Alternativas = new()
                {
                    new Alternativa{ Correta = false, Descricao = "ATLÂNTICO" },
                    new Alternativa{ Correta = true, Descricao = "PACÍFICO" },
                    new Alternativa{ Correta = false, Descricao = "ÍNDICO" },
                    new Alternativa{ Correta = false, Descricao = "ÁRTICO" },
                }
            },
            new Pergunta
            {
                Id = 46,
                Enunciado = "Qual foi o último presidente militar do Brasil?",
                Alternativas = new()
                {
                    new Alternativa{ Correta = false, Descricao = "FERNANDO COLLOR" },
                    new Alternativa{ Correta = true, Descricao = "JOÃO FIGUEIREDO" },
                    new Alternativa{ Correta = false, Descricao = "TANCREDO NEVES" },
                    new Alternativa{ Correta = false, Descricao = "JOÃO GOULART" },
                }
            },
            new Pergunta
            {
                Id = 47,
                Enunciado = "Quem escreveu “Ulisses” em 1922?",
                Alternativas = new()
                {
                    new Alternativa{ Correta = false, Descricao = "ERNEST HEMINGWAY" },
                    new Alternativa{ Correta = false, Descricao = "MARCEL PROUST" },
                    new Alternativa{ Correta = false, Descricao = "T.S. ELLIOT" },
                    new Alternativa{ Correta = true, Descricao = "JAMES JOYCE" },
                }
            },
            new Pergunta
            {
                Id = 48,
                Enunciado = "Como é chamada a bola de gelo e poeira que orbita em torno do sol?",
                Alternativas = new()
                {
                    new Alternativa{ Correta = true, Descricao = "COMETA" },
                    new Alternativa{ Correta = false, Descricao = "METEORITO" },
                    new Alternativa{ Correta = false, Descricao = "CAMADA DE OZÔNIO" },
                    new Alternativa{ Correta = false, Descricao = "ESTRELA D’ALVA" },
                }
            },
            new Pergunta
            {
                Id = 49,
                Enunciado = "A eletrônica é parte de qual ciência?",
                Alternativas = new()
                {
                    new Alternativa{ Correta = true, Descricao = "FÍSICA" },
                    new Alternativa{ Correta = false, Descricao = "BIOLOGIA" },
                    new Alternativa{ Correta = false, Descricao = "QUÍMICA" },
                    new Alternativa{ Correta = false, Descricao = "BOTÂNICA" },
                }

            },
            new Pergunta
            {
                Id = 50,
                Enunciado = "Que figura mitológica é conhecida por sua força extraordinária?",
                Alternativas = new()
                {
                    new Alternativa{ Correta = false, Descricao = "ÁTILA" },
                    new Alternativa{ Correta = false, Descricao = "MINOTAURO" },
                    new Alternativa{ Correta = false, Descricao = "PERSEU" },
                    new Alternativa{ Correta = true, Descricao = "HÉRCULES" },
                }
            },
            new Pergunta
            {
                Id = 51,
                Enunciado = "A que país pertence a ilha de Terra Nova?",
                Alternativas = new()
                {
                    new Alternativa{ Correta = false, Descricao = "ESTADOS UNIDOS" },
                    new Alternativa{ Correta = false, Descricao = "DINAMARCA" },
                    new Alternativa{ Correta = true, Descricao = "CANADÁ" },
                    new Alternativa{ Correta = false, Descricao = "FRANÇA" },
                }
            },
            new Pergunta
            {
                Id = 52,
                Enunciado = "Na criação do Estado do Tocantins, que estado teve o território reduzido?",
                Alternativas = new()
                {
                    new Alternativa{ Correta = true, Descricao = "GOIÁS" },
                    new Alternativa{ Correta = false, Descricao = "MATO GROSSO" },
                    new Alternativa{ Correta = false, Descricao = "PARÁ" },
                    new Alternativa{ Correta = false, Descricao = "MARANHÃO" },
                }
            },
            new Pergunta
            {
                Id = 53,
                Enunciado = "“Arábica” e “robusta” são tipos de quê?",
                Alternativas = new()
                {
                    new Alternativa{ Correta = false, Descricao = "UVA" },
                    new Alternativa{ Correta = true, Descricao = "CAFÉ" },
                    new Alternativa{ Correta = false, Descricao = "MELÃO" },
                    new Alternativa{ Correta = false, Descricao = "LARANJA" },
                }
            },
            new Pergunta
            {
                Id = 54,
                Enunciado = "Em que ano Ayrton Senna venceu o primeiro campeonato de Fórmula 1?",
                Alternativas = new()
                {
                    new Alternativa{ Correta = false, Descricao = "1987" },
                    new Alternativa{ Correta = false, Descricao = "1990" },
                    new Alternativa{ Correta = false, Descricao = "1985" },
                    new Alternativa{ Correta = true, Descricao = "1988" },
                }
            },
            new Pergunta
            {
                Id = 55,
                Enunciado = "Que símbolo está desenhado no centro da bandeira Argentina?",
                Alternativas = new()
                {
                    new Alternativa{ Correta = true, Descricao = "SOL" },
                    new Alternativa{ Correta = false, Descricao = "LUA" },
                    new Alternativa{ Correta = false, Descricao = "ESTRELA" },
                    new Alternativa{ Correta = false, Descricao = "FOICE E MARTELO" },
                }
            },
            new Pergunta
            {
                Id = 56,
                Enunciado = "De quem é a frase ”Penso, logo existo”?",
                Alternativas = new()
                {
                    new Alternativa{ Correta = false, Descricao = "PLATÃO" },
                    new Alternativa{ Correta = false, Descricao = "JÚLIO VERNE" },
                    new Alternativa{ Correta = false, Descricao = "ARISTÓTELES" },
                    new Alternativa{ Correta = true, Descricao = "RENÉ DESCARTES" },
                }
            },
            new Pergunta
            {
                Id = 57,
                Enunciado = "Quem construiu o primeiro telescópio astronômico completo?",
                Alternativas = new()
                {
                    new Alternativa{ Correta = false, Descricao = "CYRUS MCCORMICK" },
                    new Alternativa{ Correta = false, Descricao = "THOMAS EDISON" },
                    new Alternativa{ Correta = false, Descricao = "MICHELANGELO" },
                    new Alternativa{ Correta = true, Descricao = "GALILEU GALILEI\r\n" },
                }
            },
            new Pergunta
            {
                Id = 58,
                Enunciado = "A quem se atribui a frase “Eu sou o Estado”?",
                Alternativas = new()
                {
                    new Alternativa{ Correta = true, Descricao = "LUIZ XIV" },
                    new Alternativa{ Correta = false, Descricao = "LUIZ XV" },
                    new Alternativa{ Correta = false, Descricao = "LUIZ XVI" },
                    new Alternativa{ Correta = false, Descricao = "NAPOLEÃO BONAPARTE" },
                }
            },
            new Pergunta
            {
                Id = 59,
                Enunciado = "Quem foi aluno de Platão e tutor de Alexandre, o Grande?",
                Alternativas = new()
                {
                    new Alternativa{ Correta = false, Descricao = "PITÁGORAS" },
                    new Alternativa{ Correta = false, Descricao = "DIDEROT" },
                    new Alternativa{ Correta = true, Descricao = "ARISTÓTELES" },
                    new Alternativa{ Correta = false, Descricao = "GALILEU GALILEI" },
                }
            },
            new Pergunta
            {
                Id = 60,
                Enunciado = "Em que ano foi inaugurada a estátua do Cristo Redentor no Rio de Janeiro?",
                Alternativas = new()
                {
                    new Alternativa{ Correta = false, Descricao = "1921" },
                    new Alternativa{ Correta = false, Descricao = "1931" },
                    new Alternativa{ Correta = false, Descricao = "1941" },
                    new Alternativa{ Correta = false, Descricao = "1951" },
                }
            },
        };

        static List<Pergunta> perguntas_finais = new()
        {
            new Pergunta
            {
                Id = 61,
                Enunciado = "Como se chama o explorador de grutas e cavernas?",
                Alternativas = new()
                {
                    new Alternativa{ Correta = true, Descricao = "ESPELEÓLOGO" },
                    new Alternativa{ Correta = false, Descricao = "AGROSTÓLOGO" },
                    new Alternativa{ Correta = false, Descricao = "PSICÓLOGO" },
                    new Alternativa{ Correta = false, Descricao = "CAMPANÓLOGO" },
                }
            },
            new Pergunta
            {
                Id = 62,
                Enunciado = "O que procurava Juan Ponce de Leon quando descobriu a Flórida?",
                Alternativas = new()
                {
                    new Alternativa{ Correta = false, Descricao = "A CIDADE PERDIDA DE OURO" },
                    new Alternativa{ Correta = true, Descricao = "A FONTE DA JUVENTUDE" },
                    new Alternativa{ Correta = false, Descricao = "UNICÓRNIOS" },
                    new Alternativa{ Correta = false, Descricao = "SEU GATO" },
                }
            },
            new Pergunta
            {
                Id = 63,
                Enunciado = "Nova Caledônia faz parte da:",
                Alternativas = new()
                {
                    new Alternativa{ Correta = false, Descricao = "MICRONÉSIA" },
                    new Alternativa{ Correta = true, Descricao = "MELANÉSIA" },
                    new Alternativa{ Correta = false, Descricao = "POLINÉSIA" },
                    new Alternativa{ Correta = false, Descricao = "INDONÉSIA" },
                }
            },
        };

        static List<Pergunta> perguntas_sorteadas = new();



        /**
         * Sorteia uma pergunta fácil entre 1 e 20
         */
        public static Pergunta getRandomPerguntaFacil()
        {
            Random r = new Random();

            Pergunta pergunta_sorteada;

            while (true)
            {
                int sorteado = r.Next(0, 19);

                pergunta_sorteada = perguntas_faceis[sorteado];

                if (!perguntas_sorteadas.Contains(pergunta_sorteada))
                {
                    perguntas_sorteadas.Add(pergunta_sorteada);
                    break;
                }
            }

            return pergunta_sorteada;
        }

        /**
         * Sorteia uma pergunta média entre 21 e 41
         */
        public static Pergunta getRandomPerguntaMedia()
        {
            Random r = new Random();

            Pergunta pergunta_sorteada;

            while (true)
            {
                int sorteado = r.Next(1, 20);

                pergunta_sorteada = perguntas_medias[sorteado];

                if (!perguntas_sorteadas.Contains(pergunta_sorteada))
                {
                    perguntas_sorteadas.Add(pergunta_sorteada);
                    break;
                }
            }

            return pergunta_sorteada;
        }

        /**
         * Sorteia uma pergunta dificil entre 1 e 20
         */
        public static Pergunta getRandomPerguntaDificil()
        {
            Random r = new Random();

            Pergunta pergunta_sorteada;

            while (true)
            {
                int sorteado = r.Next(1, 20);

                pergunta_sorteada = perguntas_dificeis[sorteado];

                if (!perguntas_sorteadas.Contains(pergunta_sorteada))
                {
                    perguntas_sorteadas.Add(pergunta_sorteada);
                    break;
                }
            }

            return pergunta_sorteada;
        }

        /**
         * Sorteia uma pergunta dificil entre 1 e 20
         */
        public static Pergunta getRandomPerguntaFinal()
        {
            Random r = new Random();

            Pergunta pergunta_sorteada;

            while (true)
            {
                int sorteado = r.Next(61, 63);

                pergunta_sorteada = perguntas_finais[sorteado];

                if (!perguntas_sorteadas.Contains(pergunta_sorteada))
                {
                    perguntas_sorteadas.Add(pergunta_sorteada);
                    break;
                }
            }

            return pergunta_sorteada;
        }

        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }
    }
}


