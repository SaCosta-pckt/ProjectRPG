namespace ProjectRPG.src.Entities
{
    public class Caracter
    {
        public Caracter(string name, string element, string skill)
        {
            this.name=name;
            this.element=element;
            this.skill=skill;
        }
        public Caracter()
        {

        }
        public string name = "Traveler";
        public string element = "Unknown";
        public string skill = "Empurrão";
        public int level=1;
        public int hp=500;

        public override string ToString(){
            return "Nome: " + this.name + " " + " | Elemento: " + " " + this.element + " | Habilidade: " + this.skill;
        }

        public string Attack(){
            return this.name +" deu um soco no oponente!";
        }

        public string Skill(){
            return this.name + " usou: "+ this.skill + "!";
        }

        public string Die(){
            return this.name + " morreu...";
        }
    }
}