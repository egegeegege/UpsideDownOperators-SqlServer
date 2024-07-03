using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpsideDownOperators.Orm.Entity
{
    public class ExecutiveProperty : BaseEntity
    {
        public int YoneticiId { get; set; }
        List<UserProperty> UserPropertys = new List<UserProperty>();

    }
}
