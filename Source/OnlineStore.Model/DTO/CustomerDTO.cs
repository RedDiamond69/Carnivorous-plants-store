using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.Model.DTO
{
    public class CustomerDTO
    {
        public string ApplicationUserId { get; set; }

        public virtual ICollection<DeliveryInformationDTO> DeliveryInformation { get; set; }
    }
}
