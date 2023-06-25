using UP.Models.Context;

namespace UP.Infrastructure
{
    public static class DataBaseConnection
    {
        public static ApplicationContext ApplicationContext { get; set; }

        static DataBaseConnection()
        {
            ApplicationContext = new ApplicationContext();
        }
    }
}
