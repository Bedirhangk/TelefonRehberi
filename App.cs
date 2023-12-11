using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;

namespace TelefonRehberi;

class App
{
    
    public void Run ()
    {
       Dictionary dictionary =new Dictionary();
        int choose;
        while(true)
        {
            Console.Clear();
            choose = Menu();
            switch (choose)
            {
                case 1:
                    dictionary.AddNumber();
                    break;
                case 2:
                    dictionary.RemoveNumber();
                    break;
                case 3:
                    dictionary.UpdateNumber();
                    break;
                case 4:
                    dictionary.ShowDictionary();
                    break;
                case 5:
                    dictionary.Search();
                    break;
                case 6:
                    Environment.Exit(0);
                    return;
            }
        }
    }

    int Menu()
    {
        int Chs=0;
        bool test=true;

        Console.WriteLine("****************** Welcome Your Phone Dictionary *********************");
        Console.WriteLine("----------------------------------------------------------------------");
        Console.WriteLine("Please choose what do you want");
        Console.WriteLine("------------------------------");
        Console.WriteLine("Press One (1) For Add New Person");
        Console.WriteLine("Press Two (2) For Delete Someone ( or your EX :D )");
        Console.WriteLine("Press Three (3) For Uptade Someone");
        Console.WriteLine("Press Four (4) For Show Your Phone Dictionary");
        Console.WriteLine("Press Five (5) For Search Someone (or your EX's number if you didn't delete :D)");
        Console.WriteLine("Press Six (6) For Exit");
        
        while(test)
        {
            try
        {
            Console.Write("Please Make Your Choose (Don't Forget Just Numbers :D): ");
            Chs=int.Parse(Console.ReadLine());
            if(Chs<1||Chs>6)
                Console.WriteLine("Ahhhh Dude it so simple. You need just press a key between 1 to 6. Okey? Now go and make your choose.");
            else
                test=false;
            
        }
        catch (System.Exception)
        {
            Console.WriteLine("I SAID JUST NUMBERS !!!!!!");
        }
        }

        return Chs;

    }

  

}