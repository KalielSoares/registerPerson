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

        Console.WriteLine("Vamos cadastrar uma pessoa?");
        string answer = Console.ReadLine();

        while (answer != "n")
        {
            Console.WriteLine("Qual o nome dessa pessoa?");
            string Name = Console.ReadLine();
            Console.WriteLine("e qual seria a sua idade?");
            int Age = int.Parse(Console.ReadLine());
            Console.WriteLine("ela trabalha com o que?");
            string Profission = Console.ReadLine();
            Console.WriteLine("e o genero dela?");
            char Gender = char.Parse(Console.ReadLine());

            people.Add(new person { name = Name, age = Age, profission = Profission, gender = Gender });

            Console.WriteLine("Vamos cadastrar uma nova pessoa?");
            answer = Console.ReadLine();
        }



        foreach (person Person in people)
        {
            Console.WriteLine($" A pessoa cadastrada se chama: {Person.name},{Person.age},{Person.profission},{Person.gender}");
        }
    }
}