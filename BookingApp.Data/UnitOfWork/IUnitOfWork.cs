using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingApp.Data.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        // Kaç kayda etki ettiğini geriye döner, o yüzden int ve async olduğu için Task.
        Task<int> SaveChangesAsync();

        // Task asenkron metotların void'i gibi düşünülebilir.
        Task BeginTransaction();
        Task CommitTransaction();
        Task RollBackTransaction();
    }
}
