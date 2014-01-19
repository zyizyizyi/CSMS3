using CSMS3.Domain.Model;

namespace CSMS3.Domain.Repository
{
    /// <summary>
    /// 表示用于“商品”聚合根的仓储接口。
    /// </summary>
    public interface IYongHuXXRepository : IRepository<YongHuXX>
    {
        #region 方法
        /// <summary>
        /// 根据账号获取用户信息
        /// </summary>
        /// <param name="cid">账号</param>
        /// <returns>用户信息列表</returns>
        YongHuXX GetYongHuXXByCID(string cid);
        #endregion
    }
}
