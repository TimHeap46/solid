using System;
using System.IO;

namespace BreakingSingleResponsibility
{
    public static class GlobalErrorHandler
    {
        public static void HandleError(Exception ex)
        {
           File.WriteAllText(@"C:\Error.txt", ex.ToString());
        }
    }
}