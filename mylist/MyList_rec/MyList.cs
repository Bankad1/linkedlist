using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyList_rec
{
    internal class MyList<T>
    {
        public Element<T> first;
        public void Insert(Element<T> dat)
        {
            if (first == null)
            {

                first = dat;
            }
            else 
            { 
            dat.next = first;
            first = dat;
            }
            

        }
        public void bejar(Element<T>current)
        {
            Console.WriteLine(current.MyData);
            if (current.next!=null)
            {
                bejar(current.next);
            }
             
        }
        public Element<T> Search(T value)
        {
            Element<T> current = first;
            while (current != null)
            {
                if (EqualityComparer<T>.Default.Equals(current.MyData, value))
                {
                    return current; 
                }
                current = current.next;
            }
            return null; 
        }
        public void Delete(T value)
        {
            Element<T> current = first;
            Element<T> previous = null;

            while (current != null)
            {
                if (EqualityComparer<T>.Default.Equals(current.MyData, value))
                {
                    
                    if (previous == null)
                    {
                        
                        first = current.next;
                    }
                    else
                    {
                        i
                        previous.next = current.next;
                    }
                    return; 
                }

                previous = current;
                current = current.next;
            }
        }
    }
}
