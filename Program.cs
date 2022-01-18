using ProjectRPG.src.Entities;
namespace ProjectRPG
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declarar Heróis
            Wizard hero1 = new Wizard("Klee","Pyro","Explodir");
            Knight hero2 = new Knight("Chongyun","Cryo","Congelar");
            Healer hero3 = new Healer("Kokomi","Hydro","Curar");
            Archer hero4 = new Archer("Fichl","Electro","Eletrizar");
            Lancer hero5 = new Lancer("Yun jin","Geo","Defender");

           // Declarar Inimigos 
            Slime enemy1 = new Slime("Pyro");
            Slime enemy2 = new Slime("Hydro");
            Slime enemy3 = new Slime("Cryo");
            Slime enemy4 = new Slime("Geo");
            Slime enemy5 = new Slime("Electro");

            // Fazer array de Slimes e sortear um
            Slime[] slimes = new Slime[5];
            slimes[0]= enemy1;
            slimes[1]= enemy2;
            slimes[2]= enemy3;
            slimes[3]= enemy4;
            slimes[4]= enemy5;

            Random r = new Random();
            int rInt = r.Next(0, 4);
            Slime oponnent = slimes[rInt];

            // Disponibilizar para o jogador escolher com qual personagem quer jogar
            Console.WriteLine("\nCom qual personagem quer jogar? \n");
            Console.WriteLine("1- " + hero1.ToString());
            Console.WriteLine("2- " + hero2.ToString());
            Console.WriteLine("3- " + hero3.ToString());
            Console.WriteLine("4- " + hero4.ToString());
            Console.WriteLine("5- " + hero5.ToString());
            Console.WriteLine("\nSelecione o personagem: ");

            // defaul caracter
            Caracter player = hero1;

            string? choose = Console.ReadLine();
            switch (choose){
               case "1":
                    player = hero1;
                    break;

                case "2":
                    player = hero2;
                    break;

                case "3":
                    player = hero3;
                    break;

                case "4":
                    player = hero4;
                    break;

                case "5":
                    player = hero5;
                    break;
           }

           Console.WriteLine($"\nUm {oponnent.name} {oponnent.element} selvagem apareceu!\n");
           Reaction(player,oponnent);

            //Combat
           while(oponnent.hp >= 0 && player.hp >= 0){
                Console.WriteLine("O que deseja fazer?");
                Console.WriteLine("1 - Atacar");
                Console.WriteLine("2 - Usar habilidade");
                Console.WriteLine("Digite sua escolha:");
                
                string? e = Console.ReadLine();
                switch (e){
                case "1":
                    Console.WriteLine(player.Attack(oponnent));
                    break;

                case "2":
                    Console.WriteLine(player.Skill(oponnent));
                    break;
                }

                Console.WriteLine();
                Console.WriteLine(oponnent.Attack(oponnent));
                Console.WriteLine();
           }

           if (player.hp<=0){
               Console.WriteLine(player.Die());
               Console.WriteLine("Game over!");
           }
           else{
               Console.WriteLine(oponnent.Die());
               Console.WriteLine("Você venceu!");
           }

        }

   
        public static void Reaction(Caracter player, Caracter oponnent)
        {
            if (player.element=="Pyro" && oponnent.element == "Electro"){
                player.bonus += 100;
            }

            else if (player.element=="Electro" && oponnent.element == "Pyro"){
                oponnent.bonus += 100;
            }

            else if (player.element=="Cryo" && oponnent.element == "Hydro"){
                player.bonus += 100;
            }

            else if (player.element=="Hydro" && oponnent.element == "Cryo"){
                oponnent.bonus += 100;
            }

            else if (player.element=="Hydro" && oponnent.element == "Pyro"){
                player.bonus += 100;
            }

            else if (player.element=="Pyro" && oponnent.element == "Hydro"){
                oponnent.bonus += 100;
            }

            else if (player.element=="Electro" && oponnent.element == "Cryo"){
                player.bonus += 100;
            }

            else if (player.element=="Cryo" && oponnent.element == "Electro"){
                oponnent.bonus += 100;
            }

            else if (player.element=="Geo" && oponnent.element == "Geo"){
                oponnent.bonus += 100;
                player.bonus += 100;
            }
        }
    }
}