using ECmmerce.Data.Infrasctructure;
using ECmmerce.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Service
{
    class ProduitService
    {
        static IDatabaseFactory dbFact = new DatabaseFactory();
       IUnitOfWork utOfW = new UnitOfWork(dbFact);


       public List<product> displayAllProducts()
       {

           return utOfW.ProductRepository.GetAll().ToList();
       }

    }
}
