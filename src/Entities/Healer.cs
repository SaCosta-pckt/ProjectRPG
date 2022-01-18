namespace ProjectRPG.src.Entities
{
    public class Healer : Caracter
    {
        public Healer(string name, string element, string skill)
        {
            this.name=name;
            this.element=element;
            this.skill=skill;
        }

        public int skillHeal = 60;

        public override string Attack(Caracter slime){
            slime.hp -= 10 + this.bonus;
            return this.name +" lançou uma magia no oponente!";
        }

        public override string Skill(Caracter slime){
            this.hp += this.skillHeal;
            return $@"{this.name} usou {this.skill}!
            {this.name} curou {this.skillHeal} de vida.";
        }
    }
}