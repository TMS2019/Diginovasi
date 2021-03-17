using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASPCoreWithAngular.Models;
namespace ASPCoreWithAngular.Interfaces
{
    public interface ISales
    {
        IEnumerable<SalesItem> GetAllSales();
        int AddSales(SalesItem sales);
        int UpdateSales(SalesItem sales);
        SalesItem GetSalesData(int id);
        int DeleteSales(int id);
        List<UnitofMeasure> GetUom();
    }
}
