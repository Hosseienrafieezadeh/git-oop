using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
   public  interface IBook
    {

        void AddBook(string name, int type, int count, int price,int ID);
        void RemoveBook(int BookID);
        void DisplayAllBook();


    }
}
