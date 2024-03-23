using ListOfEmployees__BLL.Contracts;
using ListOfEmployees__BLL.Services;


namespace ListOfEmployees
{
    public static class Startup
    {
        internal static void AddServices(WebApplicationBuilder builder)
        {
            RegisterDAL(builder);
        }
        public static void RegisterDAL(WebApplicationBuilder builder)
        {
            if (builder.Environment.IsDevelopment()==true )
                builder.Services.AddSingleton<IEmployeesService, EmployeeService>( );
            else
                builder.Services.AddSingleton<IEmployeesService, StubEmployeeService>();

        }

    }
}
