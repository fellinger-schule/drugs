namespace QTDrugPrescription.WebApi.Models.App
{
    public class PatientDTO
    {
        public string FirstName { get; set; } = default!;
        public string LastName { get; set; } = default!;
        public string SocialSecurityNumber { get; set; } = default!;
        public DateTime Birthday { get; set; } = default!;
    }
}
