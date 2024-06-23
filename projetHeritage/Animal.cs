using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace projetHeritage
{
    public abstract class Animal
    {
        protected string name;
        protected int legsCount;

        public Animal(string _name, int _legsCount)
        {
            name = _name;
            legsCount = _legsCount;

        }

        public void Eat()
        {
            System.Console.WriteLine(name + " mange");
        }
        public virtual void Move()
        {
            System.Console.WriteLine(name + " se deplace");
        }

        public class Bipedes : Animal
        {
            public Bipedes(string _name) : base (_name, 2)
            { }
            public override void Move()
            { }

        }
        public class  Human: Bipedes
        {
            public Human(string _name) : base(_name, 2)
            { }
            public override void Move()
            {
                Console.WriteLine(" se déplace sur ces deux jambes. ");
            }

        }
    }
}
