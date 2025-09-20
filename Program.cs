using EntityFrameWork.Core.Context;

namespace EntityFrameWork.Core
{
    internal class Program
    {
        static void Main(string[] args)
        {
           //CompanyG01DbContext db = new CompanyG01DbContext();
           // try
           // {

           // }
           // finally
           // {
           //     db.Dispose();
           // }
           using CompanyG01DbContext context = new CompanyG01DbContext();
        }
    }
}
