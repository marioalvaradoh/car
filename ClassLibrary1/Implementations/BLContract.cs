using AutoMapper;
using COMMON.Contracts;
using COMMON.DomainModels;
using COMMON.DTO;
using DATA.Contracts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LOGIC.Implementations
{
    public class BLContract : IBLContract
    {
        private readonly IPracticeContextUnitOfWork practiceContextUnitOfWork;
        private readonly IMapper mapper;

        public BLContract(IPracticeContextUnitOfWork practiceContextUnitOfWork,
            IMapper mapper)
        {
            this.practiceContextUnitOfWork = practiceContextUnitOfWork;
            this.mapper = mapper;
        }


        public async Task<DTOResponse> Create(DTORequest request)
        {
            Car entity = this.mapper.Map<Car>(request);
            await practiceContextUnitOfWork.Car.AddAsync(entity);
            await this.practiceContextUnitOfWork.SaveChangesAsync();
            return this.mapper.Map<DTOResponse>(entity);
        }
    }
}
