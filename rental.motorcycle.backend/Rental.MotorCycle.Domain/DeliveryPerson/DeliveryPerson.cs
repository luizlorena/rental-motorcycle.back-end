using Rental.MotorCycle.Domain.Entity;


namespace Rental.MotorCycle.Domain.DeliveryPerson
{
    public class DeliveryPerson : TModel
    {
        public required string Name { get; set; }
        public required string CompanyCode { get; set; }
        public required DateTime DateBirth { get; set; }
        public required string DriverLicenseNumber { get; set; }
        public required CategoryDriverLicenseEnum CategoryDriverLicense { get; set; }
        public string? PictureDriverLicense { get; set; }
    }

    public enum CategoryDriverLicenseEnum
    {
        A,
        B,
        AB
    }
}
