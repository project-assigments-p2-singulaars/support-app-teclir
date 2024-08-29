using Microsoft.AspNetCore.Identity;
namespace support_app.Errors;
public class CustomErrors : IdentityErrorDescriber
{
    public virtual IdentityError InvaliEmail(string email)
    {
        return new IdentityError
        {
            Code = nameof(InvaliEmail),
            Description = $"The email {email} is not correct. Please introduce a valid email."
        };
    }
}