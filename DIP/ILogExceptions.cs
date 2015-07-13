using System;

namespace BreakingDependencyInversionPrinciple
{
    public interface ILogExceptions
    {
        void Log(Exception ex);

    }
}