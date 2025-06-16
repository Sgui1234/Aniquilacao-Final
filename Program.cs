using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aniquilação_Final
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int esc=0;
            while (esc!=3)
            {
                Mensagens.Texto("<== Aniquilação Final ==>\n","red");
                Console.WriteLine("(1) Jogar\n(2) Créditos\n(3) Sair");
                esc = int.Parse(Console.ReadLine());
                Console.Clear();
                if (esc == 1 )
                {
                    Jogo();
                }
                if(esc == 2 )
                {
                    Mensagens.Texto("<== Aniquilação Final ==>\n","red");
                    Console.WriteLine("Felipe Passeri Reis\nGuilherme Moura Gmeiner\nLucas Guidetti Gonzalez");
                    Console.ReadKey();
                }
                Console.Clear();
            }
        }
        public static void Jogo()
        {
            int escolha;
            string n;
            Mensagens.Texto("<== Aniquilação Final ==>\n", "red");
            Mensagens.Texto("Criação De Personagem", "blue");
            Console.WriteLine("\nNome do seu personagem:");
            n = Console.ReadLine();
            Console.Clear();

            Mensagens.Texto("<== Aniquilação Final ==>\n", "red");
            Mensagens.Texto("Criação De Personagem","blue");
            Console.WriteLine("\nSelecione a sua Raça:\n(1) Humano\n(2) Elfo\n(3) Anão");
            escolha = int.Parse(Console.ReadLine());
            Console.Clear();

            Mensagens.Texto("<== Aniquilação Final ==>\n", "red");
            Mensagens.Texto("Criação De Personagem", "blue");
            Console.WriteLine("\nSelecione a sua Classe:\n(1) Tanque\n(2) Mago\n(3) Ladino");
            Principal P = new Principal(escolha, int.Parse(Console.ReadLine()), n);
            Console.Clear();

            //-----------------------------------------------------------//

            int esc=0;
            while(true)
            {
                Mensagens.Texto("<== Aniquilação Final ==>\n", "red");
                Console.WriteLine("Dia {0}\nLevel {1}\n", P.getDia(), P.getLvl());
                Console.WriteLine("(1) Avançar");
                Console.WriteLine("(2) Estátisticas");
                esc = int.Parse(Console.ReadLine());
                Console.Clear();
                
                if(esc == 1)
                {
                    Inimigo I = new Inimigo(P.getLvl());
                    bool podeAtacar = true;
                    int escI; // Escolha do inimigo
                    while (I.getVida() > 0 && P.getVida() > 0)
                    {
                        int escB; // escolha de batakha
                        Mensagens.Texto("<== Aniquilação Final ==>\n", "red");
                        Console.WriteLine("Dia: {0}\nLevel: {1}", P.getDia(), P.getLvl());
                        Console.WriteLine("Vida: {0}/{1} Mana: {2}/{3} Estamina: {4}/{5}\n", P.getVida(),P.getVidaMax(), P.getMana(), P.getManaMax() ,P.getEstamina(), P.getEstaminaMax());
                        Mensagens.Texto($"Você encontrou um {I.getNome()}", "blue");
                        Console.WriteLine("Vida: {0}/{1} Level: {2}\n", I.getVida(), I.getVidaMax(), I.getLvl());
                        Console.WriteLine();
                        if (podeAtacar == true)
                        {
                            Console.WriteLine("--- Ataques ---");
                            Console.WriteLine($"(1) {P.getAtaques(0)}");
                            if (P.getAtaques(1) != null) { Console.WriteLine($"(2) {P.getAtaques(1)}"); }
                            if (P.getAtaques(2) != null) { Console.WriteLine($"(3) {P.getAtaques(2)}"); }
                            if (P.getAtaques(3) != null) { Console.WriteLine($"(4) {P.getAtaques(3)}"); }
                            escB = int.Parse(Console.ReadLine());
                            I.setVida(P.getDanoAtaques(escB - 1));
                            P.setMana(escB - 1);
                            P.setEstamina(escB - 1);
                            podeAtacar = false;
                            Console.WriteLine($"Você usou {P.getAtaques(escB - 1)}");
                        }
                        else
                        {
                            escI = I.Atacar();
                           
                            P.setVida(I.getDanoAtaques(escI));
                            Console.WriteLine($"{I.getNome()} usou {I.getAtaques(escI)}");
                            podeAtacar = true;
                            Console.ReadKey();
                        }
                        Console.Clear();
                        if (I.getVida() < 1)
                        {
                            P.setXp(I.getLvl() * 2);
                            Console.WriteLine($"Você ganhou {I.getLvl() * 2} XP");
                            while (P.getXp() >= 10 + (P.getLvl() * 2))
                            {
                                P.setXp((10 + (P.getLvl() * 2))*(-1));
                                P.setLvl();
                                Console.WriteLine("Level++");
                                P.setVidaMax(5);
                                P.setEstaminaMax(5);
                                P.setManaMax(5);
                                P.setStatus();
                            }
                            P.setDia();
                            Console.ReadKey();
                        }
                    }
                }
                if (esc == 2) 
                { 
                    Mensagens.Texto("<== Aniquilação Final ==>\n", "red");
                    Mensagens.Texto($"Estátisticas do(a) {P.getNome()}\n", "blue");
                    Console.WriteLine("Dia: {0}\nLevel: {1} (XP: {2}/{3})\nRaça: {4}\nClasse: {5}\nVida: {6}/{7}\nMana: {8}/{9}\nEstamina: {10}/{11}\n", P.getDia(), P.getLvl(),P.getXp(), 10 + (P.getLvl() * 2),P.getRaca(),P.getClasse() ,P.getVida(), P.getVidaMax(), P.getMana(), P.getManaMax(), P.getEstamina(), P.getEstaminaMax());
                    Console.ReadKey();
                }
                Console.Clear();
            }
        }
    }
}
