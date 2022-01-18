namespace ProjectRPG.src.Entities
{
    public class Wizard : Caracter
    {
        public Wizard(string name, string element, string skill)
        {
            this.name=name;
            this.element=element;
            this.skill=skill;
        }

        public int skillDmg = 50;

        public override string Attack(Caracter slime){
            slime.hp-= 10 + this.bonus;
            return this.name +" lançou uma magia no oponente!";
        }

        public override string Skill(Caracter slime){
            slime.hp-= this.skillDmg + this.bonus;
            return $@"{this.name} usou {this.skill}!
            O oponete sofreu {this.skillDmg + this.bonus} de dano.";
            //return this.name + " usou: "+ this.skill + "!";
        }
    }
}