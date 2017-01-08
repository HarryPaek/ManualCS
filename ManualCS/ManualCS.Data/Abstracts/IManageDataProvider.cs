using ManualCS.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManualCS.Data.Abstracts
{
    public interface IManageDataProvider
    {
        IEnumerable<ManageCategory> GetList();
    }
}
