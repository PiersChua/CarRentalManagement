using System.ComponentModel.DataAnnotations;

namespace CarRentalManagement.Shared.Domain
{
    public class Customer:BaseDomainModel
    {
		[Required]
		[RegularExpression(@"^[STFGstfg]\d{7}[A-Za-z]", ErrorMessage = "Driving License must be alphanumeric.")]
        public string? DrivingLicense { get; set; }

        public string? Address { get; set; }
		[Required]
		[DataType(DataType.PhoneNumber)]
		[RegularExpression( @"(6|8|9)\d{7}", ErrorMessage = "Contact Number is not a valid number.")]
		public string? ContactNumber { get; set; }
		[Required]
		[DataType(DataType.EmailAddress)]
		[EmailAddress]
		public string? EmailAddress { get; set; }

        public List<Booking>? Bookings { get; set; }
		[Required]
		[StringLength(100, MinimumLength = 2, ErrorMessage = "First Name does not meet length requirements")]
		public string? FirstName { get; set; }
		[Required]
		[StringLength(100, MinimumLength =2, ErrorMessage = "Last Name does not meet length requirement.")]
		public string? LastName { get; set; }

    }

}