using System;
using System.Collections;
using System.Collections.Generic;
public class ListyIterator<T>:IEnumerable<T>
{
    public List<T> Elements { get; set; }
    public int Index { get; set; }
    public ListyIterator(List<T> elements)
    {
        this.Elements = elements;
        this.Index = 0;
    }

    public bool Move()
    {
        if (this.Index + 1 >= this.Elements.Count)
        {
            return false;
        }
        this.Index++;
        return true;
    }

    public bool HasNext()
    {
        if (this.Index==this.Elements.Count-1)
        {
            return false;
        }
        return true;
    }

    public void Print()
    {
        if (this.Elements.Count==0)
        {
            throw new ArgumentException("Invalid Operation!");
        }
        Console.WriteLine(this.Elements[this.Index]);
    }

    public void PrintAll()
    {
        Console.WriteLine(string.Join(" ",this.Elements));
    }
    public IEnumerator<T> GetEnumerator()
    {
        for (int i = 0; i < this.Elements.Count; i++)
        {
            yield return this.Elements[i];
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}

