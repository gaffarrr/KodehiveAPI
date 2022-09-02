using KodehiveFW.Data.Interface.Repositories;
using KodehiveFW.Model.Entities;
using KodehiveFW.Service.Interface.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodehiveFW.Service
{
    public class MahasiswaService : IMahasiswaService
    {
        private readonly IMahasiswaRepository mahasiswaRepository;
        public MahasiswaService(IMahasiswaRepository mahasiswaRepository)
        {
            this.mahasiswaRepository = mahasiswaRepository;
        }
        public async Task<bool> Create(Mahasiswa model)
        {
            var result = await mahasiswaRepository.Create(model);
            return true;
        }

        public async Task<bool> Delete(Mahasiswa Id)
        {
            var result = await mahasiswaRepository.Delete(Id);
            return result;
        }

        public async Task<List<Mahasiswa>> GetAll()
        {
            var result = await mahasiswaRepository.GetAll();
            return result;
        }

        
    }
}
