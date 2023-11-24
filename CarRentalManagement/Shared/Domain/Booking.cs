namespace CarRentalManagement.Shared.Domain
{
    public class Booking : BaseDomainModel
    {
        public DateTime DataOut { get; set; }
        public DateTime DateIn { get; set; }
        public int VehicleId { get; set; }
        public virtual Vehicle? Vehicle { get; set; }
        public int CustomerID {  get; set; }
        public virtual Customer? Customer { get; set; }
    }
}