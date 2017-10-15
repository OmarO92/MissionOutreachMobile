using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MissionOutreachMobile.Models;
namespace MissionOutreachMobile.Data
{
    public class RestServiceManager
    {
        IRestService restService;

        public RestServiceManager(IRestService service)
        {
            restService = service;
        }
        public Task<List<RestCustomers>>GetAllCustomersAsync(){
            return restService.GetAllCustomersAsync();
        }
    }
}
