using Final_project.DAL;
using Final_project.Models;
using Final_project.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_project.BL
{
    internal class ServiceSushi : IServiceSushiCrud<Sushi>
    {
        private readonly IMapper _mapper;
        private readonly Sushi _sushi;
        private readonly IRepositorySushi<Sushi> _repositorySushi;

        public ServiceSushi(IMapper mapper, Sushi sushi, IRepositorySushi<Sushi> repositorySushi)
        {
            _mapper = mapper;
            _sushi = sushi;
            _repositorySushi = repositorySushi;
        }

        public async Task<Sushi> Create(Sushi sushi)
        {
            throw new NotImplementedException();
        }

        public Task<Sushi> Delete(Sushi number)
        {
            throw new NotImplementedException();
        }

        public Task<Sushi> GetSushi(int number)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Sushi> GetSushiList()
        {
            throw new NotImplementedException();
        }

        public Task<Sushi> Save()
        {
            throw new NotImplementedException();
        }

        public Task<Sushi> Update(Sushi sushi1)
        {
            throw new NotImplementedException();
        }
    }
}
