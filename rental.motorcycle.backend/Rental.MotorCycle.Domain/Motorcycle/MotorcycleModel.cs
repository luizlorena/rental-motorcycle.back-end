using Rental.MotorCycle.Domain.Entity;

namespace Rental.MotorCycle.Domain.Motorcycle
{
    public class MotorcycleModel : TModel
    {
        //[Index("ix_motorcycle_plate_unique", IsUnique = true)]
        public required string Plate { get; set; }
        public required string Year { get; set; }
        public required string Model { get; set; }
    }
}
