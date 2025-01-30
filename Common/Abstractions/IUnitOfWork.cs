using System;

namespace Behnammby.Common.Abstractions
{
    public interface IUnitOfWork : IDisposable
    {
        int Complete();
    }
}