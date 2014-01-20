using AutoMapper;
using CSMS3.Application.DTO;
using CSMS3.ApplicationContract;
using CSMS3.Domain.Model;
using CSMS3.Domain.Repository;
using CSMS3.Domain.Service;
using CSMS3.Event.Bus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSMS3.Application.Implementation
{
    public class Service1Impl : ApplicationService, IService1
    {
        #region 私有成员
        private readonly IYongHuXXRepository yongHuXXRepository;
        private readonly IDomainService domainService;
        #endregion

        #region 构造函数
        /// <summary>
        /// 初始化一个<c>Service1Impl</c>类型的实例。
        /// </summary>
        /// <param name="context">用来初始化<c>Service1Impl</c>类型的仓储上下文实例。</param>
        /// <param name="yongHuXXRepository">“用户信息”仓储实例。</param>
        public Service1Impl(IRepositoryContext context,
            IYongHuXXRepository yongHuXXRepository,
            IDomainService domainService
            )
            :base(context)
        {
            this.yongHuXXRepository = yongHuXXRepository;
            this.domainService = domainService;
        }
        #endregion


        public YongHuXXDTO GetYongHuXXByCID(string cid)
        {

            var yongHuXX = yongHuXXRepository.GetYongHuXXByCID(cid);
            //Mapper.CreateMap<YongHuXX, YongHuXXDTO>();
            var yongHuXXDTO = Mapper.Map<YongHuXX, YongHuXXDTO>(yongHuXX);
            return yongHuXXDTO;
        }

        public bool AddYongHuXX(YongHuXXDTO dto) 
        {
            var yongHuXXDTO = Mapper.Map<YongHuXXDTO,YongHuXX>(dto);
            yongHuXXRepository.Add(yongHuXXDTO);
            //yongHuXXRepository.Context.Commit();

            bool b = Context.Committed;

            Context.Commit();
            return true;
        }

        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }
    }
}
