﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFinance.Data.Infrastructure
{
    public interface IUnitOfWork : IDisposable
    {
        void Commit();
        RepositoryBase<T> getRepository<T>() where T : class;
    }

}
