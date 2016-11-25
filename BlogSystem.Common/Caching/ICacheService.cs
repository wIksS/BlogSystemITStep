using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogSystem.Common.Caching
{
    public interface ICacheService
    {
        T Get<T>(string itemName, Func<T> getData, int durationInSeconds);
    }
}
