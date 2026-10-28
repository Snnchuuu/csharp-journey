using System;

namespace OOP_Inheritance_And_Polymorphism{

    public abstract class Champion
    {
        public string? Name {get;}
        public int Health {get; protected set;}

        protected Champion(string name, int health)
        {
            Name = name;
            Health = health;
        }

        public abstract void CastR();
        public virtual void CastQ()
        {
            Console.WriteLine("Basic Q Skill!");
        }
    }

    public class Kayn : Champion
    {
        public Kayn(string name, int health) : base(name, health)
        {
            
        }

        public override void CastQ()    //Method overriding
        {
            Console.WriteLine("Kayn Q: Reaping Slash!");
        }

        public override void CastR()
        {
            Console.WriteLine("Kayn R: Umbral Trespass!");
        }
    }

    public class Teemo : Champion
    {
        public Teemo(string name, int health) : base(name, health)
        {
            
        }

        public new void CastQ() //Method hiding
        {
            Console.WriteLine("Teemo Q: Blinding Dart!");
        }

        public override void CastR()
        {
            Console.WriteLine("Teemo R: Noxious Trap!");
        }


    }
    internal class Program
    {
        static void Main(String[] args)
        {
            Champion[] team = [new Kayn("Kayn", 580), new Teemo("Teemo", 528)];

            foreach(Champion champion in team){
                champion.CastQ();
                champion.CastR();
            }
        }
    }
}
