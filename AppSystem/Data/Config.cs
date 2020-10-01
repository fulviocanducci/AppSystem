namespace AppSystem.Data
{
    public static class Config
    {
        public static string ConnectionString { get; private set; }
        static Config()
        {
            ConnectionString =
                System
                .Configuration
                .ConfigurationManager
                .ConnectionStrings["ConnectionTestDataBase"]
                .ConnectionString;
        }
    }
}
