using System.Security.Principal;

namespace Family
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int broi = int.Parse(Console.ReadLine());
            List<person> people = new List<person>();
            for (int i = 0; i < broi; i++)
            {
                string name = Console.ReadLine();
                int age = int.Parse(Console.ReadLine());

                person family = new person();
                family.name = name;
                family.age = age;

                people.Add(family);
            }

            Print(people);
        }
        public class person
        {
            public int age;
            public string name;
        }
        public class family
        {
            
        }
        public static void Print(List<person> people)
        {
           for (int i =0; i < people.Count; i++)
            {
                Console.WriteLine($"{people[i].name} - {people[i].age}");
            }
        }

    }
}
