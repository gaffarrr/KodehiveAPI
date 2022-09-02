using KodehiveFW.Model.Entities;
using NPOI.SS.Formula.Functions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodehiveFW.Service.Interface.Services
{
    public interface IDBService
    {
        Task<int> ModifyData(string command, object param);
        Task<List<T>> GetData<T>(string command, object param);
        Task<int> DeleteData(string command, object param);
    }
}
