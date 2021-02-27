using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vulkan
{
    public interface INext<TAbout>
    {
        public unsafe void* MakeChain(void* next);
    }
    public static class ExtensionObjectExtensions
    {
        public static unsafe void* MakeChain<TAbout>(this IEnumerable<INext<TAbout>> objects)
        {
            var array = objects.ToArray();
            var length = array.Length;
            void* result = array[0].MakeChain(null);
            for (int i = 1; i < length; i++)
                result = array[i].MakeChain(result);
            return result;
        }
    }
}
