using BillingManagement.Business;
using BillingManagement.UI.Business;
using BillingManagement.UI.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace BillingManagement.UI.ViewModels
{
	class InvoiceViewModel : BaseViewModel
	{
		private Invoice selectedInvoice;
		private ObservableCollection<Invoice> invoices;
		CustomerContext db = new CustomerContext();
		public ObservableCollection<Invoice> Allinvoices;
		public InvoiceViewModel(IEnumerable<Customer> customerData)
		{
			InvoicesDataService ids = new InvoicesDataService(customerData);
			Invoices = new ObservableCollection<Invoice>(ids.GetAll().ToList());

		}

		public Invoice SelectedInvoice
		{
			get { return selectedInvoice; }
			set { 
				selectedInvoice = value;
				OnPropertyChanged();
			}
		}

		public ObservableCollection<Invoice> Invoices { 
			get => invoices;
			set { 
				invoices = value;
				OnPropertyChanged();
			}
		}

	}
}
