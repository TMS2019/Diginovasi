using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASPCoreWithAngular.Models;
namespace ASPCoreWithAngular.Interfaces
{
  public  interface IUom
    {
        IEnumerable<UnitofMeasure> GetAllUom();
        int AddUom(UnitofMeasure uom);
        int UpdateCustomer(UnitofMeasure uom);
        UnitofMeasure GetUomData(int id);
        int DeleteUom(int id);
        List<SalesItem> GetSalesItem();
    }
}
