using CSMS3.Domain.Model;
using System.Linq;

namespace CSMS3.Domain.Repository.EntityFramework
{
    /// <summary>
    /// 表示Product仓储的一个具体实现。
    /// </summary>
    public class YongHuXXRepository : EntityFrameworkRepository<YongHuXX>, IYongHuXXRepository
    {
        #region 构造函数
        public YongHuXXRepository(IRepositoryContext context) : base(context) { }
        #endregion

        #region IYongHuXXRepository 成员
        /// <summary>
        /// 根据账号获取用户信息
        /// </summary>
        /// <param name="cid">账号</param>
        /// <returns>用户信息列表</returns>
        public YongHuXX GetYongHuXXByCID(string cid) 
        {
            var ctx = this.EFContext.Context as CSMS3DbContext;
            if (ctx != null)
            {
                var query = from p in ctx.YongHuXXs
                            where p.S_CID == cid
                            select p;

                return query.SingleOrDefault();
            }
            return null;
        }
        #endregion
    }
}
