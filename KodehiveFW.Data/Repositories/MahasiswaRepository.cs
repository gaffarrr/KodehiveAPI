using KodehiveFW.Data.Interface.Repositories;
using KodehiveFW.Model.Entities;
using KodehiveFW.Service.Interface.Services;
using KodehiveFW.Service.Services;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodehiveFW.Data.Repositories
{
    public class MahasiswaRepository : IMahasiswaRepository
    {
        private readonly IDBService _dbService;
        private object id;

        public MahasiswaRepository(IDBService dbService)
        {
            _dbService = dbService;
        }
        
        public async Task<bool> Create(Mahasiswa model)
        {
            await _dbService.ModifyData("INSERT INTO mahasiswa (id,nama,alamat,usia, jurusan_id)" +
                "VALUES" +
                "(@Id, @Nama, @Alamat, @Usia, @JurusanId)", model);
            return true;
        }

        public async Task<bool> Delete(Mahasiswa Id)
        {
            await _dbService.DeleteData("DELETE FROM mahasiswa WHERE @Id = Id", Id);
            return true;
        }

        public async Task<List<Mahasiswa>> GetAll()
        {
            var result = await _dbService.GetData<Mahasiswa>("SELECT * FROM mahasiswa", new { });
            return result;
        }

    }
}
