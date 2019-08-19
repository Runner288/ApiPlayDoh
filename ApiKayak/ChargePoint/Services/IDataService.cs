using ChargePoint.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChargePoint.Services
{
    public interface IDataService
    {
        List<EV> Get();

        EV GetById(int id);
    }
}
