namespace QLNongSan
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var sqlServerFactory = new Databases.SQLServerFactory(
                serverName: "localhost",
                databaseName: "QuanLyNongSan",
                userName: "sa",
                password: "123456"
            );
            var userRepository = new Authentication.Repositories.UserRepository
            {
                factory = sqlServerFactory,
            };
            var authenticationService = new Authentication.Services.AuthenticationService
            {
                userRepository = userRepository
            };
            var application = new Application
            {
                authenticationService = authenticationService
            };

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            System.Windows.Forms.Application.Run(new UI.LoginForm(application));
        }
    }
}