using Rental.MotorCycle.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rental.MotorCycle.Domain.Security
{
    public class ProfileUser : TModel
    {
        public required string ProfileName { get; set; }
    }
}
