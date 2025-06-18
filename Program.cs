using System;

namespace Aniquilação_Final
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int esc = 0;
            while (esc != 3)
            {
                Mensagens.Texto("<== Aniquilação Final ==>\n", "red");
                Console.WriteLine("(1) Jogar\n(2) Créditos\n(3) Sair");
                esc = Mensagens.LerIntComValidacao("Escolha inválida! Digite um número válido para ataque.", 1, 4);
                Console.Clear();
                if (esc == 1)
                {
                    Jogo();
                }
                if (esc == 2)
                {
                    Mensagens.Texto("<== Aniquilação Final ==>\n", "red");
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
            Mensagens.Texto("Criação De Personagem", "blue");
            Console.WriteLine("\nSelecione a sua Raça:\n(1) Humano\n(2) Elfo\n(3) Anão");
            escolha = Mensagens.LerIntComValidacao("Escolha inválida! Digite um número válido para ataque.", 1, 4);
            Console.Clear();

            Mensagens.Texto("<== Aniquilação Final ==>\n", "red");
            Mensagens.Texto("Criação De Personagem", "blue");
            Console.WriteLine("\nSelecione a sua Classe:\n(1) Tanque\n(2) Mago\n(3) Ladino");
            Principal P = new Principal(escolha, int.Parse(Console.ReadLine()), n);
            Console.Clear();

            //-----------------------------------------------------------//

            int esc = 0;
            int esc1 = 0;
            bool Final = false;
            while (P.getVida() > 0 && Final == false)
            {
                Mensagens.Texto("<== Aniquilação Final ==>\n", "red");
                Console.WriteLine("Dia {0}\nLevel {1}\n", P.getDia(), P.getLvl());
                if (P.getDia() % 5 == 0 && esc1 != 1) // Vilas
                {
                    Console.WriteLine($"Você chegou ao seu {P.getDia() / 5}° vilarejo, o que deseja fazer?");
                    Console.WriteLine("(1) Continuar");
                    Console.WriteLine("(2) Melhorar Estátisticas");
                    esc1 = Mensagens.LerIntComValidacao("Escolha inválida! Digite um número válido para ataque.", 1, 2);
                    Console.Clear();
                    while (esc1 == 2)
                    {
                        Console.Clear();
                        Mensagens.Texto("<== Aniquilação Final ==>\n", "red");
                        Console.WriteLine("Dia {0}\nLevel {1}\n", P.getDia(), P.getLvl());
                        Console.WriteLine("--- Melhorar Estátisticas ---");
                        Console.WriteLine($"Saldo: {P.getMoedas()} moedas");
                        Console.WriteLine("(1) Vida (5 moedas)");
                        Console.WriteLine("(2) Mana (3 moedas)");
                        Console.WriteLine("(3) Estamina (3 moedas)");
                        Console.WriteLine();
                        Console.WriteLine("--- Poções ---");
                        Console.WriteLine("(4) Poção de Cura (5 moedas)");
                        Console.WriteLine("(5) Poção de Mana (5 moedas)");
                        Console.WriteLine("(6) Poção de Estamina (5 moedas)");
                        Console.WriteLine("(7) Continuar");
                        int esc2 = Mensagens.LerIntComValidacao("Escolha inválida! Digite um número válido para ataque.", 1, 7);
                        if (esc2 == 1 && P.getMoedas() >= 5)
                        {
                            Console.Clear();
                            Mensagens.Texto("<== Aniquilação Final ==>\n", "red");
                            Console.WriteLine("Dia {0}\nLevel {1}\n", P.getDia(), P.getLvl());
                            Console.WriteLine("Você encontrou o curandeiro da vila \nDeseja melhorar sua vida?");
                            Console.WriteLine("(1) Sim (5 moedas)");
                            Console.WriteLine("(2) Não");
                            int esc3 = Mensagens.LerIntComValidacao("Escolha inválida! Digite um número válido para ataque.", 1, 2);
                            if (esc3 == 1)
                            {
                                P.setMoedas(-5);
                                P.setVidaMax(5);
                                P.setStatus("Vida");
                                Console.Clear();
                                Mensagens.Texto("<== Aniquilação Final ==>\n", "red");
                                Console.WriteLine("Dia {0}\nLevel {1}\n", P.getDia(), P.getLvl());
                                Console.WriteLine("O curandeiro te curou e aumentou a sua vida maxima \nVida melhorada!");
                                Console.ReadKey();
                            }
                        }
                        else if (esc2 == 2 && P.getMoedas() >= 3)
                        {
                            Console.Clear();
                            Mensagens.Texto("<== Aniquilação Final ==>\n", "red");
                            Console.WriteLine("Dia {0}\nLevel {1}\n", P.getDia(), P.getLvl());
                            Console.WriteLine("Você encontrou o mago da vila \nDeseja melhorar sua Mana?");
                            Console.WriteLine("(1) Sim (3 moedas)");
                            Console.WriteLine("(2) Não");
                            int esc3 = Mensagens.LerIntComValidacao("Escolha inválida! Digite um número válido para ataque.", 1, 2);
                            if (esc3 == 1)
                            {
                                P.setMoedas(-3);
                                P.setManaMax(5);
                                P.setStatus("Mana");
                                Console.Clear();
                                Mensagens.Texto("<== Aniquilação Final ==>\n", "red");
                                Console.WriteLine("Dia {0}\nLevel {1}\n", P.getDia(), P.getLvl());
                                Console.WriteLine("O mago restaurou sua mana e aumentou a sua Mana maxima \nMana melhorada!");
                                Console.ReadKey();
                            }
                        }
                        else if (esc2 == 3 && P.getMoedas() >= 3)
                        {
                            Console.Clear();
                            Mensagens.Texto("<== Aniquilação Final ==>\n", "red");
                            Console.WriteLine("Dia {0}\nLevel {1}\n", P.getDia(), P.getLvl());
                            Console.WriteLine("Você encontrou um corredor na vila \nDeseja melhorar sua Estamina?");
                            Console.WriteLine("(1) Sim (3 moedas)");
                            Console.WriteLine("(2) Não");
                            int esc3 = Mensagens.LerIntComValidacao("Escolha inválida! Digite um número válido para ataque.", 1, 2);
                            if (esc3 == 1)
                            {
                                P.setMoedas(-3);
                                P.setEstaminaMax(5);
                                P.setStatus("Estamina");
                                Console.Clear();
                                Mensagens.Texto("<== Aniquilação Final ==>\n", "red");
                                Console.WriteLine("Dia {0}\nLevel {1}\n", P.getDia(), P.getLvl());
                                Console.WriteLine("O corredor te ajudou e aumentou a sua Estamina maxima \nEstamina melhorada!");
                                Console.ReadKey();
                            }
                        }
                        else if (esc2 == 4 && P.getMoedas() >= 5)
                        {
                            Console.Clear();
                            Mensagens.Texto("<== Aniquilação Final ==>\n", "red");
                            Console.WriteLine("Dia {0}\nLevel {1}\n", P.getDia(), P.getLvl());
                            Console.WriteLine("Você encontrou um vendedor na vila \nDeseja comprar Poção de cura?");
                            Console.WriteLine("(1) Sim (5 moedas)");
                            Console.WriteLine("(2) Não");
                            int esc3 = Mensagens.LerIntComValidacao("Escolha inválida! Digite um número válido para ataque.", 1, 2);
                            if (esc3 == 1)
                            {
                                P.setMoedas(-5);
                                P.setPC(1);
                                Console.Clear();
                                Mensagens.Texto("<== Aniquilação Final ==>\n", "red");
                                Console.WriteLine("Dia {0}\nLevel {1}\n", P.getDia(), P.getLvl());
                                Console.WriteLine("O vendedor te deseja uma ótima viagem!\nPoção de cura adiquirida!");
                                Console.ReadKey();
                            }
                        }
                        else if (esc2 == 5 && P.getMoedas() >= 5)
                        {
                            Console.Clear();
                            Mensagens.Texto("<== Aniquilação Final ==>\n", "red");
                            Console.WriteLine("Dia {0}\nLevel {1}\n", P.getDia(), P.getLvl());
                            Console.WriteLine("Você encontrou um vendedor na vila \nDeseja comprar Poção de mana?");
                            Console.WriteLine("(1) Sim (5 moedas)");
                            Console.WriteLine("(2) Não");
                            int esc3 = Mensagens.LerIntComValidacao("Escolha inválida! Digite um número válido para ataque.", 1, 2);
                            if (esc3 == 1)
                            {
                                P.setMoedas(-5);
                                P.setPM(1);
                                Console.Clear();
                                Mensagens.Texto("<== Aniquilação Final ==>\n", "red");
                                Console.WriteLine("Dia {0}\nLevel {1}\n", P.getDia(), P.getLvl());
                                Console.WriteLine("O vendedor te deseja uma ótima viagem!\nPoção de mana adiquirida!");
                                Console.ReadKey();
                            }
                        }
                        else if (esc2 == 6 && P.getMoedas() >= 5)
                        {
                            Console.Clear();
                            Mensagens.Texto("<== Aniquilação Final ==>\n", "red");
                            Console.WriteLine("Dia {0}\nLevel {1}\n", P.getDia(), P.getLvl());
                            Console.WriteLine("Você encontrou um vendedor na vila \nDeseja comprar Poção de estamina?");
                            Console.WriteLine("(1) Sim (5 moedas)");
                            Console.WriteLine("(2) Não");
                            int esc3 = Mensagens.LerIntComValidacao("Escolha inválida! Digite um número válido para ataque.", 1, 2);
                            if (esc3 == 1)
                            {
                                P.setMoedas(-5);
                                P.setPE(1);
                                Console.Clear();
                                Mensagens.Texto("<== Aniquilação Final ==>\n", "red");
                                Console.WriteLine("Dia {0}\nLevel {1}\n", P.getDia(), P.getLvl());
                                Console.WriteLine("O vendedor te deseja uma ótima viagem!\nPoção de estamina adiquirida!");
                                Console.ReadKey();
                            }
                        }
                        else if (esc2 == 7)
                        {
                            esc1 = 1;
                        }
                        else
                        {
                            Console.Clear();
                            Mensagens.Texto("<== Aniquilação Final ==>\n", "red");
                            Console.WriteLine("Dia {0}\nLevel {1}\n", P.getDia(), P.getLvl());
                            Console.WriteLine("Você não tem dinheiro suficiente");
                            Console.ReadKey();
                        }
                        if (esc1 == 1)
                        {
                            break;
                        }
                    }
                    Mensagens.Vila(P.getDia());
                    if (P.getDia() == 25)
                    {
                        Aniquilacao A = new Aniquilacao();
                        bool podeAtacar = false;
                        int escI; // Escolha da Aniquilação
                        int escB = 1; // Escolha de batalha
                        bool buff = false;
                        while (A.getVida() > 0 && P.getVida() > 0)
                        {
                            Console.Clear();
                            Mensagens.Texto("<== Aniquilação Final ==>\n", "red");
                            Console.WriteLine("Dia: {0}\nLevel: {1}", P.getDia(), P.getLvl());
                            Console.WriteLine("Vida: {0}/{1} Mana: {2}/{3} Estamina: {4}/{5}\n", P.getVida(), P.getVidaMax(), P.getMana(), P.getManaMax(), P.getEstamina(), P.getEstaminaMax());
                            Mensagens.Texto($"Você encontrou a Aniquilação", "blue");
                            Console.WriteLine("Vida: {0}/{1} Level: {2}\n", A.getVida(), A.getVidaMax(), A.getLvl());
                            Console.WriteLine();
                            if (podeAtacar == true)
                            {
                                Console.WriteLine("--- Ataques ---");
                                Console.WriteLine($"(1) {P.getAtaques(0)}");
                                if (P.getAtaques(1) != null) { Console.WriteLine($"(2) {P.getAtaques(1)}"); }
                                if (P.getAtaques(2) != null) { Console.WriteLine($"(3) {P.getAtaques(2)}"); }
                                if (P.getAtaques(3) != null) { Console.WriteLine($"(4) {P.getAtaques(3)}"); }
                                if (P.getPC() >= 1 || P.getPM() >= 1 || P.getPE() >= 1)
                                {
                                    Console.WriteLine("\n--- Poções ---");
                                    if (P.getPC() > 0) { Console.WriteLine($"(5) Poção de Cura [{P.getPC()}]"); }
                                    if (P.getPM() > 0) { Console.WriteLine($"(6) Poção de Mana [{P.getPM()}]"); }
                                    if (P.getPE() > 0) { Console.WriteLine($"(7) Poção de Estamina [{P.getPE()}]"); }
                                }

                                if (P.getPC() >= 1 || P.getPM() >= 1 || P.getPE() >= 1) { escB = Mensagens.LerIntComValidacao("Escolha inválida! Digite um número válido para ataque.", 1, 7); }
                                else { escB = Mensagens.LerIntComValidacao("Escolha inválida! Digite um número válido para ataque.", 1, 4) + 1; }
                                if (escB < 5)
                                {
                                    if (P.getEstaminaAtaque(escB - 1) <= P.getEstamina() && P.getManaAtaque(escB - 1) <= P.getMana())
                                    {
                                        if (buff == true) { A.setVida(P.getDanoAtaques(escB - 1, P.getLvl())+ 5); }
                                        else { A.setVida(P.getDanoAtaques(escB - 1, P.getLvl())); }
                                        P.setMana(escB - 1);
                                        P.setEstamina(escB - 1);
                                        podeAtacar = false;
                                        Console.WriteLine($"Você usou {P.getAtaques(escB - 1)}");
                                        if (P.getAtaques(escB - 1) == "Murro do Trovão" || P.getAtaques(escB - 1) == "Ponto Cego") // Ataque de Tanque e Ladino - Stunn
                                        {
                                            podeAtacar = true;
                                            Console.WriteLine("Inimigo Estunado!");
                                            Console.ReadKey();
                                        }
                                        if (P.getAtaques(escB - 1) == "Cicatrização Espiral") // Cura de Mago
                                        {
                                            P.setVida(-10);
                                            Console.WriteLine("Você curou 10 de vida!");
                                            Console.ReadKey();
                                        }
                                        if (P.getAtaques(escB - 1) == "Dança das Facas") // Buff de Dano
                                        {
                                            buff = true;
                                            Console.WriteLine("Dano aumentado em 5!");
                                            Console.ReadKey();
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Você não possúi mana ou estamina o suficiente para esse movimento!");
                                    }
                                }
                                else
                                {
                                    if (escB == 5 && P.getPC() > 0)
                                    {
                                        P.setPC(-1);
                                        if (P.getVida() <= (P.getVidaMax() - 10)) { P.setVida(-10); }
                                        else { P.setVidaTotal(); }
                                        Console.WriteLine("+10 de Vida!");
                                    }
                                    if (escB == 6 && P.getPM() > 0)
                                    {
                                        P.setPM(-1);
                                        if (P.getMana() <= (P.getManaMax() - 10)) { P.setManaRoubo(-10); }
                                        else { P.setManaTotal(); }
                                        Console.WriteLine("+10 de Mana!");
                                    }
                                    if (escB == 7 && P.getPE() > 0)
                                    {
                                        P.setPE(-1);
                                        if (P.getEstamina() <= (P.getEstaminaMax() - 10)) { P.setEstaminaRoubo(-10); }
                                        else { P.setEstaminaTotal(); }
                                        Console.WriteLine("+10 de Estamina!");
                                    }
                                    Console.ReadKey();
                                }
                            }
                            else
                            {
                                escI = A.Atacar();
                                if (P.getAtaques(escB - 1) == "Parede de Ferro") // Ataque de Tanque - tomar metade do dano e dar ela pro inimigo
                                {
                                    int danoinimigo = A.getDanoAtaques(escI, A.getLvl());
                                    P.setVida(danoinimigo / 2);
                                    A.setVida(danoinimigo / 2);
                                }
                                else
                                {
                                    P.setVida(A.getDanoAtaques(escI, A.getLvl()));
                                }
                                Console.WriteLine($"{A.getNome()} usou {A.getAtaques(escI)}");

                                podeAtacar = true;
                                Random rng = new Random();
                                if (A.getAtaques(escI) == "Paralisia") { podeAtacar = false; }
                                if (A.getAtaques(escI) == "Confusão")
                                {
                                    int manaRoubada = rng.Next(0, (P.getMana() / 2));
                                    Console.WriteLine($"Aniquilação roubou {manaRoubada} de Mana");
                                    P.setManaRoubo(manaRoubada);
                                }
                                if (A.getAtaques(escI) == "Sono")
                                {
                                    int estaminaRoubada = rng.Next(0, (P.getEstamina() / 2));
                                    Console.WriteLine($"Aniquilação roubou {estaminaRoubada} de Estamina");
                                    P.setEstaminaRoubo(estaminaRoubada);
                                }
                                Console.ReadKey();
                            }
                            Console.Clear();
                            if (A.getVida() < 50 && A.GetFase2() == false)
                            {
                                A.Transformar();
                            }
                            if (A.getVida() < 1 && A.GetFase2() == true)
                            {
                                A.ExplosãoFinal();
                                Final = true;
                                esc = 0;
                            }
                        }
                        Console.Clear();
                    }

                } 
                else
                {
                    
                    Console.WriteLine("(1) Avançar");
                    Console.WriteLine("(2) Estátisticas");
                    esc = Mensagens.LerIntComValidacao("Escolha inválida! Digite um número válido para ataque.", 1, 4);
                }
                esc1 = 0;

                Console.Clear();

                if (esc == 1)
                {
                    int leveldoinimigo;
                    if (P.getLvl() < 6) { leveldoinimigo = P.getLvl(); }
                    else { leveldoinimigo = (P.getVida() + P.getMana() + P.getEstamina()) / 3; }
                    Inimigo I = new Inimigo((P.getVida()+P.getMana()+P.getEstamina())/3);
                    bool podeAtacar = true;
                    int escI; // Escolha do inimigo
                    int escB=0; // Escolha de batalha
                    bool buff = false;
                    while (I.getVida() > 0 && P.getVida() > 0)
                    {
                        Mensagens.Texto("<== Aniquilação Final ==>\n", "red");
                        Console.WriteLine("Dia: {0}\nLevel: {1}", P.getDia(), P.getLvl());
                        Console.WriteLine("Vida: {0}/{1} Mana: {2}/{3} Estamina: {4}/{5}\n", P.getVida(), P.getVidaMax(), P.getMana(), P.getManaMax(), P.getEstamina(), P.getEstaminaMax());
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
                            if (P.getPC() >= 1 || P.getPM() >= 1 || P.getPE() >= 1)
                            {
                                Console.WriteLine("\n--- Poções ---");
                                if (P.getPC() > 0) { Console.WriteLine($"(5) Poção de Cura [{P.getPC()}]"); }
                                if (P.getPM() > 0) { Console.WriteLine($"(6) Poção de Mana [{P.getPM()}]"); }
                                if (P.getPE() > 0) { Console.WriteLine($"(7) Poção de Estamina [{P.getPE()}]"); }
                            }

                            if (P.getPC() >= 1 || P.getPM() >= 1 || P.getPE() >= 1) { escB = Mensagens.LerIntComValidacao("Escolha inválida! Digite um número válido para ataque.", 1, 7); }
                            else { escB = Mensagens.LerIntComValidacao("Escolha inválida! Digite um número válido para ataque.", 1, 4); }
                            if (escB < 5)
                            {
                                if (P.getEstaminaAtaque(escB - 1) <= P.getEstamina() && P.getManaAtaque(escB - 1) <= P.getMana())
                                {
                                    if (buff == true) { I.setVida(P.getDanoAtaques(escB - 1, P.getLvl()) + 5); }
                                    else { I.setVida(P.getDanoAtaques(escB - 1, P.getLvl())); }
                                    P.setMana(escB - 1);
                                    P.setEstamina(escB - 1);
                                    podeAtacar = false;
                                    Console.WriteLine($"Você usou {P.getAtaques(escB - 1)}");
                                    if (P.getAtaques(escB - 1) == "Murro do Trovão" || P.getAtaques(escB - 1) == "Ponto Cego") // Ataque de Tanque e Ladino - Stunn
                                    {
                                        podeAtacar = true;
                                        Console.WriteLine("Inimigo Estunado!");
                                        Console.ReadKey();
                                    }
                                    if (P.getAtaques(escB - 1) == "Cicatrização Espiral") // Cura de Mago
                                    {
                                        P.setVida(P.getVida());
                                        P.setVida(P.getVidaMax() * (-1));
                                        Console.WriteLine("Você curou!");
                                        Console.ReadKey();
                                    }
                                    if (P.getAtaques(escB - 1) == "Dança das Facas") // Buff de Dano
                                    {
                                        buff = true;
                                        Console.WriteLine("Dano aumentado em 5!");
                                        Console.ReadKey();
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Você não possúi mana ou estamina o suficiente para esse movimento!");
                                }
                            }
                            else
                            {
                                if(escB == 5 && P.getPC() > 0)
                                {
                                    P.setPC(-1);
                                    if(P.getVida() <= (P.getVidaMax() - 10)) { P.setVida(-10); }
                                    else { P.setVidaTotal(); }
                                    Console.WriteLine("+10 de Vida!");
                                }
                                if (escB == 6 && P.getPM() > 0)
                                {
                                    P.setPM(-1);
                                    if (P.getMana() <= (P.getManaMax() - 10)) { P.setManaRoubo(-10); }
                                    else { P.setManaTotal(); }
                                    Console.WriteLine("+10 de Mana!");
                                }
                                if (escB == 7 && P.getPE() > 0)
                                {
                                    P.setPE(-1);
                                    if (P.getEstamina() <= (P.getEstaminaMax() - 10)) { P.setEstaminaRoubo(-10); }
                                    else { P.setEstaminaTotal(); }
                                    Console.WriteLine("+10 de Estamina!");
                                }
                                Console.ReadKey();
                            }
                        }
                        else
                        {
                            escI = I.Atacar();
                            if (P.getAtaques(escB - 1) == "Parede de Ferro") // Ataque de Tanque - tomar metade do dano e dar ela pro inimigo
                            {
                                int danoinimigo = I.getDanoAtaques(escI, (I.getLvl()/2));
                                P.setVida(danoinimigo / 2);
                                I.setVida(danoinimigo / 2);
                            }
                            else
                            {
                                P.setVida(I.getDanoAtaques(escI, (I.getLvl()/2)));
                            }
                            Console.WriteLine($"{I.getNome()} usou {I.getAtaques(escI)}");
                            if (I.getAtaques(escI) == "Ladroagem") // Roubo de Moedas Do Goblin
                            {
                                if (I.getLvl() <= 5)
                                {
                                    P.setMoedas(-5);
                                    Console.WriteLine("Goblin roubou 5 moedas!");
                                }
                                else
                                {
                                    P.setMoedas(I.getLvl());
                                    Console.WriteLine($"Goblin roubou {I.getLvl()} moedas!");
                                }
                            }
                            if (I.getAtaques(escI) == "Uivo Espectral") // Roubo de Moedas Do Goblint
                            {
                                if (P.getMana() < I.getLvl()) { P.setManaRoubo(P.getMana()); }
                                else { P.setManaRoubo(I.getLvl()); }
                                if (P.getEstamina() < I.getLvl()) { P.setEstaminaRoubo(P.getEstamina()); }
                                else { P.setEstaminaRoubo(I.getLvl()); }
                                Console.WriteLine($"{I.getLvl()} pontos de Mana/Estamina roubados!");
                            }
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
                                P.setXp((10 + (P.getLvl() * 2)) * (-1));
                                P.setLvl();
                                Console.WriteLine("Level++");
                                P.setVidaMax(5);
                                P.setEstaminaMax(5);
                                P.setManaMax(5);
                                P.setStatus("Todos");
                                P.atklvl();
                            }
                            Random rng = new Random();
                            P.setMoedas(rng.Next(3, 5));
                            P.setDia();
                            Console.ReadKey();
                        }
                    }
                }
                if (esc == 2)
                {
                    Mensagens.Texto("<== Aniquilação Final ==>\n", "red");
                    Mensagens.Texto($"Estátisticas do(a) {P.getNome()}\n", "blue");
                    Console.WriteLine("Dia: {0}\nLevel: {1} (XP: {2}/{3})\nSaldo: {4} moedas \nRaça: {5}\nClasse: {6}\nVida: {7}/{8}\nMana: {9}/{10}\nEstamina: {11}/{12}\n", P.getDia(), P.getLvl(), P.getXp(), 10 + (P.getLvl() * 2), P.getMoedas(), P.getRaca(), P.getClasse(), P.getVida(), P.getVidaMax(), P.getMana(), P.getManaMax(), P.getEstamina(), P.getEstaminaMax());
                    Console.WriteLine("--- Ataques ---");
                    Console.WriteLine($"(1) {P.getAtaques(0)}");
                    Console.WriteLine(P.getDescAtaques(0));
                    if (P.getAtaques(1) != null) { Console.WriteLine($"(2) {P.getAtaques(1)}"); Console.WriteLine(P.getDescAtaques(1)); }
                    if (P.getAtaques(2) != null) { Console.WriteLine($"(3) {P.getAtaques(2)}"); Console.WriteLine(P.getDescAtaques(2)); }
                    if (P.getAtaques(3) != null) { Console.WriteLine($"(4) {P.getAtaques(3)}"); Console.WriteLine(P.getDescAtaques(3)); }
                    Console.ReadKey();
                }
                Console.Clear();
            }
            if(Final == true)
            {
                Mensagens.Texto("<== Aniquilação Final ==>\n", "red");
                Console.WriteLine("Vitória!\n");
                System.Environment.Exit(1);
                Console.ReadKey();
            }
            else if(P.getVida() <= 0)
            {
                Mensagens.Texto("<== Aniquilação Final ==>\n", "red");
                Console.WriteLine("Gamer Over!\n");
                Console.WriteLine("ENTER - Continuar");
                Console.ReadKey();
            }
        }

        
    }
}
