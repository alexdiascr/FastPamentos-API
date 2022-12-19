using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastPagamentos.Business.Models
{
    public class seller_info : Entity
    {
        public Guid checkout_id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string CPF { get; set; }

        /* EF Relations */
        public IEnumerable<Checkout> Checkouts { get; set; }
    }
}
