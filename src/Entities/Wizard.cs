namespace Abstração_de_um_Jogo_RPG.src.Entities
{
        public class Wizard : Hero
        {
            public Wizard(string  Name, int lvl, string HeroType){
            this.Name = Name;
            this.lvl = lvl;
            this.HeroType = HeroType;
            }

            public override  string Attack(){
                return  this.Name  + " Atacou ";        
            }
    }
}
