using KodehiveFW.Model.Entities;
using KodehiveFW.Service;
using KodehiveFW.Service.Interface.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KodehiveFW.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MahasiswaController : Controller
    {
        private readonly IMahasiswaService mahasiswaService;
        
        public MahasiswaController(IMahasiswaService mahasiswaService)
        {
            this.mahasiswaService = mahasiswaService;
        }

        [HttpPost]

        public async Task<IActionResult> Create([FromBody] Mahasiswa model)
        {
            var result = await mahasiswaService.Create(model);
            return Ok(result);
        }

        [HttpGet]
        public async Task<List<Mahasiswa>> GetAll()
        {
            var result = await mahasiswaService.GetAll();
            return result;
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(Mahasiswa Id)
        {
            var result = await mahasiswaService.Delete(Id);
            return Ok(result);
        }
    }
}
