using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Xml.Linq;
public class person
{
    public required string name { get; set; }
    public required int age { get; set; }
    public required string profission { get; set; }
    public required char gender { get; set; }
}

class program
{
    static void Main()
    {
        //cria a lista
        List<person> people = new List<person>();

        do
        {

            Console.WriteLine("Vamos cadastrar uma pessoa?");
            string answer = Console.ReadLine();

            if (answer == "n")
            {
                break;
            }
            else
            {
                string Name = Console.ReadLine();
                int Age = int.Parse(Console.ReadLine());
                string Profission = Console.ReadLine();
                char Gender = char.Parse(Console.ReadLine());

                people.Add(new person { name = Name, age = Age, profission = Profission, gender = Gender });

            }

        }
        while (true);

        foreach (person Person in people)
        {
            Console.WriteLine($" A pessoa cadastrada se chama: {Person.name},{Person.age},{Person.profission},{Person.gender}");
        }
    }
}
