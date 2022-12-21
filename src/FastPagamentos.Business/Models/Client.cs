namespace FastPagamentos.Business.Models
{
    public class Client : Entity
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string CPF { get; set; }
        public string Conta { get; set; }
        public string Banco { get; set; }

        /* EF Relations */
        public IEnumerable<Checkout> Checkouts { get; set; }
    }
}
