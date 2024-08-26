using Rental.MotorCycle.Domain.Interface.IRepository;
using Rental.MotorCycle.Domain.Motorcycle;

namespace Rental.MotorCycle.Repository
{
    public class MotorCycleRepository : IMotorcycleRepository
    {
        private bool disposedValue;

        public void Add(MotorcycleModel entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(MotorcycleModel entity)
        {
            throw new NotImplementedException();
        }

        public MotorcycleModel Get(int id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<MotorcycleModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(MotorcycleModel entity)
        {
            throw new NotImplementedException();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects)
                }

                // TODO: free unmanaged resources (unmanaged objects) and override finalizer
                // TODO: set large fields to null
                disposedValue = true;
            }
        }

        // // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
        // ~MotorCycleRepository()
        // {
        //     // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        //     Dispose(disposing: false);
        // }

        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
