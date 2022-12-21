using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastPagamentos.Business.Models
{
    public class Checkout : Entity
    {
        public Guid buyer_info_id { get; set; }
        public Guid seller_info_id { get; set; }
        public Guid credid_card_info_id { get; set; }
        public bool is_payment_done { get; set; }

        /* EF Relations */
        public IEnumerable<payment_order> payment_orders { get; set; }
        public Client buyer_info { get; set; }
        public seller_info seller_info { get; set; }
        public Card credid_card_info { get; set; }
    }
}
