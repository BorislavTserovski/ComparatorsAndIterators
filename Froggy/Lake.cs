using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Froggy
{
    public class Lake:IEnumerable<int>
    {
        public List<int> Stones { get; set; }

        public Lake(List<int>stones)
        {
            this.Stones = stones;
        }

        public IEnumerator<int> GetEnumerator()
        {
            
            for (int i = 0; i <= this.Stones.Count-1; i+=2)
            {
                yield return this.Stones[i];
            }
            if (this.Stones.Count % 2 == 0)
            {
                for (int i = this.Stones.Count - 1; i >= 1; i -= 2)
                {
                    yield return this.Stones[i];
                }
            }
            else
            {
                for (int i = this.Stones.Count-2; i >= 1; i-=2)
                {
                    yield return this.Stones[i];
                }
            }

           
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
