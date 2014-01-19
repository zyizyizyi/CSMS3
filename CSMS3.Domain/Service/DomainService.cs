using CSMS3.Domain.Model;
using CSMS3.Domain.Repository;
using CSMS3.Domain.Specification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSMS3.Domain.Service
{
    /// <summary>
    /// 表示用于Byteart Retail领域模型中的领域服务类型。
    /// </summary>
    public class DomainService : IDomainService
    {
        #region Private Fields
        private readonly IRepositoryContext repositoryContext;
        private readonly IYongHuXXRepository yongHuXXRepository;
        #endregion

        #region Ctor
        /// <summary>
        /// 初始化一个新的<c>DomainService</c>类型的实例。
        /// </summary>
        /// <param name="repositoryContext">仓储上下文。</param>
        /// <param name="productRepository">用户仓储。</param>

        public DomainService(IRepositoryContext repositoryContext,
            IYongHuXXRepository yongHuXXRepository)
        {
            this.repositoryContext = repositoryContext;
            this.yongHuXXRepository = yongHuXXRepository;
        }
        #endregion

        #region IDomainService Members
        /// <summary>
        /// 修改站点
        /// </summary>
        /// <param name="yongHuXX">用户信息</param>
        /// <returns>修改过的站点</returns>
        public YongHuXX XiuGaiST(YongHuXX yongHuXX)
        {
            if (yongHuXX == null)
                throw new ArgumentNullException("yongHuXX");

            var yongHu = yongHuXXRepository.Find(Specification<YongHuXX>.Eval(c => c.S_CID == "2"));
            yongHu.S_ST = "43";
            yongHuXXRepository.Update(yongHu);
            repositoryContext.Commit();
            return yongHu;
        }
        #endregion
    }
}
