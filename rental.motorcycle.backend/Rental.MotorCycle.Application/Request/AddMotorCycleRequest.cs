using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rental.MotorCycle.Application.Request
{
    public class AddMotorCycleRequest
    {
        public required Guid Id { get; set; }
        public required string Plate { get; set; }
        public required string Year { get; set; }
        public required string Model { get; set; }
    }
}
