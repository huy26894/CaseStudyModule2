using QLCafe.Domain.Response;
using System;
using System.Collections.Generic;
using System.Text;
using QLCafe.Domain.Request;

namespace QLCafe.DAL.Interface
{
    public interface IUnitRepository
    {
        bool UnitAdd(UnitAdd request);
        bool UnitUpdate(UnitUpdate request);
        bool UnitDelete(int id);
        IList<UnitView> UnitGetAll();
        Unit UnitGetById(int id);

    }
}
