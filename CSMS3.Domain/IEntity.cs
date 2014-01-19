using System;

namespace CSMS3.Domain
{
    /// <summary>
    /// 表示继承于该接口的类型是领域实体类。
    /// </summary>
    public interface IEntity
    {
        #region 属性
        /// <summary>
        /// 获取当前领域实体类的全局唯一标识。
        /// </summary>
        Guid ID { get; }
        #endregion
    }
}
