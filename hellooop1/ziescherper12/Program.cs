using ziescherper_10.classes;
namespace ziescherper_12
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("hoofdstuk12");
            Opdracht12_1();
            Opdracht12_2();
            Opdracht12_3();
            Queue<string> wachtrij = new Queue<string>();
            wachtrij.Enqueue("Ik stond hier eerste.");
            wachtrij.Enqueue("Ik tweedes.");
            wachtrij.Enqueue("Ik laatste.");

            Console.WriteLine(wachtrij.Dequeue());
            Console.WriteLine(wachtrij.Dequeue());
            Console.WriteLine(wachtrij.Dequeue());

            Stack<string> stapel = new Stack<string>();
            stapel.Push("Ik was eerste hier.");
            stapel.Push("Ik tweede.");
            stapel.Push("Ik als laatste.");

            Console.WriteLine(stapel.Pop());
            Console.WriteLine(stapel.Pop());

        }
        private static void Opdracht12_1()
        {
            Console.WriteLine("12.1");

            Student student = new Student();

            Student student1 = new Student("papaya");
            Console.WriteLine(student.Naam);
            Console.WriteLine(student1.Naam);

            Student[] students = new Student[] { student, student1 };
            students[1].Naam = "petronella";
            Console.WriteLine(student1.Naam);
        }

        private static void Opdracht12_2()
        {
            List<int> alleGetallen = new List<int>();
            alleGetallen.Add(69);
            alleGetallen.Add(420);
            List<bool> binaryList = new List<bool>();
            binaryList.Add(true);
            binaryList.Add(false);
            List<Student> pokeDex = new List<Student>();
            Student pikachu = new Student("pikachu");

            pokeDex.Add(pikachu);
            Student charmander = new Student("charmander");
            pokeDex.Add(charmander);
            List<string[]> listOfStringarrays = new List<string[]>();


            for (int i = 0; i < pokeDex.Count; i++)
            {
                Console.WriteLine(pokeDex[i].Naam);
                Console.WriteLine(pokeDex[i].geboortejaar);

            }
            for (int i = 0; i < alleGetallen.Count; i++)
            {
                Console.WriteLine(alleGetallen[i]);
            }
            for (int i = 0; i < binaryList.Count; i++)
            {
                Console.WriteLine(binaryList[i]);
            }
        }

        private static void Opdracht12_3()
        {
            double[] killDeathRates = { 1, 0.89, 3.15, 0.1 };
            foreach (double singleKD in killDeathRates)
            {
                Console.WriteLine(singleKD);
            }
            Student timmy = new Student();
            timmy.Naam = "tim";
            Student tommy = new Student();
            tommy.Naam = "tom";
            Student[] deklas = new Student[] { timmy, tommy };

            foreach (var eenStudent in deklas)
            {
                Console.WriteLine($"{eenStudent.Naam}, {eenStudent.geboortejaar}");
            }
        }
            
    }
}