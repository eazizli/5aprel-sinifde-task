using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6AprelWorkTask
{
    internal class Book
    {
        private static int _id;
         public  int Id { get; set; }  
        public string Name { get; set; }
        public string AuthorName { get; set; }  
        public int PageCount { get; set; }
        public double Price { get; set; }
        public string Code;

        public Book(string name)
        {
            _id++;
            Id = _id;
            Name = name;
            AuthorName = AuthorName;
            PageCount = PageCount;
            Price = Price;
            string[] names=Name.Split(' ');
            foreach(string n in names)
            {
                Code += n[0];
            }
            Code += Id;
            Code.ToUpper();
        }
    }
}
