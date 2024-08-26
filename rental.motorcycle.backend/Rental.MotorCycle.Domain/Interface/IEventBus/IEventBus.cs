using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rental.MotorCycle.Domain.Interface.IEventBus
{
    public interface IEventBus
    {
        void SendProductMessage<T>(T message);
    }
}
