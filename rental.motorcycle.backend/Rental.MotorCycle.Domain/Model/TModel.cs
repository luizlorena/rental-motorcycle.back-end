namespace Rental.MotorCycle.Domain.Entity
{
    public abstract class TModel
    {
        public required Guid Id { get; set; }
        public required DateTime DateRecord { get; set; }
        public required bool Active { get; set; }
    }
}
