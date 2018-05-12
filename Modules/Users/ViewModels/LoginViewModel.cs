using System;
using System.Runtime.InteropServices;
using System.Security;
using EFTuts.Modules.Users.Services;
using Prism.Commands;
using Prism.Mvvm;

namespace EFTuts.Modules.Users.ViewModels
{
    public class LoginViewModel : BindableBase
    {
        public DelegateCommand<object> LoginCommand { get; set; }

        private string _username;
        public string UserName
        {
            get { return _username; }
            set { SetProperty(ref _username, value); }
        }

        private string _unSecuredPassword;
        public string UnSecuredPassword
        {
            get { return _unSecuredPassword; }
            set { SetProperty(ref _unSecuredPassword, value); }
        }

        private string _message;
        public string Message
        {
            get { return _message; }
            set { SetProperty(ref _message, value); }
        }

        public LoginViewModel()
        {
            LoginCommand = new DelegateCommand<object>(Login, CanLogin)
                                                                       .ObservesProperty(() => UserName)
                                                                       .ObservesProperty(() => UnSecuredPassword);
        }

        private bool CanLogin(object SecuredParameter)
        {
            return !String.IsNullOrWhiteSpace(UserName) && SecuredParameter != null;
        }

        private void Login(object SecuredParameter)
        {
            var passwordContainer = SecuredParameter as ISecurePassword;
            if (passwordContainer != null)
            {
                var secureString = passwordContainer.SecuredPassword;
                UnSecuredPassword = ConvertToUnsecureString(secureString);
            }

            if (UserName == "a" && UnSecuredPassword == "b")
            {
                Message = "Welcome..! Your Password is : " + UnSecuredPassword;
                UnSecuredPassword = null;
            }
            else
            {
                Message = "Oops! Try Again";
            }
        }

        private string ConvertToUnsecureString(SecureString securePassword)
        {
            if (securePassword == null)
            {
                return string.Empty;
            }

            IntPtr unmanagedString = IntPtr.Zero;
            try
            {
                unmanagedString = Marshal.SecureStringToGlobalAllocUnicode(securePassword);
                return Marshal.PtrToStringUni(unmanagedString);
            }
            finally
            {
                Marshal.ZeroFreeGlobalAllocUnicode(unmanagedString);
            }
        }       
    }
}
