//////////////////////////
/// ALPHA VARSION "ROGUE-PROTOCOL v1.0"
//////////////////////////




using System.Linq;
using System.Xml;
using System.Threading;
using System.Net.NetworkInformation;

List<string> Commands = new List<string>() { "search %IP%", "connect to %IP%",  "start %GIVE ADMIN.exe%", "start %HACK.exe%", "start %GOOGLE.exe%", "check %EMAIL%" };
List<string> IPs = new List<string>() { "FredsFries", "JeliesJackleShackles", "NeliesNukeShop", "TheNesis" };




Console.WriteLine("If you are new to the game type 'help'. If you don't want the tutorial type no.\t");

int money = 0;
Random random = new Random();

int FBIchance = 0;
FBIchance += random.Next(1, 3);

void CommandSys()
{



    if (FBIchance > 9)
    {
        FbiSys();
    }
    else
    {
        while (true)
        {






            Console.WriteLine("> ");
            string Command = Console.ReadLine();

            if (Command == "help")
            {
                Console.WriteLine(string.Join(", ", Commands));


                CommandSys();
            }

            else if (Command == "no")
            {

                CommandSys();

            }
            else if (Commands.Contains(Command))
            {
                if (Command == Commands[0])
                {
                    Console.WriteLine(IPs[0]);
                    Console.WriteLine(IPs[1]);
                    Console.WriteLine(IPs[2]);
                    CommandSys();
                }
                else if (Command == Commands[1])
                {
                    Console.WriteLine("%Enter IP name%> ");
                    string IPname = Console.ReadLine();
                    if (IPs.Contains(IPname))
                    {
                        if (IPs[3] == IPname)
                        {
                            Console.WriteLine(IPname + "> ");
                            string IpArg = Console.ReadLine();
                            if (IpArg == Commands[3])
                            {
                                Console.WriteLine("They are above you.");
                                FBIchance = 10;
                            }
                            else if (IpArg == Commands[5])
                            {
                                Console.WriteLine("Rogue-Protocol_Main/10100 10111");
                            }
                        }
                            Console.WriteLine(IPname + "> ");
                            string IParg = Console.ReadLine();
                            if (IParg == Commands[3])
                            {

                                FBIchance += random.Next(1, 3);

                                money += random.Next(3, 20);
                                Console.WriteLine("you have" + " " + "$" + money);
                                FBIchance += random.Next(1, 3);
                                CommandSys();

                            }
                            else if (IParg == Commands[5])
                            {
                                Console.WriteLine("");
                            }

                    }

                }

                else
                {
                    Console.WriteLine("Invalid Command.");
                }

            }
        }

    }
}
bool FBIsaid = false;
int HideCount = 0;

CommandSys();


void FbiSys()
{
    
    
    

    if (FBIsaid == true)
    {
        string Command = Console.ReadLine();



        if (HideCount > 3)
        {
            Console.WriteLine("You did it and you hid from the FBI.");
            FBIchance = 0;
            HideCount = 0;
            CommandSys();


        }

        if (Command == "hide %IP%")
        {
            HideCount += 1;
            
            FbiSys();
        }
        else
        {
            Console.WriteLine("You failed you lost all of your money!");
            money = 0;
            HideCount = 0;
            FBIchance = 0;
            FBIsaid = false;
        }
        

    }
    else
    {
        Console.WriteLine("The FBI is comming for you. You must write 'hide %IP%' 5 times to hide from them.");
        FBIsaid = true;
        HideCount = 0;
        
        FbiSys();

        
    }

    


    
    
    
}


void Invalid()
{
    Console.WriteLine("Invalid Command");
}