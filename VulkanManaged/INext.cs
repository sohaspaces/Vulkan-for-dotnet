using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vulkan.Structs;

namespace VulkanManaged
{
    /// <summary>
    /// Provides the pointer for <c>Next</c> property (equivalent of <c>pNext</c> field), which is in most of ~<c>CreateInfo</c> structs, and is supposed to be pointing an extended ~<c>CreateInfo</c> struct.
    /// </summary>
    /// <typeparam name="TAbout">Where an <see cref="INext{TAbout}"/> chain will be attached to. (e.g. <see cref="VkInstanceCreateInfo"/>)</typeparam>
    public interface INext<TAbout>
    {
        /// <summary>
        /// Provides the pointer for <c>Next</c> property as the next is <paramref name="next"/> so that chain becomes:
        /// <para>(return value) -> struct with <c>Next</c>=<paramref name="next"/> -> another ~<c>CreateInfo</c> struct</para>
        /// </summary>
        /// <param name="next">The pointer for the next ~<c>CreateInfo</c>. If it doesn't exist, this can be null</param>
        /// <returns>A valid ~<c>CreateInfo</c></returns>
        public unsafe void* MakeChain(void* next);
    }

    public static class NextExtensions
    {
        /// <summary>
        /// Makes <see cref="INext{TAbout}"/> chain.
        /// The root will be provided by the first instance of <paramref name="objects"/>
        /// </summary>
        /// <param name="objects">Chain components without null instances</param>
        /// <returns>A chain</returns>
        public static unsafe void* MakeChain<TAbout>(this IEnumerable<INext<TAbout>> objects)
        {
            var array = objects.ToArray();
            var length = array.Length;
            void* result = array.Length > 0 ? array[0].MakeChain(null) : null;
            for (int i = 1; i < length; i++)
                result = array[i].MakeChain(result);
            return result;
        }
    }
}
