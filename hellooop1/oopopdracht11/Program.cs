using ziescherper_10.classes;
namespace ziescherper_11

{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hoofdstuk 11");
            ziescherper_10.classes.Student  student= new Student();
            ziescherper_10.classes.Student  student1= new Student("papaya");
            Console.WriteLine(student.Naam);
            Console.WriteLine(student1.Naam);

        }
    }
}