namespace Definirane
{
    internal class Program
    {
        static void Main(string[] args)
        {
            person Pesho = new person();
            person Gosho = new person();
            person Stamat = new person();

            Pesho.name = "Pesho";
            Gosho.name = "Gosho";
            Stamat.name = "Stamat";

            Pesho.age = 20;
            Gosho.age = 18;
            Stamat.age = 43;
        }
        public class person
        {
            public string name;
            public int age;
        }
    }
}
