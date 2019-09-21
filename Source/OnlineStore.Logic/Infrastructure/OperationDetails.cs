using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.Logic.Infrastructure
{
    public class OperationDetails
    {
        public bool Succedeed { get; set; }
        public string Message { get; set; }
        public string Property { get; set; }

        public OperationDetails(bool succedeed)
        {
            Succedeed = succedeed;
        }
    }
}
