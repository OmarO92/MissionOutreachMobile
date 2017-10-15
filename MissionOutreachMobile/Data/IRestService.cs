using System;
using System.Threading.Tasks;
using MissionOutreachMobile.Models;
using System.Collections.Generic;
namespace MissionOutreachMobile.Data
{
    public interface IRestService
    {
        Task<List<RestCustomers>> GetAllCustomersAsync();
    }
}
