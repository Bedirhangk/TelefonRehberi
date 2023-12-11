namespace TelefonRehberi;

using System.Linq;

class Dictionary
{
     public List<Person> People = new List<Person>();
    
    public Dictionary()
    {
        People.Add(new Person("Bedirhan","Gökkaya","789746352"));
        People.Add(new Person("Selin","Gürtürk","9652023"));
        People.Add(new Person("Yasemin Sude","Aktaş","426521412"));
        People.Add(new Person("Büşra","Yön","652454615"));
        People.Add(new Person("Umut Yasin","Gürtürk","1111111111"));
    }
    
    public void AddNumber()
    { 
        string? addname,addsurname,addnumber;
        Console.WriteLine("***************Create New Contact****************");

        Console.Write("Name     :");
        addname=Console.ReadLine();
        Console.Write("Surname  :");
        addsurname=Console.ReadLine();
        Console.Write("Number   :");
        addnumber=Console.ReadLine();

        People.Add(new Person(addname, addsurname, addnumber));

        Console.WriteLine("New Contact is added. Please press any key to continue");
        Console.ReadKey();

    }

    public void RemoveNumber()
    {

    }

    public void UpdateNumber()
    {

    }

    public void ShowDictionary()
    {
        Console.WriteLine();
        Console.WriteLine("---------------------Your Dictionary--------------------");
        Console.WriteLine();
        Console.WriteLine("Press One (1) for sort A-Z");
        Console.WriteLine("Press Two (2) for sort Z-A");
        Console.Write("Make Your Choose: ");
        int b=int.Parse(Console.ReadLine());

        if(b==1)
            People = People.OrderBy(x => x.Name).ToList();
        else
        {
           People.Sort((x, y) => y.Name.CompareTo(x.Name));
        }

       foreach (Person a in People)
       {
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Name     : "+a.Name);
            Console.WriteLine("Surname  : "+ a.Surname);
            Console.WriteLine("Number   : "+a.Number);
            Console.WriteLine("------------------------------------------");
            Console.WriteLine();
       }

       Console.WriteLine("Your Dictionary is listed. Please press any key to continue.");
       Console.ReadKey();
    }
    public void Search ()
    {

    }
}