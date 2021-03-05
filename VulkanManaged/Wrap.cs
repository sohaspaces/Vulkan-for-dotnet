using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VulkanManaged
{
    /// <summary>
    /// Wraps Vulkan unmanaged and reusable structs
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract record Wrap<T>
        where T : struct
    {
        public Wrap(T x)
        {

        }

        public abstract T Unwrap();
    }
}
