using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Services.Exeptions
{
    public class DbUpdatConcurrencyException : ApplicationException
    {
        public DbUpdatConcurrencyException(string message) : base(message)
        {

        }
    }
}
