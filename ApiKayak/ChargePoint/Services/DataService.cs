using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChargePoint.Models;

namespace ChargePoint.Services
{
    public class DataService : IDataService
    {
        private readonly List<EV> lstEV = new List<EV>();

        public DataService()
        {
            EV ev1 = new EV();
            ev1.Id = 1;
            ev1.Maker = Maker.Tesla;
            ev1.Model = "Model 3";
            ev1.BatterySize = 4000;
            lstEV.Add(ev1);

            EV ev2 = new EV();
            ev2.Id = 2;
            ev2.Maker = Maker.Nissan;
            ev2.Model = "Leaf";
            ev2.BatterySize = 2500;
            lstEV.Add(ev2);

            EV ev3 = new EV();
            ev3.Id = 3;
            ev3.Maker = Maker.GM;
            ev3.Model = "EV1";
            ev3.BatterySize = 3000;
            lstEV.Add(ev3);

        }


        public List<EV> Get()
        {
            if (lstEV.Count > 0)
            {
                return lstEV;
            }
            else
            {
                return null;
            }
        }

        public EV GetById(int id)
        {
            foreach(EV ev in lstEV)
            {
                if(ev.Id == id)
                {
                    return ev;
                }
            }

            return null;
        }
    }
}
