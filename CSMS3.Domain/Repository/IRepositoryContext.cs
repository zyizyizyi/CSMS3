﻿using CSMS3.Infrastructure;
using System;

namespace CSMS3.Domain.Repository
{
    /// <summary>
    /// 表示实现该接口的类型是仓储上下文。
    /// to do 增加List实现
    /// </summary>
    public interface IRepositoryContext : IUnitOfWork, IDisposable
    {
        #region Properties
        /// <summary>
        /// 获取仓储上下文的ID。
        /// </summary>
        Guid ID { get; }
        #endregion

        #region Methods
        /// <summary>
        /// 将指定的聚合根标注为“新建”状态。
        /// </summary>
        /// <typeparam name="TAggregateRoot">需要标注状态的聚合根类型。</typeparam>
        /// <param name="obj">需要标注状态的聚合根。</param>
        void RegisterNew<TAggregateRoot>(TAggregateRoot obj)
            where TAggregateRoot : class, IAggregateRoot;
        /// <summary>
        /// 将指定的聚合根标注为“更改”状态。
        /// </summary>
        /// <typeparam name="TAggregateRoot">需要标注状态的聚合根类型。</typeparam>
        /// <param name="obj">需要标注状态的聚合根。</param>
        void RegisterModified<TAggregateRoot>(TAggregateRoot obj)
            where TAggregateRoot : class, IAggregateRoot;
        /// <summary>
        /// 将指定的聚合根标注为“删除”状态。
        /// </summary>
        /// <typeparam name="TAggregateRoot">需要标注状态的聚合根类型。</typeparam>
        /// <param name="obj">需要标注状态的聚合根。</param>
        void RegisterDeleted<TAggregateRoot>(TAggregateRoot obj)
            where TAggregateRoot : class, IAggregateRoot;
        #endregion
    }
}
