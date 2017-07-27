using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    public class Stack<T>: IEnumerable<T>
    {
        public List<T> Elements { get; set; }

        public Stack()
        {
            this.Elements = new List<T>();
        }
        public void Push(T element)
        {
            this.Elements.Add(element);
        }

        public void Pop()
        {
            if (this.Elements.Count==0)
            {
                throw new ArgumentException("No elements");
            }
            this.Elements.RemoveAt(this.Elements.Count-1);
        }
        public IEnumerator<T> GetEnumerator()
        {
            for (int i = this.Elements.Count-1; i > 0; i--)
            {
                yield return this.Elements[i];
            }
        }
        
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
