using projetHeritage;
using System;

class MainProgram
{
    public static void Main(string[] args)
    {
        //Création d'nstances des differents types d'animaux

        Animal human = new Human("Curtis");
        Animal singe = new Singe("Abou");
        Animal elephant = new Elephant("Dumbo");
        Animal tortue = new Tortue("Donatello");
        Animal lezard = new Lezard("Zony");


        //Créatin de la liste d'animaux

        Animal[] animals = {human, singe, elephant, tortue, lezard };

        //Appel des methodes Eat et Move pour chaque animal

        foreach (var animal in animals)
        {
            animal.Eat();
            animal.Move();
            Console.WriteLine();
        }
    }
}