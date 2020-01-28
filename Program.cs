using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1teste
{
    class Program
    {
        //static void MultipleLegs ( PetStruct petStruct, PetClass petClass)
        //{
        //    petStruct.Legs = petStruct.Legs * 2;
        //    petClass.Legs = petClass.Legs * 2;

        //    Console.WriteLine("Method Intern - That a " + petStruct.Type + " has " + petStruct.Legs + " Legs ");
        //    Console.WriteLine("Method Intern - That a " + petClass.Type + " has " + petClass.Legs + " Legs ");

        //}

        static void Main(string[] args)
        {

            //PetStruct dog = new PetStruct();
            //dog.Type = PetType.Dog ; // "dog."
            //dog.HasFur = true;
            //dog.Legs = 4;

            //PetClass duck = new PetClass();
            //duck.Type = PetType.Duck ;
            //duck.HasFur = false;
            //duck.Legs = 2;

            //Console.WriteLine("That is a " + dog.Type + " and has a " + dog.Legs + " legs.");
            //Console.WriteLine("That is a " + duck.Type + " and has a " + duck.Legs + " legs.");
            ////Console.ReadLine();

            //MultipleLegs(dog, duck);

            //Console.WriteLine("That is a " + dog.Type + " and has a " + dog.Legs + " legs.");
            //Console.WriteLine("That is a " + duck.Type + " and has a " + duck.Legs + " legs.");
            //Console.ReadLine();

            // ------------- OOP

            //MyObject myObject = new MyObject();
            //MyObject myObject2 = new MyObject(10, 10);
            //myObject.Calculate(10, 10);

            //myObject.number1 = 10;
            //myObject.number2 = 5;

            //Console.WriteLine("Number 1  is " + myObject.number1);
            //Console.WriteLine("Number 2 is " + myObject.number2);
            //Console.WriteLine("Object 1 property is " + myObject.number3);
            //Console.WriteLine("Object 2 property is " + myObject2.number3);

            var customer = new MyLibrary1.Customer();
            var calc = new MyLibrary1.Calculate();
            var result = calc.PerformCal(10, 10);
            Console.WriteLine(result);

            Console.ReadLine();

        }

        

        //class PetClass
        //{
        //    public int Legs;
        //    public PetType Type;
        //    public string Name;
        //    public bool HasFur;

        //}

        //struct PetStruct
        //{
        //    public int Legs;
        //    public PetType Type;
        //    public string Name;
        //    public bool HasFur;
        //}

        //enum PetType
        //{
        //    Dog,
        //    Duck
        //}
    }
}
