using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Aniquilação_Final
{
    internal class Personagem
    {
        protected string nome;
        protected int vida;
        protected int vidamax;
        protected int lvl = 1;
        protected string[] ataques = new string[4];
        protected int[] DanoAtaques = new int[4];

        public string getAtaques(int x)
        {
            return ataques[x];
        }
        public void setAtaques(int x, string ataque)
        {
            ataques[x] = ataque;
        }
        public int getDanoAtaques(int x, int lvl)
        {
            if(lvl == 1)
            {
                return DanoAtaques[x];
            }
            else
            {
                return DanoAtaques[x] * (lvl / 2);
            }
        }
        public void setDanoAtaques(int x, int dano)
        {
            DanoAtaques[x] = dano;
        }
        public string getNome()
        {
            return nome;
        }
        public int getVida()
        {
            return vida;
        }
        public void setVida(int v)
        {
            vida -= v;
        }
        public void setVidaTotal()
        {
            vida = vidamax;
        }
      
        public int getVidaMax()
        {
            return vidamax;
        }
        public int getLvl()
        {
            return lvl;
        }

        public void setLvl()
        {
            lvl += 1;
        }
    }
}
