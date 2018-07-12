using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BL.Kitchen
{
    public class ManagerStatusOrder
    {
        public void RunAutomaticState(int onTime, int AbTime, int Delayed)
        {
            ManagerOrder manager = new ManagerOrder();
            
            //Thread hilo = new Thread(new ThreadStart(manager.AutomaticState(onTime, AbTime, Delayed, manager.ListOrders())));
            //hilo.Start();
        }

        public void AuState(int onTime, int AbTime, int Delayed)
        {
            ManagerOrder manager = new ManagerOrder();
            manager.AutomaticState(onTime, AbTime, Delayed, manager.ListOrders());

        }
    }
}
