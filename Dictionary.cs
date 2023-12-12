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
        Console.Clear();
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
        bool dng=true,find;
        
        while(dng)
        {   
            find=false;

            Console.Clear();
            Console.WriteLine("********************Remove Number**************************");
            Console.Write("Enter the name or surname of the person you want to delete: ");
            name=Console.ReadLine().ToLower();
        
            for(int i=0;i<People.Count;i++)
            {
                if(People[i].Name.ToLower()==name)
                {
                    find=true;
                    Console.Write("Do you want delete {0} user (y/n): ",name);
                    rspnd=Console.ReadLine();
                    if(rspnd=="y"|| rspnd=="Y")
                    {
                        Console.WriteLine("The Contact is deleted.");
                        indx=People.IndexOf(People[i]);
                        People.Remove(People[indx]);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Contact is not deleted");
                    }

                }
            }

            if(find==false)
                Console.WriteLine("Contact is not founded");
            
            Console.WriteLine();
            
            while(true)
            {
                try
                {
                    Console.Write("Do you want countiune ? Press One for yes or press Two for no: ");
                    chs=int.Parse(Console.ReadLine());
                    if(chs<3 && chs>0)
                        break;
                    else
                        Console.WriteLine("PLSSSS just press one or two");
                }
                catch
                {
                    Console.WriteLine("Bro We already talk about that plss just number!");
                }
            }

            if(chs==2)
                dng=false;
                
        }
        

    }

    public void UpdateNumber() //This Method is have two part because this way easier to read.
    {
        string? name,rspnd;
        int indx,chs; 
        bool dng=true,find;
        
        while(dng)
        {   
            find=false;

            Console.Clear();
            Console.WriteLine("********************Update Number**************************");
            Console.Write("Enter the name or surname of the person you want to Update: ");
            name=Console.ReadLine().ToLower();
        
            for(int i=0;i<People.Count;i++)
            {
                if(People[i].Name.ToLower()==name)
                {
                    find=true;
                    Console.Write("Do you want Update {0} user's Number (y/n): ",name);
                    rspnd=Console.ReadLine();
                    if(rspnd=="y"|| rspnd=="Y")
                    {
                        indx=People.IndexOf(People[i]);
                        UpdateNumberCountiune(indx);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Contact is not updated");
                    }

                }
            }

            if(find==false)
                Console.WriteLine("Contact is not founded");
            
            Console.WriteLine();
            
            while(true)
            {
                try
                {
                    Console.Write("Do you want countiune ? Press One for yes or press Two for no: ");
                    chs=int.Parse(Console.ReadLine());
                    if(chs<3 && chs>0)
                        break;
                    else
                        Console.WriteLine("PLSSSS just press one or two");
                }
                catch
                {
                    Console.WriteLine("Bro We already talk about that plss just number!");
                }
            }
            
            if(chs==2)
                dng=false;
                
        }
    }

    public void UpdateNumberCountiune(int index)
    {
        int chs;
        while(true)
        {   
            try
            {
                Console.Clear();
                Console.WriteLine("Press one to Update Name");
                Console.WriteLine("Press two to Update Surname");
                Console.WriteLine("Press three to Update Number");
                chs=int.Parse(Console.ReadLine());
                if(chs<4 && chs >0)
                    break;
                else
                    Console.WriteLine("range!!!! pls read correctly ");
                
            }
            catch (System.Exception)
            {
                Console.WriteLine("Look are you blind it's not so hard");
                Console.WriteLine();
            }
        }
        
        Console.Clear();

        switch (chs)
        {
            case 1:
                Console.Write("New Name: ");
                People[index].Name=Console.ReadLine();
                break;
            case 2:
                Console.Write("New Surname: ");
                People[index].Surname=Console.ReadLine();
                break;
            case 3:
                Console.Write("New Number: ");
                People[index].Number=Console.ReadLine();
                break;
        }
    }

    public void ShowDictionary()
    {
        Console.Clear();
        Console.WriteLine("---------------------Your Dictionary--------------------");
        Console.WriteLine();
        Console.WriteLine("Press One (1) for sort A-Z");
        Console.WriteLine("Press Two (2) for sort Z-A");
        Console.Write("Make Your Choose: ");
        int b=int.Parse(Console.ReadLine());

        Console.Clear();

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
        int chs,indx;
        string search;
        bool find=false,dng=true;

        while(dng)
        {
            Console.Clear();
            Console.WriteLine("*****************************Search Contact********************************");

            while(true)
            {
                try
                {
                    Console.WriteLine("-Press one to search contact with Name or Surname");
                    Console.WriteLine("-Press two to search contact with Number");
                    chs=int.Parse(Console.ReadLine());
                    if(chs == 2 || chs == 1)
                        break;
                    else
                        Console.WriteLine("R-A-N-G-E * I-S * B-E-T-W-E-E-N * 1 * T-O * 2. Are you get it !");

                }
                catch (System.Exception)
                {
                    Console.WriteLine("I AM DONE!!!");
                }
            }

            Console.Clear();

            switch (chs)
            {
                case 1:
                    Console.Write("Name or Surname: ");
                    search=Console.ReadLine().ToLower();
                    for(int i=0;i<People.Count;i++)
                    {
                        if(People[i].Name.ToLower()==search || People[i].Surname.ToLower()==search )
                        {
                            find=true;
                            indx=People.IndexOf(People[i]);
                            Console.WriteLine("------------------------------------------");
                            Console.WriteLine("Name     : "+People[indx].Name);
                            Console.WriteLine("Surname  : "+ People[indx].Surname);
                            Console.WriteLine("Number   : "+People[indx].Number);
                            Console.WriteLine("------------------------------------------");
                        }                
                    }
                    if (!find)
                    {
                        Console.WriteLine("Contact is not founded.");
                    }
                    break;
                case 2:
                    Console.Write("Number: ");
                    search=Console.ReadLine().ToLower();
                    for(int i=0;i<People.Count;i++)
                    {
                        if(People[i].Number.ToLower()==search)
                        {
                            find=true;
                            indx=People.IndexOf(People[i]);
                            Console.WriteLine("------------------------------------------");
                            Console.WriteLine("Name     : "+People[indx].Name);
                            Console.WriteLine("Surname  : "+ People[indx].Surname);
                            Console.WriteLine("Number   : "+People[indx].Number);
                            Console.WriteLine("------------------------------------------");
                        }                
                    }
                    if (find)
                    {
                        Console.WriteLine("Contact is not founded.");
                    }
                    break;
            }

            while(true)
            {
                try
                {
                    Console.Write("Do you want countiune ? Press One for yes or press Two for no: ");
                    chs=int.Parse(Console.ReadLine());
                    if(chs<3 && chs>0)
                        break;
                    else
                        Console.WriteLine("PLSSSS just press one or two");
                }
                catch
                {
                    Console.WriteLine("Bro We already talk about that plss just number!");
                }
            }
            
            if(chs==2)
                dng=false;

        }

    }
}