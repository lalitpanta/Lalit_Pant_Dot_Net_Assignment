namespace Lalit_Pant_Dot_Net_Assignment.Models
{
    public class DonationRequest
    {
        public int Id { get; set; }
        public string PatientName { get; set; }
        public string BloodTypeRequired { get; set; }
        public int Quantity { get; set; }
        public DateTime RequestDate { get; set; }
    }
}
