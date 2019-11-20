using System;
using SingleResponsabilityExample.Context;

namespace SingleResponsabilityExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString="server=xxx;database=xx;user=xx;password=xx"; //ejemplo de conexion

            var userContext = new ContextUser(connectionString);
            
            userContext.getUsuarios();

        }
    }
}
