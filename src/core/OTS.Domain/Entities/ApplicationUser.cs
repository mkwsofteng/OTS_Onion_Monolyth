using Microsoft.AspNetCore.Identity;

namespace OTS.Domain.Entities
{
    public class ApplicationUser : IdentityUser
    {

        //Navigation Properties
        public IEnumerable<Booking> Bookings { get; set; } = Enumerable.Empty<Booking>();
    }
}
