using System.Security;

namespace EFTuts.Modules.Users.Services
{
    public interface ISecurePassword
    {
        SecureString SecuredPassword { get; }
    }
}