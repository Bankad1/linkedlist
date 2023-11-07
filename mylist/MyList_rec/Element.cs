using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyList_rec
{
    internal class Element<T>
    {
        
        public T MyData { get; set; }
        public Element<T> next { get; set; }
        private Element()
        {

        }
        public Element(T data)
        {
            
           MyData = data;
        }
       
    }
}
