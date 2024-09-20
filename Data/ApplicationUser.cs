using Microsoft.AspNetCore.Identity;

namespace BlazorApp1.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        // Custom profile properties
        //public string? FirstName { get; set; }
        //public string? LastName { get; set; }
        //public DateTime? DateOfBirth { get; set; }
        //public string? ProfilePictureUrl { get; set; }

        // Optionally, you can also add address-related information
        //public string? Address { get; set; }
        //public string? City { get; set; }
        //public string? State { get; set; }
        //public string? PostalCode { get; set; }
    }
}
