namespace Spisuknaslujiteli
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int broi = int.Parse(Console.ReadLine());
            List<employee> rab = new List<employee>();
            double min = double.MinValue;
            string poz = null;

            for (int i = 0; i < broi; i++)
            {
                string[] insert = Console.ReadLine().Split(' ');
                string name = insert[0];
                double zaplata = double.Parse(insert[1]);
                string dlujnost = insert[2];
                string otdel = insert[3];
                string poshta = insert[4];
                int age = int.Parse(insert[5]);

                employee rabotnik = new employee();
                rabotnik.name = name;
                rabotnik.zaplata = zaplata;
                rabotnik.dlujnost = dlujnost;
                rabotnik.otdel = otdel;
                rabotnik.poshta = poshta;
                rabotnik.age = age;

                rab.Add(rabotnik);
            }
            for (int i = 0; i < broi; i++)
            {
                if (rab[i].zaplata > min)
                {
                    min = rab[i].zaplata;
                    poz = rab[i].otdel;
                }
            }
            Console.WriteLine($"Highest Average Salary: {poz}");
            for (int i = 0; i < broi; i++)
            {
                if (rab[i].otdel == poz)
                {
                    if (rab[i].poshta == null)
                    {
                        if (rab[i].age == null)
                        {
                            Console.WriteLine($"{rab[i].name} {rab[i].zaplata:F2} {rab[i].dlujnost} n/a -1");
                        }
                        else
                        {
                            Console.WriteLine($"{rab[i].name} {rab[i].zaplata:F2} {rab[i].dlujnost} n/a {rab[i].age}");
                        }
                    }
                    else
                    {
                        if (rab[i].age == null)
                        {
                            Console.WriteLine($"{rab[i].name} {rab[i].zaplata:F2} {rab[i].dlujnost} {rab[i].poshta} -1");
                        }
                        else
                        {
                            Console.WriteLine($"{rab[i].name} {rab[i].zaplata:F2} {rab[i].dlujnost} {rab[i].poshta} {rab[i].age}");
                        }
                    }
                }
            }
        }
        public class employee
        {
            public string name { get; set; }
            public double zaplata { get; set; }
            public string dlujnost { get; set; }
            public string otdel { get; set; }
            public string poshta { get; set; }
            public int age { get; set; }
            public employee(string name, double zaplata, string dlunjnost, string otdel, string poshta, int age)
            {
                this.name = name;
                this.zaplata = zaplata;
                this.otdel = dlujnost;
                this.otdel = otdel;
                this.poshta = poshta;
                this.age = age;
            }

            public employee()
            {
            }
        }
    }
}
