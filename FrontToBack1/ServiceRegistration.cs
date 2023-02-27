using FrontToBack1.DAL;

namespace FrontToBack1
{
    public static class ServiceRegistration
    {
        public static void FrontToBackServiceRegistration(this IServiceCollection services)
        {
            services.AddControllersWithViews();
           
        }
    }
}
