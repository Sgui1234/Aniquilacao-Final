using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aniquilação_Final
{
    internal class Inimigo:Personagem
    {
        private string[] nomeInimigo = {"Lobo", "Goblin"};
        
        public Inimigo(int lvlp)
        {
            Random rng = new Random();
            nome = nomeInimigo[rng.Next(0,2)];
            if (lvlp < 6) { lvl = rng.Next(1, 5); }
            else { lvl = lvlp/3; }
            vida = lvl * 3;
            vida -= rng.Next(lvl);
            vidamax = vida;

            if (nome == "Lobo")
            {
                ataques[0] = "Mordida";
                DanoAtaques[0] = 5;
                if (lvl >= 5)
                {
                    ataques[1] = "Uivo Espectral";
                    DanoAtaques[1] = 5;
                }
            }
            else if (nome == "Goblin")
            {
                ataques[0] = "Espadada";
                DanoAtaques[0] = 5;
                if(lvl >= 5)
                {
                    ataques[1] = "Ladroagem";
                    DanoAtaques[1] = 5;
                }
            }
        }

        public int Atacar()
        {
            
            if (ataques[1] != null)
            {
                Random ataque = new Random();
                int atk = ataque.Next(0, 2);
                return atk;

            }
            else
            {
                return 0;
            }
        }
        
    }
}
