using System;
using System.Collections.Generic;

namespace HotelBillingSystem
{
    interface IBill
    {
        double getCost();
    }

    class RoomCharge : IBill
    {
        private double cost;

        public RoomCharge(string roomType)
        {
            switch (roomType.ToLower())
            {
                case "standard": cost = 15000; break;
                case "double": cost = 22000; break;
                case "deluxe": cost = 30000; break;
                default: throw new Exception("Invalid room type");
            }

        }
        public double getCost() => cost;
    }

    abstract class Billingdecorator : IBill
    {
        private IBill tempBill;

        public Billingdecorator(IBill bill)
        {
            this.tempBill = bill;
        }
        public virtual double getCost()
        {
            return tempBill.getCost();
        }
    }

    class BarLoungeDecorator : Billingdecorator
    {
        public BarLoungeDecorator(IBill newbill) : base(newbill) { }

        public override double getCost()
        {
            return base.getCost()+2000;
        }

    }

}
