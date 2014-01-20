using CSMS3.Domain.Model;
using System.Linq;

namespace CSMS3.Domain.Repository.EntityFramework
{
    /// <summary>
    /// 表示Menu仓储的一个具体实现。
    /// </summary>
    public class MenuRepository : EntityFrameworkRepository<Menu>, IMenuRepository
    {
        #region 构造函数
        public MenuRepository(IRepositoryContext context) : base(context) { }
        #endregion

        #region IMenuRepository 成员
        /// <summary>
        /// 获取所有激活菜单
        /// </summary>
        public List<Menu> GetAllActiveMenu() 
        {
            var ctx = this.EFContext.Context as CSMS3DbContext;
            if (ctx != null)
            {
                var query = from p in ctx.Menus
                            where p.STATUS == 1
                            select p;

                return query;
            }
            return null;
        }
        #endregion
    }
}
