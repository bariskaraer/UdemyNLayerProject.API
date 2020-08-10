using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using UdemyProject.Core.Repositories;

namespace UdemyProject.Core.UnitOfWorks
{
    public interface IUnitOfWork
    {
        IProductRepository Products { get;  }
        ICategoryRespository Categories { get; }
        Task CommitAsync();
        void Commit();
    }
}
