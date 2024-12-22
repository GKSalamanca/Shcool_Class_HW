using Shcool_Class_HW;
using Shcool_Class_HW.Shcool_class;
using System.Security.Cryptography.X509Certificates;


namespace Shcool_Class_HW

{
    internal class Program
    {
        static void Main(string[] args)
        {
            var infshcool = GetShcool();
            var infpeople = GetPeople();
            var inffrom = GetFrom();

            Print(infshcool);
            Print2(infpeople);
            Print3(inffrom);


        }




        static void Print(Office office) 
        {
            Console.WriteLine($"В школе {office.Corpus} корпусов");
            Console.WriteLine($"В школе {office.CabClass} классов");

        }

        static void Print2(People people)
        {

            Console.WriteLine($"В школе {people.teacher} учителей");
            Console.WriteLine($"В школе {people.MaxChildren} учеников");

        }

        static void Print3(From from)
        {
            Console.WriteLine($"Школа есть в гоороде: {from.gorod1}");
            Console.WriteLine($"Школа есть в гоороде: {from.gorod2}");
            Console.WriteLine($"Школа есть в гоороде: {from.gorod3}");
            Console.WriteLine($"Школа есть в гоороде: {from.gorod4}");
        }



        static Office GetShcool()
        {
           var office = new Office();
            office.CabClass = 120;
            office.Corpus = 6;

            return office;
        }

        static People GetPeople()
        {
            var people = new People();
            people.teacher = 36;
            people.MaxChildren = 540;

            return people;
        }

        static From GetFrom()
        {
            var gorod = new From();
            gorod.gorod1 = "Moscow";
            gorod.gorod2 = "SPB";
            gorod.gorod3 = "Vladivostok";
            gorod.gorod4 = "Rostov";

            return gorod;
        }




    }
}
