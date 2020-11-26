using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using Data;
namespace Controller
{
    public class TableController
    {
        #region singleton
        private static readonly TableController _instance = new TableController();
        public static TableController instance
        {
            get { return _instance; }
        }
        #endregion singleton

        public List<Table> list()
        {
            return TableData.instance.list();
        }

        public void insert(Table tab)
        {
            try
            {
                TableData.instance.insert(tab);
            }
            catch (Exception e)
            {
                throw e;

            }

        }
        public void edit(Table tab)
        {
            try
            {
                TableData.instance.edit(tab);
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
                TableData.instance.delete(id);
            }
            catch (Exception e)
            {
                throw e;

            }

        }
    }
}
