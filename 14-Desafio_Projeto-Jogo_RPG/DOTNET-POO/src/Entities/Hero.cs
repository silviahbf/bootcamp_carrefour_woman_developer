using System;

namespace DOTNET_POO.src.Entities
{
    public class Hero
    {
        public Hero(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
               
        }
        public string Name;
        public int Level;
        public string HeroType;

        public override string ToString()
        {
            return "Nome: " + this.Name + "  " + "  Level: " + this.Level + "  " + "  Hero Type: " + this.HeroType;
        }
        
        public virtual string Attack()
        {
            return this.Name + " atacou com uma espada! ";
        }

        public string Defend()
        {
            return this.Name + " defendeu-se com seu escudo encantado! ";
        }

    }
}    