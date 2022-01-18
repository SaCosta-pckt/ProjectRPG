namespace ProjectRPG.src.Entities
{
    public class Knight : Caracter
    {
         public Knight(string name, string element, string skill)
        {
            this.name=name;
            this.element=element;
            this.skill=skill;
        }

        public int skillDmg = 20;

        public override string Attack(Caracter slime){
            slime.hp-= 10 + this.bonus;
            return this.name +" cortou o oponente com sua espada!";
        }

        public override string Skill(Caracter slime){
            slime.hp-= this.skillDmg + this.bonus;
            return $@"{this.name} usou {this.skill}!
            O oponete sofreu {this.skillDmg + this.bonus} de dano e ficará congelado por 3 turnos.";
            //return this.name + " usou: "+ this.skill + "!";
        }
    }
}