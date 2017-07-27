using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Library : IEnumerable<Book>
{
    public Library(params Book[] books)
    {
        this.books = new SortedSet<Book>(books, new BookComparator());
    }
    private SortedSet<Book> books { get; set; }

    public IEnumerator<Book> GetEnumerator()
    {
        return new LibraryIterator(this.books);
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
   private class LibraryIterator:IEnumerator<Book>
   {
       public int CurrentIndex { get; set; }
       public List<Book> Books { get; set; }

       public LibraryIterator(IEnumerable<Book>books)
       {
           this.Reset();
           this.Books = new List<Book>(books);
       }

     
       
       public void Dispose()
       {
           
       }

       public bool MoveNext()
       =>++this.CurrentIndex < this.Books.Count;

       public void Reset()
       {
           this.CurrentIndex = -1;
       }

       public Book Current => this.Books[this.CurrentIndex];

       object IEnumerator.Current
       {
           get { return Current; }
       }
   }
}

