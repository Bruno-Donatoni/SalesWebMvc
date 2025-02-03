using Microsoft.EntityFrameworkCore.SqlServer.Query.Internal;

namespace SalesWebMvc.Services.Exceptions
{
    public class IntegrityException : ApplicationException
    {

        public IntegrityException(string message) : base(message) { }
    }
}
