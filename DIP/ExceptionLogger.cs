using System;

namespace BreakingDependencyInversionPrinciple
{
    public abstract class ExceptionLogger : ILogExceptions
    {
        public void Log(Exception ex)
        {
            //Log the important details of the exception somewhere useful.
        }
    }
}