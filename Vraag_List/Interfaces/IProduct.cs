using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vraag_List.Interfaces
{
    public interface IProduct
    {
         string Merk { get; set; }
         string Naam { get; set; }
         string Volume { get; set; }
         decimal Price { get; set; }
         string GetCode();
    }
}
