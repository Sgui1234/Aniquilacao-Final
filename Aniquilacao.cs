using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aniquilação_Final
{
    internal class Aniquilacao:Personagem
    {
        bool fase2 = false;
        
        public Aniquilacao()
        {
            nome = "Aniquilação";
            vidamax = 300;
            vida = vidamax;
            lvl = 100;
            ataques[0] = "Veneno";
            DanoAtaques[0] = 1;

            ataques[1] = "Sono";
            DanoAtaques[1] = 1;

            ataques[2] = "Confusão";
            DanoAtaques[2] = 1;

            ataques[3] = "Paralisia";
            DanoAtaques[3] = 1;
        }

        public bool GetFase2()
        {
            return fase2;
        }
        
        public void Transformar()
        {
            fase2 = true;
            Console.Clear();
            Console.WriteLine("\nA Aniquilação muda de forma! Seu corpo se dissolve em sombras vivas...");
            Console.WriteLine("O vazio consome tudo ao redor. A realidade parece se romper.");
            Console.ReadKey();
            vidamax += 100;
            vida += 150;
            for (int i = 0; i <= 3; i++)
            {
                DanoAtaques[i] += 1;
            }
        }



        public void SetVida(int v)
        {
            vida -= v;
        }

        public int Atacar()
        {
            Random ataque = new Random();
            int atk = ataque.Next(0, 4);
            return atk;
        }


       public void ExplosãoFinal()
        {
            Mensagens.Escrever("A Aniquilação fica enfurecida...", 20);
            Console.ReadKey();
            Console.Clear();

            Mensagens.Escrever("Ela irá dar seu último golpe", 20);
            Console.ReadKey();
            Console.Clear();

            Mensagens.Escrever("Sabendo que a luta foi perdida, Aniquilação começa a canalizar toda sua energia...", 20);
            Console.ReadKey();
            Console.Clear();

            Mensagens.Escrever("'Vou levar você e todo esse mundo junto comigo...' ela diz", 20);
            Console.ReadKey();
            Console.Clear();

            Mensagens.Escrever("Você pensa em apenas duas alternativas:" +
                "\n(1) Atacar a Aniquilação antes dela explodir" +
                "\n(2) Se sacrificar para selar ela eternamente", 20);
            int esc;
            esc = Mensagens.LerIntComValidacao("Escolha inválida! Digite um número válido para a escolha.", 1, 2);
            if (esc == 1)
            {
                Console.Clear();
                Mensagens.Escrever("Você corre para dar um último golpe, na esperança de salvar a todos...", 20);
                Console.ReadKey();
                Console.Clear();

                Mensagens.Escrever("O ato parece heróico e tem boas intenções...", 20);
                Console.ReadKey();
                Console.Clear();

                Mensagens.Escrever("Porém, não há tempo suficiente para isso...", 20);
                Console.ReadKey();
                Console.Clear();

                Mensagens.Escrever("Ao chegar para dar o último golpe, a Aniquilação explode", 20);
                Console.ReadKey();
                Console.Clear();

                Mensagens.Escrever("Você ve sua luz chegando, enquanto pensa em todos que confiaram em você, em todos que você prometeu salvar o mundo...", 20);
                Console.ReadKey();
                Console.Clear();

                Mensagens.Escrever("Você não diz nada, apenas uma lágrima escorre do seu rosto enquanto espera sua morte...", 20);
                Console.ReadKey();
                Console.Clear();

                Mensagens.Escrever("FIM - Final Ruim...", 20);
                Console.ReadKey();
                Console.Clear();
            }

            else
            {
                Console.Clear();
                Mensagens.Escrever("A Aniquilação ruge enquanto sua forma se desfaz em pura energia caótica.", 20);
                Console.ReadKey();
                Console.Clear();

                Mensagens.Escrever("Você se recorda das palavras do velho xamã...", 20);
                Console.ReadKey();
                Console.Clear();

                Mensagens.Escrever("\"Selar o vazio... exige não força, mas sacrifício.\"", 20);
                Console.ReadKey();
                Console.Clear();

                Mensagens.Escrever("Com o coração pesado, você levanta a mão, sentindo o mesmo poder que seu pai usou 25 anos atrás.", 20);
                Console.ReadKey();
                Console.Clear();

                Mensagens.Escrever("O selo começa a se formar, luz e sombra se entrelaçam em seu corpo.", 20);
                Console.ReadKey();
                Console.Clear();

                Mensagens.Escrever("A Aniquilação grita, não de dor... mas de compreensão.", 20);
                Console.ReadKey();
                Console.Clear();

                Mensagens.Escrever("Ela sabe que você vai fazer o que seu pai fez.", 20);
                Console.ReadKey();
                Console.Clear();

                Mensagens.Escrever("Seu corpo começa a se desfazer junto ao selo.", 20);
                Console.ReadKey();
                Console.Clear();

                Mensagens.Escrever("Você vê memórias... sua jornada, os vilarejos, os sorrisos, os medos... e seu pai.", 20);
                Console.ReadKey();
                Console.Clear();

                Mensagens.Escrever("No instante final, você sorri.", 20);
                Console.ReadKey();
                Console.Clear();

                Mensagens.Escrever("O mundo ficará seguro.", 20);
                Console.ReadKey();
                Console.Clear();

                Mensagens.Escrever("Uma explosão de luz preenche o céu.", 20);
                Console.ReadKey();
                Console.Clear();

                Mensagens.Escrever("E então, silêncio.", 20);
                Console.ReadKey();
                Console.Clear();

                Mensagens.Escrever("Meses depois...", 20);
                Console.ReadKey();
                Console.Clear();

                Mensagens.Escrever("Flores nascem onde antes havia cinzas.", 20);
                Console.ReadKey();
                Console.Clear();

                Mensagens.Escrever("As pessoas contam histórias de um herói...", 20);
                Console.ReadKey();
                Console.Clear();

                Mensagens.Escrever("Aquele que escolheu proteger, mesmo sabendo o preço.", 20);
                Console.ReadKey();
                Console.Clear();

                Mensagens.Escrever("E entre as ruínas silenciosas do Vilarejo do Silêncio...", 20);
                Console.ReadKey();
                Console.Clear();

                Mensagens.Escrever("...uma espada cravada no chão brilha sob a luz do pôr do sol.", 20);
                Console.ReadKey();
                Console.Clear();

                Mensagens.Escrever("FIM - Final Bom", 20);
                Console.ReadKey();
                Console.Clear();
            }
        }

    }
}
