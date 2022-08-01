using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApplication
{
    public class Category
    {
        int catId;
        string catDesc;

       
        public Category(int id, string desc)
        {
            catId = id;
            catDesc = desc;
        }

        public int CatId { get => catId; set => catId = value; }
        public string CatDesc { get => catDesc; set => catDesc = value; }
    }
}
