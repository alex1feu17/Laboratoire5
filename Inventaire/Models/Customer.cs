using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace BillingManagement.UI.Models
{
    public class Customer
    {
        
        public int CustomerID { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string PostalCode { get; set; }
        public string PicturePath { get; set; }
        public string ContactInfo { get; set; }

        public ObservableCollection<ContactInfo> contactInfos = new ObservableCollection<ContactInfo>();
        public ObservableCollection<Invoice> invoices = new ObservableCollection<Invoice>();
        public ObservableCollection<ContactInfo> ContactInfos
        {
            get => contactInfos;
            set
            {
                contactInfos = value;
                OnPropertyChanged();
            }
        }

        public ObservableCollection<Invoice> Invoices
        {
            get => invoices;
            set
            {
                invoices = value;
                OnPropertyChanged();
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName]string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
