namespace ProjectRPG.src.Entities
{
    public class Archer : Caracter
    {
        public Archer(string name, string element, string skill)
        {
            this.name=name;
            this.element=element;
            this.skill=skill;
        }

        public int skillDmg = 5;

        public override string Attack(Caracter slime){
            slime.hp-= 10 + this.bonus;
            return this.name +" lançou uma flecha no oponente!";
        }

        public override string Skill(Caracter slime){
            slime.hp-= this.skillDmg + this.bonus;
            slime.hp-= this.skillDmg + this.bonus;
            slime.hp-= this.skillDmg + this.bonus;
            slime.hp-= this.skillDmg + this.bonus;
            return $@"{this.name} usou {this.skill}!
            O oponete sofreu {this.skillDmg + this.bonus} de dano e sofrerá esse dano novamente a cada turno por 4 turnos.";
        }
    }
}