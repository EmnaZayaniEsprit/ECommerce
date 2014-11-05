using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECmmerce.Data.Infrasctructure
{
    public interface IUnitOfWork : IDisposable
    { 
        void Commit();
      //  IProviderRepository ProviderRepository { get; }
        //ICategoryRepository CategoryRepository { get;}
        //IProductRepository ProductRepository { get; }
    }
}
