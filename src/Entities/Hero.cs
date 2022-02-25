namespace Abstração_de_um_Jogo_RPG.src.Entities
{
        public class Hero
        {
                public  Hero(string  Name, int lvl, string HeroType){
                    this.Name = Name;
                    this.lvl = lvl;
                    this.HeroType = HeroType;
                }

                public string  Name;
                public int lvl;
                public string HeroType;

                public override  string ToString(){
                    return this.Name + " " + this.lvl + " " + this.HeroType;
                }

                public virtual string Attack(){
                    return this.Name + " Atacou com seu arco";
                }

        }
}