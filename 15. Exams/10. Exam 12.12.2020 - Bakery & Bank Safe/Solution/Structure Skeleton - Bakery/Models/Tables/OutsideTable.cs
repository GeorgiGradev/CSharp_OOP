﻿namespace Bakery.Models.Tables
{
    public class OutsideTable : Table
    {
        private const decimal InitialPricePerPerson = 3.5m;

        public OutsideTable(int tableNumber, int capacity)
            : base(tableNumber, capacity, InitialPricePerPerson)
        {}

        public override decimal GetBill()
        {
            return base.GetBill() + this.NumberOfPeople * InitialPricePerPerson;
        }
    }
}
