using ECmmerce.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECmmerce.Data.Infrasctructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private ecommerceContext dataContext;
        IDatabaseFactory dbFactory;
        public UnitOfWork(IDatabaseFactory dbFactory)
        {
            this.dbFactory = dbFactory;
        }

        //private IProviderRepository providerRepository;
        /*public IProviderRepository ProviderRepository
         * {
         * get 
         * { return providerRepository = new ProviderRepository(dbFactory); }
         * } */

        //private ICategoryRepository categoryRepository;
        /*public ICategoryRepository CategoryRepository 
         * { get { 
         * return categoryRepository = new CategoryRepository(dbFactory); }
         * } */

        protected ecommerceContext DataContext
        {
            get
            {
                return dataContext = dbFactory.DataContext;
            }
        }

        public void Commit() { DataContext.SaveChanges(); }
        public void Dispose() { dbFactory.Dispose(); }
    }

}
