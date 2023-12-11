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
        string? name,rspnd;
        int indx,chs; 
        bool dng=true;
        Console.WriteLine("********************Remove Number**************************");
        Console.Write("Enter the name or surname of the person you want to delete: ");
        name=Console.ReadLine();
        
        while(dng)
        {
            for(int i=0;i<People.Count;i++)
            {
                if(People[i].Name==name)
                {
                    Console.Write("Do you want delete {0} user (y/n): ",name);
                    rspnd=Console.ReadLine();
                    if(rspnd=="y"|| rspnd=="Y")
                    {
                        Console.WriteLine("The Contact is deleted.");
                        indx=People.IndexOf(People[i]);
                        People.Remove(People[indx]);
                        Break;
                    }
                    else
                    {
                        Console.WriteLine("Contact is not deleted");
                    }

                }
                 else
                 {
                    Console.WriteLine("The contact is not found.");
                    Console.WriteLine("Press one to contiune delete progress");
                    Console.WriteLine("Press two to retrun menu");
                    chs=int.Parse(Console.ReadLine());
                    if(chs==2)
                         dng=false;
                 }
            }

            Console.Write("Do you want countiune ? Press One for yes or press Two for no.");
            chs=int.Parse(Console.ReadLine());
            if(chs==2)
                 dng=false;
        }

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
