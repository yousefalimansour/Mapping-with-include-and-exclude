using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF009.ExcludeEntities.Entities
{
    public class SnapShot
    {
        public DateTime LoadAt => DateTime.UtcNow;
        public string Version => Guid
            .NewGuid().ToString().Substring(0, 8);
    }
}
