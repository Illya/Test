using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Animal
    {
        protected string name;

        protected virtual void sayHello()
        {
            
        }

        protected Animal(string name)
        {
            this.name = name;
        }

        public void Hello()
        {
            sayHello();
        }
    }

    class Dog : Animal
    {
        public Dog(string name) : base(name)
        {
            
        }

        protected override void sayHello()
        {
           
            Console.WriteLine("Gav!  " + name);
        }
    }

    class Cat : Animal
    {
        public Cat(string name) : base(name)
        {
            
        }
        protected override void sayHello()
        {
            Console.WriteLine("Miav!  " + name);
        } 
    }

    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog("Barsik");
            Cat cat = new Cat("Murchik");
            
            dog.Hello();
            cat.Hello();
            Console.ReadLine();
        }
    }
}
