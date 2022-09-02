using Dapper;
using KodehiveFW.Model.Entities;
using KodehiveFW.Service.Interface.Services;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using NPOI.SS.Formula.Functions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodehiveFW.Service.Services
{
    public class DBService : IDBService
    {
        private readonly IDbConnection _db;

        public DBService(IConfiguration configuration)
        {
            _db = new MySqlConnection(configuration.GetConnectionString("ConnectKampus12a"));
        }


        public async Task<int> ModifyData(string command, object param)
        {
            var result = await _db.ExecuteAsync(command, param);
            return result;
        }

        public async Task<List<T>> GetData<T>(string command, object param)
        {
            List<T> result = (await _db.QueryAsync<T>(command, param)).ToList();
            return result;
        }

        public async Task<int> DeleteData(string command, object param)
        {
            var result = await _db.ExecuteAsync(command, param);
            return result;
        }
    }
}
