using EFTuts.Modules.Users.Services;
using System.Security;
using System.Windows;

namespace EFTuts.Modules.Users.Views
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window, ISecurePassword
    {
        public Login()
        {
            InitializeComponent();
        }

        public SecureString SecuredPassword
        {
            get
            {
                return UserPassword.SecurePassword;
            }
        }
    }
}
