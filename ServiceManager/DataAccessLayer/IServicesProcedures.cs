using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceManager.DataAccessLogic
{
    public interface IServicesProcedures
    {
        void SelectAllServices();

        void InsertServiceinformation(Serviceinformation serviceinformation);
    }
}
