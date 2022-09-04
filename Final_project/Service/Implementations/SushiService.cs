using Final_project.DAL.Interfaces;
using Final_project.Domain.Entity;
using Final_project.Domain.Respons;
using Final_project.Service.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace Final_project.Service.Implementations
//{
//    internal class SushiService : ISushiService
//    {
//        private readonly ISushiRepository _sushiRepository;
//        private readonly DbContext _context;

//        public SushiService()
//        {
//        }

//        public SushiService(ISushiRepository sushiRepository)
//        {
//            _sushiRepository = sushiRepository;
//        }
    
//        public async Task<IBaseResponse<IEnumerable<Sushi>>> GetSushi()
//        {
//            var baseResponse = new BaseResponse<IEnumerable<Sushi>>();
//            try
//            {
//                var sushies =  _sushiRepository.GetListAsync();

//                if (sushies == null)
//                {
//                    baseResponse.Discription = "Найдено 0 элементов";
//                    baseResponse.StatusCode = Domain.Enum.StatusCode.OK;
//                }

//                baseResponse.Date = (IEnumerable<Sushi>)sushies;
//                baseResponse.StatusCode = Domain.Enum.StatusCode.OK;

//                return baseResponse;
//            }
//            catch (Exception ex)
//            {
//                return new BaseResponse<IEnumerable<Sushi>>()
//                {
//                      Discription = $"[GetSushi] : {ex.Message}"
//                };
//            }

//        }
//    }
//}
