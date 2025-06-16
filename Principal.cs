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
        private int mana;
        private int manaMax;
        private int estamina;
        private int estaminaMax;
        private int xp = 0;
        private int dia = 1;

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
                DanoAtaques[0] = 5;
                estaminaAtaques[0] = 2;
                manaAtaques[0] = 0;
            }
            if (classe == 2)
            {
                vida += 0;
                mana += 10;
                estamina += 5;
                ataques[0] = "Bola de fogo";
                DanoAtaques[0] = 5;
                estaminaAtaques[0] = 0;
                manaAtaques[0] = 2;
            }
            if (classe == 3)
            {
                vida += 5;
                mana += 0;
                estamina += 10;
                ataques[0] = "Espadada";
                DanoAtaques[0] = 5;
                estaminaAtaques[0] = 2;
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
        public int getManaAtaque(int x)
        {
            return manaAtaques[x];
        }
        public void setMana(int x)
        {
            mana -= manaAtaques[x]; 
        }
        public void setManaMax(int x)
        {
            manaMax += x;
        }
        public int getEstaminaAtaque(int x)
        {
            return estaminaAtaques[x];
        }
        public void setEstamina(int x)
        {
            estamina -= estaminaAtaques[x];
        }
        public void setEstaminaMax(int x)
        {
            estaminaMax += x;
        }
        public int getEstaminaMax()
        {
            return estaminaMax;
        }
        public int getManaMax()
        {
            return manaMax;
        }
        public void setStatus()
        {
            estamina = estaminaMax;
            vida = vidamax;
            mana = manaMax;
        }
        public void setVidaMax(int v)
        {
            vidamax += v;
        }
    }
}
