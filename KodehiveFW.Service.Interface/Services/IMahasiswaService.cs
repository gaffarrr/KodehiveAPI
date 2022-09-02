using KodehiveFW.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodehiveFW.Service.Interface.Services
{
    public interface IMahasiswaService
    {
        public Task<bool> Create(Mahasiswa model);

        public Task<List<Mahasiswa>> GetAll();

        public Task<bool> Delete(Mahasiswa Id);
    }
}
