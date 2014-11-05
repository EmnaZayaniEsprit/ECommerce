﻿using ECmmerce.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECmmerce.Data.Infrastructure
{
    public class PromotionRepository : RepositoryBase<promotion>,IPromotionRepository
    {
                public PromotionRepository(IDatabaseFactory dbFactory)
            : base(dbFactory)
        {
        }

    }
        public interface IPromotionRepository :IRepository <promotion> {}
}
