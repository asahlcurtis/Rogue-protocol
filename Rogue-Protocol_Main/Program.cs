using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.IO;

List<string> Commands = new List<string>() { "search %IP%", "connect to %IP%", "start %GIVE ADMIN.exe%", "start %HACK.exe%", "start %GOOGLE.exe%", "check %EMAIL%", "exit" };
List<string> IPs = new List<string>() { "FredsFries", "JeliesJackleShackles", "NeliesNukeShop", "TheNesis", "NarbacularDrop" };
List<string> emails = new List<string>() {
    "Hey this is Tery Smith, I need you to get some intel on this team well on the work of kim swi- I'll just give you the IP.",
    "Hello I'm Fred and well. I need money to start my food place, and I have everything I need, except well a little money, my friend Jelie said I could have some" +
    "of her money but we can't go to banks right now so can you help and get some of her money you can maybe keep some like around $10."
};


// error(1) means that the program couldn't find the IP or command.
List<string> errors = new List<string>() { "error(1)" };

int money = 0;
Random random = new Random();

int FBIchance = 0;
FBIchance += random.Next(1, 3);
bool FBIsaid = false;
int HideCount = 0;

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
            Console.WriteLine("You failed and lost all of your money!");
            money = 0;
            HideCount = 0;
            FBIchance = 0;
            FBIsaid = false;
        }
    }
    else
    {
        Console.WriteLine("The FBI is coming for you. You must write 'hide %IP%' 5 times to hide from them.");
        FBIsaid = true;
        HideCount = 0;
        FbiSys();
    }
}

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
            Console.Write("> ");
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
                    Console.WriteLine(string.Join(",\n", IPs));
                    CommandSys();
                }
                else if (Command == Commands[1])
                {
                    Console.Write("%Enter IP name%> ");
                    string IPname = Console.ReadLine();
                    if (IPs.Contains(IPname))
                    {
                        if (IPs[3] == IPname)
                        {
                            Console.WriteLine(IPname + "> ");
                            string IpArg = Console.ReadLine();
                            if (IpArg == Commands[3])
                            {
                                Console.WriteLine("HACK.EXE\n\nChoose operation ['hack', 'check email']");
                                string IParg2 = Console.ReadLine();
                                if (IParg2 == "hack")
                                {
                                    FBIchance = 10;
                                    Console.WriteLine("They are above you");
                                }
                                else if (IParg2 == "check email")
                                {
                                    Console.WriteLine("Rogue-protocol/Rogue-protocol_Main/10100 10111");
                                }
                            }
                            else
                            {
                                Console.WriteLine(IPname + "> ");
                                string IParg = Console.ReadLine();
                                if (IParg == Commands[3])
                                {
                                    Console.WriteLine("HACK.EXE\n\nChoose operation ['hack', 'check email']");
                                    string IParg2 = Console.ReadLine();
                                    if (IParg2 == "hack")
                                    {
                                        FBIchance += random.Next(1, 3);
                                        money += random.Next(3, 20);
                                        Console.WriteLine("You have $" + money);
                                        FBIchance += random.Next(1, 3);
                                        CommandSys();
                                    }
                                    else if (IParg2 == "check email")
                                    {
                                        Console.WriteLine("\n");
                                        Console.WriteLine(string.Join(" \n ,\n ", emails));
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Must open ['exe', 'dmg', 'dll' 'wad']");
                                    Invalid();
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine(IPname + "> ");
                            string IParg = Console.ReadLine();
                            if (IParg == Commands[3])
                            {
                                Console.WriteLine("HACK.EXE\n\nChoose operation ['hack', 'check email']");
                                string IParg2 = Console.ReadLine();
                                if (IParg2 == "hack")
                                {
                                    FBIchance += random.Next(1, 3);
                                    money += random.Next(3, 20);
                                    Console.WriteLine("You have $" + money);
                                    FBIchance += random.Next(1, 3);
                                    CommandSys();
                                }
                                else if (IParg2 == "check email")
                                {
                                    Console.WriteLine("\n");
                                    Console.WriteLine(string.Join(" \n ,\n ", emails));
                                }
                            }
                        }
                    }
                    else
                    {
                        Invalid();
                    }
                }
                else if (Command == Commands[5])
                {

                }
                else if (Command == Commands[6])
                {
                    Console.WriteLine("Exiting...");
                    Thread.Sleep(2000);
                    Console.WriteLine("Exited [||||]");
                    Exit();
                }
                else
                {
                    Invalid();
                }
            }
            else
            {
                Invalid();
            }
        }
    }

    void Invalid()
    {
        Console.WriteLine(errors[0] + " Couldn't find %IP% or command.");
    }

    void Exit()
    {
        // Save the variable 'money' to a file before exiting
        File.WriteAllText("money.txt", money.ToString());
        

        Console.WriteLine("Exited with code 0.");
        Environment.Exit(0);
    }
}

if (File.Exists("money.txt"))
{
    // Read the content of the file and parse it as integer
    string moneyData = File.ReadAllText("money.txt");
    if (int.TryParse(moneyData, out int moneyValue))
    {
        money = moneyValue;
    }
    else
    {
        // Invalid content in the file, set money to zero
        money = 0;
    }
}
else
{
    // File doesn't exist, set money to zero
    money = 0;
}

CommandSys();
