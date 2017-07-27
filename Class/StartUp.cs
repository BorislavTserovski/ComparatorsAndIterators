using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
   public class StartUp
    {
        static void Main()
        {
            string input = Console.ReadLine();
            Stack <string>myStack = new Stack <string>();
            while (input!="END")
            {
                string[] args = input.Split(new []{',',' '},StringSplitOptions.RemoveEmptyEntries);
                try
                {
                    switch (args[0])
                    {
                        case "Push":
                            for (int i = 1; i < args.Length; i++)
                            {
                                myStack.Push(args[i]);
                            }
                            break;
                        case "Pop":
                            myStack.Pop();
                            break;

                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

                input = Console.ReadLine();
            }
            if (myStack.Elements.Count > 0)
            {
                for (int i = myStack.Elements.Count - 1; i >=0; i--)
                {
                    Console.WriteLine(myStack.Elements[i]);
                }
                for (int i = myStack.Elements.Count - 1; i >= 0; i--)
                {
                    Console.WriteLine(myStack.Elements[i]);
                }
            }
          
           
        }
    }
}
