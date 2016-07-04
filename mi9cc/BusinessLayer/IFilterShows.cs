using mi9cc.Models;
using Mi9cc.JsonModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mi9cc.BusinessLayer
{
    public interface IFilterShows
    {
         List<response> ApplyFilter(PayLoadContainer container);
    }
}
