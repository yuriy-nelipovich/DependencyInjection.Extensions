﻿using System.Collections.Generic;

namespace Neleus.DependencyInjection.Extensions
{
    /// <summary>
    /// Provides instances of registered services by name
    /// </summary>
    /// <typeparam name="TService"></typeparam>
    public interface IServiceByNameFactory<out TService>
    {
        /// <summary>
        /// Provides instance of registered service by name
        /// </summary>
        TService GetByName(string name);

        /// <summary>
        /// Gets names of all the registered instances of <typeparamref name="TService"/>
        /// </summary>
        /// <returns></returns>
        ICollection<string> GetNames();
    }
}