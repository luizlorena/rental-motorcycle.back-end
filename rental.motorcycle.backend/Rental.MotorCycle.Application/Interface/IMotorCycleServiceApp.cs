using Rental.MotorCycle.Application.Request;
using Rental.MotorCycle.Application.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rental.MotorCycle.Application.Interface
{
    public interface IMotorCycleServiceApp
    {
        Guid AddMotorcycle(AddMotorCycleRequest request);
        void RemoveMotorcycle(Guid id);
        IEnumerable<MotorcycleViewModel> GetAll(string plate);
    }
}
