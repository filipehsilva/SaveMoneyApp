﻿namespace SaveMoneyApp.Business.Entities
{
    public class PaymentMethod : Entity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Active { get; set; }
        public Guid UserId { get; set; }

        /* EF Relations */
        public List<Transaction> Transactions { get; set; }
    }
}
