namespace FastPagamentos.Business.Models
{
    public class Card : Entity
    {
        public string holder_Name { get; set; }
        public string number { get; set; }
        public string expiration_date { get; set; }
        public int CVV { get; set; }

        /* EF Relations */
        public IEnumerable<Checkout> Checkouts { get; set; }
    }
}
