namespace ProjectRPG.src.Entities
{
    public class Slime : Caracter
    {
        public Slime(string element)
        {
            this.element=element;
            this.name = "Slime";
            this.hp = 200;
        }
    }
}