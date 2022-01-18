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
        public int bonus=0;

        public override string ToString(){
            return "Nome: " + this.name + " " + " | Elemento: " + " " + this.element + " | Habilidade: " + this.skill;
        }

        public virtual string Attack(Caracter slime){
            slime.hp -= 10; 
            return this.name +" atacou!";
        }

        public virtual string Skill(Caracter slime){
            slime.hp -= 10; 
            return this.name + " usou: "+ this.skill + "!";
        }

        public string Die(){
            return this.name + " morreu...";
        }
    }
}