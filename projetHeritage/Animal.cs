using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace projetHeritage
{
    // Classe abstraite Animal 
    public abstract class Animal
    {
        protected string name;
        protected int legsCount;

        public Animal(string _name, int _legsCount)
        {
            name = _name;
            legsCount = _legsCount;

        }

        //Methode Manger 
        public void Eat()
        {
            System.Console.WriteLine(name + " mange avec sa bouche et s'aide de ses mains ou pattes. ");
        }

        //Methode Se deplacer
        public virtual void Move()
        {
            System.Console.WriteLine(name + " se deplace");
        }

        //Methode pour obtenir le nom
        public string GetName()
        {
            return name;
        }
    }

    public class Bipedes : Animal
    {
        public Bipedes(string _name) : base(_name, 2)
        { }

       
        public override void Move()
        {
            Console.WriteLine(name + " se déplace sur deux pattes. ");
        }

    }
    public class Human : Bipedes
    {
        public Human(string _name) : base(_name)
        { }
               

        public override void Move()
        {
            Console.WriteLine(name + " marche sur deux jambes. ");
        }
    }
    public class Singe : Bipedes
    {
        public Singe(string _name) : base(_name)
        { }

        public override void Move()
        {
            Console.WriteLine(name + " marche sur deux jambes et aussi avec ses mains. ");
        }
    }


    public class Quadrupedes : Animal
    {
        public Quadrupedes(string _name) : base(_name, 4)
        { }
     
        public override void Move()
        {
            Console.WriteLine(" se déplace sur ses quatres pattes. ");
        }

    }

    public class Elephant : Quadrupedes
    {
        public Elephant(string _name) : base(_name)
        { }

        public override void Move()
        {
            Console.WriteLine(name + " marche sur ses quatres pattes et à une trompe qui peut l'aider. ");
        }
    }

    public class Tortue : Quadrupedes
    {
        public Tortue(string _name) : base(_name)
        { }

        public override void Move()
        {
            Console.WriteLine(name + " marche sur ses quatres pattes mais lentement. ");
        }
    }

    public class Lezard : Quadrupedes
    {
        public Lezard(string _name) : base(_name)
        { }

        public override void Move()
        {
            Console.WriteLine(name + " marche sur ses quatres pattes et très vite. ");
        }
    }
    
}

