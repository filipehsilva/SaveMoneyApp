using SaveMoneyApp.Business.Enums;

namespace SaveMoneyApp.Business.Entities
{
    public class Transaction : Entity
    {
        public TransactionTypes Type { get; set; }
        public TransactionStatus Status { get; set; }
        public string DocumentNumber { get; set; }
        public Guid UserId { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public DateTime Date { get; set; }
        public DateTime PaymentDate { get; set; }
        public DateTime DueDate { get; set; }
        public Guid PaymentMethodId { get; set; }
        public Guid ContactId { get; set; }
        public Guid CategoryId { get; set; }
        public TransactionOccurrenceTypes Occurrence { get; set; }
        public Guid BankAccountId { get; set; }

        /* EF Relations */
        public BankAccount BankAccount { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public Category Category { get; set; }
        public Contact Contact { get; set; }
    }
}
