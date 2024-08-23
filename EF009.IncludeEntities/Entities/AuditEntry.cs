using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF009.IncludeEntities.Entities
{
    class AuditEntry
    {
        public int Id { get; set; }  
        public string Name { get; set; }
        public string Action { get; set; }
    }
}
