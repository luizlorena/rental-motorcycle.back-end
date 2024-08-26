using Rental.MotorCycle.Application.Interface;
using Rental.MotorCycle.Application.Request;
using Rental.MotorCycle.Application.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rental.MotorCycle.Application.ServiceApp
{
    public class MotorCycleServiceApp : IMotorCycleServiceApp
    {
        public void AddMotorcycle(AddMotorCycleRequest request)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<MotorcycleViewModel> GetAll(string plate)
        {
            throw new NotImplementedException();
        }

        public void RemoveMotorcycle(Guid id)
        {
            throw new NotImplementedException();
        }

        Guid IMotorCycleServiceApp.AddMotorcycle(AddMotorCycleRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
