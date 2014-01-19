using CSMS3.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSMS3.Domain.Service
{
    /// <summary>
    /// 表示继承于该接口的类型都是领域服务（Domain Service）类型。
    /// </summary>
    public interface IDomainService
    {
        #region Methods
        /// <summary>
        /// 修改站点
        /// </summary>
        /// <param name="yongHuXX">用户信息</param>
        /// <returns>修改过的站点</returns>
        YongHuXX XiuGaiST(YongHuXX yongHuXX);
        #endregion
    }
}
