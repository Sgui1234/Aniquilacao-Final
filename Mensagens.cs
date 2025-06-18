using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Aniquilação_Final
{
    internal static class Mensagens
    {
        public static void Texto(string t, string cor)
        {
            if (cor == "red") { Console.ForegroundColor = ConsoleColor.Red; }
            if (cor == "blue") { Console.ForegroundColor = ConsoleColor.Blue; }
            Console.WriteLine(t);
            Console.ResetColor();
        }
        public static void Escrever(string mensagem, int delay)
        {
            foreach (char c in mensagem)
            {
                Console.Write(c);
                Console.Beep(880, delay / 4);
                Thread.Sleep(delay / 4);
            }
            Console.WriteLine();
        }
        public static int LerIntComValidacao(string mensagemErro, int min, int max)
        {
            int valor;
            while (true)
            {
                string input = Console.ReadLine();
                try
                {
                    valor = int.Parse(input);
                    if (valor < min || valor > max)
                    {
                        Console.WriteLine(mensagemErro);
                        continue;
                    }
                    break; // valor válido
                }
                catch (FormatException)
                {
                    Console.WriteLine("Entrada inválida! Digite um número inteiro.");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Número muito grande! Digite um número menor.");
                }
            }
            return valor;
        }

        public static void Vila(int dia)
        {
            Console.Clear();
            if (dia == 5)
            {
                Mensagens.Escrever("Vila de Lúnaris (Aldeia do Alvorecer)\n", 20);
                Mensagens.Escrever("Anciã Lyra - Você... você tem os olhos dele. Seu pai passou por aqui, ferido... mas determinado. Foi aqui que ele selou sua lâmina com o espírito da lua. Disse que a guerra não era só de força, mas de esperança.", 20);
                Mensagens.Escrever("Ferreiro Orun - Seu pai forjou comigo a arma que selaria o mal... Eu ainda lembro o som dos golpes, cada martelada era como um grito contra a destruição.", 20);
            }
            else if (dia == 10)
            {
                Mensagens.Escrever("Vila de Umbren (Aldeia da Névoa)\n", 20);
                Mensagens.Escrever("Caçadora Nyla - Vi seu pai enfrentando um espírito da floresta para conseguir o Cristal Sombrio. Ele usava cada sombra a seu favor, como se fosse parte delas…", 20);
                Mensagens.Escrever("Velho Corvus - Ele deixou um aviso... 'Se meu filho vier aqui, diga a ele que nem tudo o que é sombrio deve ser temido.'", 20);
            }
            else if (dia == 15)
            {
                Mensagens.Escrever("Vila de Solgryn (Aldeia das Montanhas)\n", 20);
                Mensagens.Escrever("Mestre Kaen - Seu pai treinou comigo durante sete luas. Aprendeu a dominar a fúria dentro dele, e a transformá-la em disciplina. Ele sabia que a verdadeira força vinha da mente.", 20);
                Mensagens.Escrever("Acolita Mira - Uma noite, ele chorou enquanto olhava as estrelas. Disse que lutava não por glória, mas pelo futuro... pelo seu futuro.", 20);
            }
            else if (dia == 20)
            {
                Mensagens.Escrever("Vila de Ardoria (Aldeia do Deserto)\n", 20);
                Mensagens.Escrever("Mercadora Zira - Ele trocou sua armadura por um amuleto antigo. Disse que não precisava de proteção, mas de destino.", 20);
                Mensagens.Escrever("Xamã Tarek - Ele enfrentou a Fera da Areia, sozinho. Quando venceu, deixou suas palavras nas dunas: ‘Para vencer a Aniquilação, é preciso sobreviver a si mesmo.’", 20);
            }
            else if (dia == 25) 
            {
                Mensagens.Escrever("Vila de Noxen (Aldeia do Crepúsculo)\n", 20);
                Mensagens.Escrever("Guardiã Vira - Este foi o último lugar que seu pai pisou antes do confronto. Ele me disse... ‘Se eu cair, que meu filho saiba que não falhei. Eu dei ao mundo 25 anos.’", 20);
                Mensagens.Escrever("Eco do Passado - Filho meu... se escutares esta mensagem, então eu não venci. Mas ainda há tempo. A Aniquilação não é inevitável — é o reflexo daquilo que desistimos de enfrentar.", 20);
            }
            Console.ReadKey();
        }
    }
}
