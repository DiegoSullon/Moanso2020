using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using Data;
namespace Controller
{
    class OrderController
    {
        #region singleton
        private static readonly OrderController _instance = new OrderController();
        public static OrderController instance
        {
            get { return _instance; }
        }
        #endregion singleton

        public List<Order> list()
        {
            return OrderData.instance.list();
        }

        public void insert(Order ord)
        {
            try
            {
                OrderData.instance.insert(ord);
            }
            catch (Exception e)
            {
                throw e;

            }

        }
        public void delete(int id)
        {
            try
            {
                OrderData.instance.delete(id);
            }
            catch (Exception e)
            {
                throw e;

            }

        }
    }
}
