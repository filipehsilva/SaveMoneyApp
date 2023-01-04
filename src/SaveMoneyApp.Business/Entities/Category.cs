namespace SaveMoneyApp.Business.Entities
{
    public class Category : Entity
    {
        public string Name { get; set; }
        public string Colour { get; set; }
        public string Icon { get; set; }
        public bool Active { get; set; }
        public Guid UserId { get; set; }

        /* EF Relations */
        public List<Transaction> Transactions { get; set; }
    }
}
