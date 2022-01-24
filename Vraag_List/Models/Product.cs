using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vraag_List.Interfaces;

namespace Vraag_List.Models
{
    public class Product : IProduct,IComparable<Product>
    {
        public string Merk { get ; set; }
        public string Naam { get ; set ; }
        public string Volume { get ; set ; }
        public decimal Price {get ; set; }

        public int CompareTo(Product x, Product y)
        {
            return x.Price.CompareTo(y.Price);
        }

        public int CompareTo(Product other)
        {
            throw new NotImplementedException();
        }

        public string GetCode()
        {
           var resultAll = new List<Product>();
            
            for (int i = 0; i < resultAll.Count; i++)
            {
                string merk = resultAll[i].Merk.Length > 3 ? resultAll[i].Naam.Substring(0, 3).ToUpper() : resultAll[i].Naam.Substring(0, 2).ToUpper() + "_";
                string naam = resultAll[i].Naam.Length > 3 ? resultAll[i].Naam.Substring(0, 3).ToUpper() : resultAll[i].Naam.Substring(0, 2).ToUpper() + "_";
                string volume = resultAll[i].Volume;
                string merknaamvolume = merk + naam + volume;
                
                var product = new Product()
                {
                    Merk = merk,
                    Naam = naam,
                    Volume = volume,
                };
                resultAll.Add(product);              
            }
           return resultAll.ToString();
        }
       
    }
}
