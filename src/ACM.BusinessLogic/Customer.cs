﻿namespace ACM.BusinessLogic
{
    using Acme.Common.Contracts;
    using System.Collections.Generic;
    public class Customer : EntityBase, ILoggable
    {
        private string _lastName;

        public Customer()
            : this(0)
        {

        }

        public Customer(int custoremId)
        {
            CustomerId = custoremId;
            AddressList = new List<Address>();
        }

        public int CustomerId { get; private set; }
        public string FirstName { get; set; }
        public string EmailAddress { get; set; }
        public static int InstanceCount { get; set; }
        public List<Address> AddressList { get; set; }
        public int CystomerType { get; set; }

        public string FullName
        {
            get
            {
                var fullfName = LastName;
                if (!string.IsNullOrWhiteSpace(FirstName))
                {
                    if (!string.IsNullOrWhiteSpace(fullfName))
                    {
                        fullfName += ", ";
                    }
                    fullfName += FirstName;
                }

                return fullfName;
            }
        }
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }
        public string Log() =>
      $"{CustomerId}: {FullName} Email: {EmailAddress} Status: {EntityState.ToString()}";

        public override bool Validate()
        {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(LastName))
            {
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(EmailAddress))
            {
                isValid = false;
            }

            return isValid;
        }

        public override string ToString() => FullName;
    }
}
