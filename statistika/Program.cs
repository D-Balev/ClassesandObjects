using System.Runtime.CompilerServices;
using static statistika.Program;
using System.Xml.Linq;

namespace statistika
{
    internal class Program
    {
        public class person
        {
            public int age;
            public string name;
        }
        static void Main(string[] args)
        {
            int broi = int.Parse(Console.ReadLine());
            List<person> people = new List<person>();
            for (int i = 0; i < broi; i++)
            {
                string name = Console.ReadLine();
                int age = int.Parse(Console.ReadLine());

                person person = new person();
                person.name = name;
                person.age = age;

                people.Add(person);
            }
            for (int i = 0;i < people.Count;i++)
            {
                if (people[i].age > 30)
                {
                    Console.WriteLine($"{people[i].name} - {people[i].age}");
                }
            }
        }
    }
}
