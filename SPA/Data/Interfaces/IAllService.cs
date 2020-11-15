using Microsoft.AspNetCore.SignalR;
using SPA.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPA.Data.Interfaces
{
    public interface IAllService
    {
        IEnumerable<Service> Services { get;  }
        IEnumerable<Service> getFavServices { get;}
        Service getObjectService(int serviceId);

    }
}
