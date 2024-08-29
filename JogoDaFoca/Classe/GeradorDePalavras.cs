using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDaFoca.Classe
{
    public static class GeradorDePalavras
    {
        private static readonly List<string> PalavrasPortugues = new List<string>
        {
            "abacaxi", "banana", "computador", "elefante", "formiga", "guitarra", "hipopotamo", "jacare", "kiwi", "laranja", "macaco", "notebook",
            "ornitorrinco", "papagaio", "quimica", "relogio", "sapato", "tartaruga", "uva", "vassoura", "xadrez", "zebra", "abacate", "amendoim",
            "avelã", "bergamota", "cachorro", "camisa", "camiseta", "caneta", "canivete", "caderno", "carro", "celular", "cenoura", "chave",
            "chuveiro", "cobertor", "colher", "colchão", "comida", "computador", "controle", "corredor", "cortina", "criança", "despertador",
            "dinheiro", "elefante", "escola", "escova", "escudo", "espelho", "esponja", "estojo", "família", "fantasma", "ferramenta", "fio",
            "floresta", "fogão", "formiga", "frango", "fritura", "fruta", "garrafa", "gato", "geladeira", "girafa", "giz", "gramado", "gravata",
            "guarda-chuva", "helicóptero", "hiena", "história", "hospital", "igreja", "internet", "irmão", "jacaré", "janela", "jarra", "joaninha",
            "joelho", "jornal", "jornalista", "júpiter", "lacoste", "lapiseira", "livro", "lixeira", "limão", "lousa", "macarrão", "maçã",
            "mamão", "manteiga", "máquina", "maracujá", "martelo", "medicina", "melancia", "melão", "microfone", "micróbio", "minhoca", "mochila",
            "molho", "morango", "moto", "navio", "neve", "nuvem", "ônibus", "óleo", "olho", "orelha", "óculos", "panela", "pão", "papel", "pasta",
            "pato", "pedra", "peixe", "pêra", "peteca", "piano", "picareta", "pincel", "pipoca", "pirulito", "pizza", "planta", "plástico", "pneu",
            "pó", "porta", "porco", "prato", "prego", "professor", "quadro", "queijo", "raquete", "recreio", "remédio", "rio", "roda", "rosa",
            "roupa", "ruga", "sabão", "sabonete", "sacola", "sanduíche", "sapo", "serra", "sinal", "sobremesa", "sol", "tábua", "talher", "tartaruga",
            "teclado", "telefone", "televisão", "tigre", "tijolo", "tinta", "toalha", "trator", "travesseiro", "tricô", "trombone", "uva", "vaca",
            "vassoura", "vela", "ventilador", "vidro", "violão", "violino", "vôlei", "vulcão", "xícara", "xampu", "xadrez", "xerox", "xilofone",
            "zangão", "zero", "ziguezague", "zoológico", "abóbora", "acordeão", "aeroporto", "agulha", "álibi", "almofada", "almoço", "amigo",
            "anel", "antílope", "arame", "arara", "aranha", "argola", "artista", "asa", "aspirador", "atleta", "aula", "açúcar", "baile", "bala",
            "balança", "baleia", "balé", "banana", "bandeira", "barco", "barriga", "batata", "batedeira", "batida", "beija-flor", "bexiga", "bicho",
            "bilhete", "biscoito", "bicicleta", "blusa", "bola", "boneca", "borboleta", "bosque", "botão", "bovino", "brinquedo", "broca", "bússola",
            "cabide", "caixa", "calça", "calendário", "camisa", "camiseta", "camomila", "campainha", "campo", "caneta", "canoa", "capivara",
            "cápsula", "caranguejo", "carneiro", "carroça", "carvão", "casa", "casaco", "casca", "caverna", "cebola", "cedro", "cenoura", "cesta",
            "charuto", "chiclete", "chinelo", "chocolate", "chuva", "cinema", "cinto", "cobertura", "cobertor", "cobrança", "cobra", "coca-cola",
            "coelho", "colchão", "coleção", "colete", "colher", "colina", "colméia", "colorido", "comédia", "comedouro", "cometa", "computador",
            "concha", "condutor", "cone", "confete", "conforto", "conjunto", "controle", "copiadora", "corda", "coruja", "costela", "coxa", "craque",
            "creme", "criança", "crista", "crocodilo", "cruz", "crédito", "cubeta", "cubo", "cueca", "cupim", "curativo", "curva", "cutelo",
            "cálice", "dado", "dama", "dança", "dedal", "dedo", "dente", "dentista", "deputado", "dicionário", "dinossauro", "disco", "divisor",
            "doce", "doença", "domador", "domínio", "dragão", "dromedário", "ducha", "duende", "duplicado", "durex", "dúvida", "dólar", "edifício",
            "elefante", "embalagem", "emoção", "empada", "empada", "enfermeira", "engenheiro", "enguia", "enigma", "enlace", "enteado", "escalador",
            "escalpelo", "escama", "escavadeira", "escola", "escorregador", "escova", "escrita", "esfinge", "espada", "espaguete", "espelho",
            "espetáculo", "esponja", "esqueleto", "esquina", "essência", "estado", "estrela", "estrelinha", "estrondo", "estrofe", "etiqueta",
            "eucalipto", "evangélico", "evolução", "exame", "exército", "exílio", "expedição", "explosivo", "expressão", "extrato", "extravagante",
            "extraterrestre", "faca", "fachada", "falcão", "família", "farda", "fato", "fauna", "favorito", "fazenda", "fazendeiro", "felicidade",
            "felino", "feno", "ferradura", "festa", "festival", "figo", "fila", "filtro", "fim", "fim-de-semana", "fita", "fivela", "flanela",
            "flamingo", "flamenco", "flan", "flanela", "flauta", "flauta-doce", "flautim", "flautim", "focinho", "fofoca", "foguete", "fogueteiro",
            "foice", "folha", "folhagem", "folha-de-figueira", "folheto", "folhetim", "folhinha", "folhos", "fonte", "fossa", "fossa-nasal",
            "fosso", "fotografia", "fralda", "francês", "frasco", "frente", "frevo", "frigideira", "frigobar", "fritadeira", "fritura", "fritar",
            "fruteira", "fruto", "funil", "furadeira", "furgão", "futebol", "futuro", "fuxico", "fuzileiro", "fóssil", "gabinete", "galáxia",
            "galinha", "galinheiro", "galo", "galocha", "galpão", "galope", "galáxia", "galheteiro", "gama", "gamer", "gancho", "gangorra",
            "garagem", "garanhão", "garantido", "garçom", "gargalo", "garganta", "garimpo", "garoupa", "garrafa", "garrafeira", "garupa", "garça",
            "gato", "gauchão", "gaveta", "gazeta", "geada", "geladeira", "gelado", "geladeira", "gelado", "geladeira", "gelo", "gelatina"
        };
        public static string GerarPalavraAleatoria()
        {
            Random random = new Random();
            int indice = random.Next(PalavrasPortugues.Count);
            return PalavrasPortugues[indice];
        }
    }
}
