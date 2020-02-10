﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFinance.Data.Infrastructure
{
    public class DatabaseFactory : Disposable, IDatabaseFactory
    {
        private FinanceContext dataContext;
        public FinanceContext DataContext { get { return dataContext; } }

        public DatabaseFactory()
        {
            dataContext = new FinanceContext();
        }
        protected override void DisposeCore()
        {
            if (DataContext != null)
                DataContext.Dispose();
        }
      
    }

}
