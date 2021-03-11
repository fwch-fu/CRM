using System;
using System.Collections.Generic;
using System.Text;

namespace CRM.Model.Entities.IBaseEntities
{
    public interface IDeleted
    {
        bool Deleted { set; get; }
    }
}
