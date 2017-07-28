using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Froggy
{
   public class StartUp
    {
       public static void Main()
       {
            List<int> input = Console.ReadLine().Split(new[] {',', ' '}, StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse).ToList();
            Lake lake = new Lake(input);

           Console.WriteLine(string.Join(", ",lake));

       }
    }
}
