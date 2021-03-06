﻿using Creekdream.Dependency;

namespace Creekdream.Uow
{
    /// <summary>
    /// Unit of work management service interface
    /// </summary>
    public interface IUnitOfWorkManager : ITransientDependency
    {
        /// <summary>
        /// Open a unit of work
        /// </summary>
        IUnitOfWorkCompleteHandle Begin(UnitOfWorkOptions options = null);
    }
}

