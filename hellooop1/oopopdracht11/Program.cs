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

            ziescherper_10.classes.Student[] students= new Student[] {student,student1};
            students[1].Naam = "petronella";
            Console.WriteLine(student1.Naam);
        }
    }
}