using Business_Logic.Interfaces.IServices;
using Business_Logic.Services;
using Data_Access_Layer.Repositories;

namespace Desktop_Application
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            // Application.Run(new LoginForm());
            UserRepository userRepository = new UserRepository();
            UserService userService = new UserService(userRepository);
            IUserAuthenticationService authenticationService = new UserAuthenticationService(userService);
            Application.Run(new LoginForm(authenticationService));
        }
    }
}