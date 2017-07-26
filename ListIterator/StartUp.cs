using System;
using System.Collections.Generic;
using System.Linq;

public class StartUp
{
    public static void Main()
    {
        List<string> createCommand = Console.ReadLine().Split().ToList();
        createCommand.Remove("Create");
        ListyIterator<string> myList = new ListyIterator<string>(createCommand);
        string command = Console.ReadLine();
        while (command!="END")
        {
            try
            {
                switch (command)
                {
                    case "Move":
                        Console.WriteLine(myList.Move());
                        break;
                    case "HasNext":
                        Console.WriteLine(myList.HasNext());
                        break;
                    case "Print":
                        myList.Print();
                        break;
                    case "PrintAll":
                        myList.PrintAll();
                        break;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
            command = Console.ReadLine();
        }
      

    }
}

