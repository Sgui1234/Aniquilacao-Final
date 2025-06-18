using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aniquilação_Final
{
    internal class Principal:Personagem
    {
        protected int[] estaminaAtaques = new int[4];
        protected int[] manaAtaques = new int[4];
        protected string[] descAtaques = new string[4];
        private int pc = 1;
        private int pm = 0;
        private int pe = 0;
        private int mana;
        private int manaMax;
        private int estamina;
        private int estaminaMax;
        private int xp = 0;
        private int dia = 1;
        private int moedas = 10;
        private int raca;
        private int classe;

        public Principal(int r, int c, string n)
        {
            nome = n;
            raca = r;
            classe = c;

            if (raca == 1)
            {
                vida = 10;
                mana = 10;
                estamina = 10;
            }
            if (raca == 2)
            {
                vida = 7;
                mana = 15;
                estamina = 10;
            }
            if (raca == 3)
            {
                vida = 15;
                mana = 7;
                estamina = 10;
            }

            if (classe == 1)
            {
                vida += 10;
                mana += 0;
                estamina += 5;
                ataques[0] = "Escudada";
                descAtaques[0] = "Um golpe direto com o escudo que causa dano (5 de Dano - 0 de Estamina)";
                DanoAtaques[0] = 5;
                estaminaAtaques[0] = 0;
                manaAtaques[0] = 0;
            }
            if (classe == 2)
            {
                vida += 5;
                mana += 10;
                estamina += 5;
                ataques[0] = "Bola de fogo";
                descAtaques[0] = "Arremessa uma esfera flamejante que explode ao impacto (5 de Dano - 0 de Mana)";
                DanoAtaques[0] = 5;
                estaminaAtaques[0] = 0;
                manaAtaques[0] = 0;
            }
            if (classe == 3)
            {
                vida += 5;
                mana += 0;
                estamina += 10;
                ataques[0] = "Espadada";
                descAtaques[0] = "Um golpe direto com uma lâmina que causa dano (5 de Dano - 0 de Estamina)";
                DanoAtaques[0] = 5;
                estaminaAtaques[0] = 0;
                manaAtaques[0] = 0;
            }
            vidamax = vida;
            estaminaMax = estamina;
            manaMax = mana;
        }
        public string getRaca()
        {
            if (raca == 1)
            {
                return "Humano";
            }
            else if (raca == 2)
            {
                return "Elfo";
            }
            else if (raca == 3)
            {
                return "Anão";
            }
            else
            {
                return "";
            }
        }
        public string getClasse()
        {
            if (classe == 1)
            {
                return "Tanque";
            }
            else if (classe == 2)
            {
                return "Mago";
            }
            else if (classe == 3)
            {
                return "Ladino";
            }
            else
            {
                return "";
            }

        }
        public int getPC()
        {
            return pc;
        }
        public void setPC(int x)
        {
            pc += x;
        }
        public int getPM()
        {
            return pm;
        }
        public void setPM(int x)
        {
            pm += x;
        }
        public int getPE()
        {
            return pe;
        }
        public void setPE(int x)
        {
            pe += x;
        }
        public string getDescAtaques(int x)
        {
            return descAtaques[x];
        }
        public int getMana()
        {
            return mana;
        }
        public int getEstamina()
        {
            return estamina;
        }
        public int getDia()
        {
            return dia;
        }
        public void setDia()
        {
            dia++;
        }
        public void setXp(int exp)
        {
            xp += exp;
        }
        public int getXp()
        {
            return xp;
        }
        public void setMoedas(int moeda)
        {
            moedas += moeda;
        }
        public int getMoedas()
        {
            return moedas;
        }
        public int getManaAtaque(int x)
        {
            return manaAtaques[x];
        }
        public void setMana(int x)
        {
            mana -= manaAtaques[x]; 
        }
        public void setManaRoubo(int x)
        {
            mana -= x;
        }
        public void setManaMax(int x)
        {
            manaMax += x;
        }
        public void setManaTotal()
        {
            mana = manaMax;
        }
        public int getEstaminaAtaque(int x)
        {
            return estaminaAtaques[x];
        }
        public void setEstamina(int x)
        {
            estamina -= estaminaAtaques[x];
        }
        public void setEstaminaRoubo(int x)
        {
            estamina -= x;
        }
        public void setEstaminaMax(int x)
        {
            estaminaMax += x;
        }
        public void setEstaminaTotal()
        {
            estamina = estaminaMax;
        }
        public int getEstaminaMax()
        {
            return estaminaMax;
        }
        public int getManaMax()
        {
            return manaMax;
        }
        public void setStatus(string status)
        {
            if(status == "Mana")
            {
                mana = manaMax;
            }
            else if(status == "Estamina")
            {
                estamina = estaminaMax;
            }
            else if (status == "Vida")
            {
                vida = vidamax;
            }
            else
            {
                vida = vidamax;
                estamina = estaminaMax;
                mana = manaMax;
            }
        }
        public void setVidaMax(int v)
        {
            vidamax += v;
        }

        public void atklvl()
        {
            if(classe == 1) // CLASSE TANQUE
            {
                if (lvl >= 5)
                {
                    ataques[1] = "Parede de Ferro"; // diminúi o dano recebido pela metade, e devolve esse dano não recebido
                    descAtaques[1] = "O tanque se torna uma muralha inabalável. Diminúi o dano recebido pela metade, devolvendo-o. (X de Dano - 5 de Estamina)";
                    DanoAtaques[1] = 0;
                    estaminaAtaques[1] = 5;
                    manaAtaques[1] = 0;
                }
                if (lvl >= 10) 
                {
                    ataques[2] = "Ataque Defensivo"; // Dano simples
                    descAtaques[2] = "O tanque se firma no chão, e se prapara para o contra ataque. (10 de Dano - 5 de Estamina).";
                    DanoAtaques[2] = 10;
                    estaminaAtaques[2] = 5;
                    manaAtaques[2] = 0;
                }
                if (lvl >= 15)
                {
                    ataques[3] = "Murro do Trovão"; // stunna o inimigo por 1 round
                    descAtaques[3] = "Um golpe devastador que atinge o inimigo, causando dano e atordoamento. (10 de Dano - 7 de Estamina - Atordoamento)";
                    DanoAtaques[3] = 10;
                    estaminaAtaques[3] = 7;
                    manaAtaques[3] = 0;
                }
            }
            if (classe == 2) // CLASSE MAGO
            {
                if (lvl >= 5)
                {
                    ataques[1] = "Nevasca Arcana"; // Dano simples
                    descAtaques[1] = "Uma tempestade mágica de gelo desaba sobre a área, causando dano. (10 de Dano - 5 de Mana)";
                    DanoAtaques[1] = 10;
                    estaminaAtaques[1] = 0;
                    manaAtaques[1] = 5;
                }
                if (lvl >= 10)
                {
                    ataques[2] = "Cicatrização Espiral"; // Cura simples
                    descAtaques[2] = "Energias místicas fluem em espiral pelo corpo do alvo, restaurando vida. (5 de Mana - +10 de vida)";
                    DanoAtaques[2] = 0;
                    estaminaAtaques[2] = 0;
                    manaAtaques[2] = 5;
                }
                if (lvl >= 15)
                {
                    ataques[3] = "Decadência"; // Dano simples
                    descAtaques[3] = "Uma aura sombria corrói o inimigo por dentro, causando muito dano. (20 de Dano - 10 de Mana)";
                    DanoAtaques[3] = 20;
                    estaminaAtaques[3] = 0;
                    manaAtaques[3] = 10;
                }
            }
            if (classe == 3) // CLASSE LADINO
            {
                if (lvl >= 5)
                {
                    ataques[1] = "Dança das Facas"; // Buff de força até o final da batalha
                    descAtaques[1] = "O envolve-se em um ritmo ágil, aumentando a velocidade de seus ataques pela batalha. (5 de Estamina - +5 de dano em ataques)";
                    DanoAtaques[1] = 0;
                    estaminaAtaques[1] = 5;
                    manaAtaques[1] = 0;
                }
                if (lvl >= 10) 
                {
                    ataques[2] = "Lâmina Sombria"; // Dano simples
                    descAtaques[2] = "Uma lâmina envolta em sombras corta o inimigo, causando dano. (10 de Dano - 5 Estamina)";
                    DanoAtaques[2] = 10;
                    estaminaAtaques[2] = 5;
                    manaAtaques[2] = 0;
                }
                if (lvl >= 15)
                {
                    ataques[3] = "Ponto Cego"; // Dano com stunn
                    descAtaques[3] = "Um golpe preciso que atinge o ponto cego do inimigo, causando dano e atordoamento. (10 de Dano - 7 de Estamina - Atordoamento)" ;
                    DanoAtaques[3] = 10;
                    estaminaAtaques[3] = 7;
                    manaAtaques[3] = 0;
                }
            }
        }
    }
}
