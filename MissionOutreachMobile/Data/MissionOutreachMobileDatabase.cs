using System;
using SQLite;
using MissionOutreachMobile.Models;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Diagnostics;

namespace MissionOutreachMobile.Data
{
    public class MissionOutreachMobileDatabase
    {
        readonly SQLiteAsyncConnection database;
        public MissionOutreachMobileDatabase(string dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<Customer>().Wait();
        }

        public Task<List<Customer>>GetCusomtersAsync() {
            return database.Table<Customer>().ToListAsync();
        }
        public Task<Customer> GetSpecificCustomersAsync(string QR) {
            return database.Table<Customer>().Where(i => i.QR == QR)
                           .FirstOrDefaultAsync();
        }

        public void RegisterCustomerAsync(Customer customer) {
            database.InsertAsync(customer);
            Debug.WriteLine($"Inserted {customer.Name}");
        }
        public async void ScanCustomerAsync(Customer customer) {
            Customer updateCustomer = await GetSpecificCustomersAsync(customer.QR);
            updateCustomer.Status = "In";
           await database.UpdateAsync(updateCustomer);
            Debug.WriteLine($"Updated {updateCustomer.Name} to  {updateCustomer.Status}");

        }

        //public List<Customer>GetAllAsync() {
        //    return database.Table<Customer>().ToListAsync();
        //}
    }
}
