using Microsoft.EntityFrameworkCore;

namespace testscaffold
{
    class Program
    {
        static void Main(string[] args)
        {
            //dotnet ef dbcontext scaffold -o Models -d "sqlConnectstring" "Microsoft.EntityFrameworkCore.SqlServer" 
            //dotnet ef dbcontext scaffold -o Models -d "Data Source=localhost,1433;Initial Catalog=xtlab;User ID=SA;Password=Password123" "Microsoft.EntityFrameworkCore.SqlServer"
            //dotnet ef dbcontext scaffold -o Models - d "Data Source=localhost,1433;Initial Catalog=xtlab;User ID=SA;Password=Password123;TrustServerCertificate=True" "Microsoft.EntityFrameworkCore.SqlServer"


        }
    }
}
