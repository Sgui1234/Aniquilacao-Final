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
            if (lvlp < 6) { lvl = rng.Next(1, 6); }
            else { lvl = rng.Next(lvlp - 3, lvlp + 3); }
            vida = lvl * 3;
            vida -= rng.Next(lvl);
            vidamax = vida;

            if (nome == "Lobo")
            {
                ataques[0] = "Mordida";
                DanoAtaques[0] = 5;
            }
            else if (nome == "Goblin")
            {
                ataques[0] = "Espadada";
                DanoAtaques[0] = 5;
            }
        }

        public int Atacar()
        {
            
            if (ataques[1] != null)
            {
                Random ataque = new Random();
                return 1;

            }
            else
            {
                return 0;
            }
        }
        
    }
}
