using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;

namespace BillingManagement.UI.Models
{
    public class Invoice
    {
        public int InvoiceID { get; set; }
        public object InvoiceId { get; }
        public DateTime CreationDateTime { get; private set; }
        private double SubTotal { get; set; }

        private Customer _customer;
        private int nextId;

        public Customer Customer
        {
            get { return _customer; }
            set
            {
                _customer = value;
                OnPropertyChanged();
            }
        }
        public Invoice()
        {
            // Incremente le ID
            InvoiceId = Interlocked.Increment(ref nextId);

            CreationDateTime = DateTime.Now;
        }

        public Invoice(Customer customer)
        {
            // Incremente le ID
            InvoiceId = Interlocked.Increment(ref nextId);

            CreationDateTime = DateTime.Now;
            Customer = customer;
        }
        public double FedTax => SubTotal * 0.05;
        public double ProvTax => SubTotal * 0.09975;

        public double Total => SubTotal + FedTax + ProvTax;

        public string Info => $"{CreationDateTime} : {Total:C2}";
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName]string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
