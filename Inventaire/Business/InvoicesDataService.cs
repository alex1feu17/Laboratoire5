using BillingManagement.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BillingManagement.Business
{
    public class InvoicesDataService : IDataService<Models.Invoice>
    {
        List<Models.Invoice> _invoices;
        IEnumerable<Models.Customer> _customers;
        private IEnumerable<UI.Models.Customer> customerData;

        public InvoicesDataService(IEnumerable<Models.Customer> customers)
        {
            _invoices = new List<Models.Invoice>();
            _customers = customers;

            initValues();
        }

        public InvoicesDataService(IEnumerable<UI.Models.Customer> customerData)
        {
            this.customerData = customerData;
        }

        private void initValues()
        {
            Random rnd = new Random();


            foreach (var customer in _customers)
            {
                int nbInvoices = rnd.Next(0,10);

                for (int i = 0; i < nbInvoices; i++)
                {
                    var invoice = new Models.Invoice(customer);
                    invoice.SubTotal = rnd.NextDouble() * 100 + 50;

                    customer.Invoices.Add(invoice);
                    _invoices.Add(invoice);
                }
            }
        }

        public IEnumerable<Models.Invoice> GetAll()
        {
            foreach (var item in _invoices) {
                yield return item;
            }

        }
    }
}
