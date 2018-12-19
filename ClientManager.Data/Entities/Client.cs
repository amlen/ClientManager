﻿using System;
using ClientManager.Data.Constants;

namespace ClientManager.Data.Entities
{
    public class Client : BaseEntity
    {
        public string Name { get; set; }
        public decimal AvailableMoney { get; set; }
        public GenderType? Gender { get; set; }

        public bool CheckCanBuy(decimal amount)
        {
            if (Gender == null)
            {
                throw new ApplicationException("Gender is null");
            }

            if ((Gender == GenderType.Male && amount <= AvailableMoney / 2) ||
                (Gender == GenderType.Female && amount <= AvailableMoney * Convert.ToDecimal(0.8)))
            {
                return true;
            }

            return false;
        }
    }
}