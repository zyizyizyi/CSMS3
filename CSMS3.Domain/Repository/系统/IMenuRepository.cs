using CSMS3.Domain.Model;

namespace CSMS3.Domain.Repository
{
    /// <summary>
    /// 表示用于“菜单”聚合根的仓储接口。
    /// </summary>
    public interface IMenuRepository : IRepository<Menu>
    {
        #region 方法
        /// <summary>
        /// 获取所有激活菜单
        /// </summary>
        Menu GetAllActiveMenu();
        #endregion
    }
}
