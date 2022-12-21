namespace FastPagamentos.Business.Models
{
    public class payment_order : Entity
    {
        public Guid checkout_id { get; set; }
        public Guid client_id { get; set; }
        public string amount { get; set; }
        public string currency { get; set; }
        public payment_order_status payment_order_status { get; set; }
        public bool ledger_updated { get; set; }
        public bool wallet_updated { get; set; }

        /* EF Relations */
        public Checkout checkout { get; set; }
        public Client buyer_info { get; set; }
    }
}
