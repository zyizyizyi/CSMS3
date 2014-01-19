using System;
using System.Collections.Generic;
using System.ServiceModel;

namespace CSMS3.Infrastructure.Communication
{
    /// <summary>
    /// 表示Channel Factory管理器。
    /// </summary>
    internal sealed class ChannelFactoryManager : DisposableObject
    {
        #region 私有成员
        private static readonly Dictionary<Type, ChannelFactory> factories = new Dictionary<Type, ChannelFactory>();
        private static readonly object sync = new object();
        private static readonly ChannelFactoryManager instance = new ChannelFactoryManager();
        #endregion

        #region 构造函数
        static ChannelFactoryManager() { }
        private ChannelFactoryManager() { }
        #endregion

        #region 公共属性
        /// <summary>
        /// 获取<c>ChannelFactoryManager</c>的单件（Singleton）实例。
        /// </summary>
        public static ChannelFactoryManager Instance
        {
            get { return instance; }
        }
        #endregion

        #region 受保护方法
        /// <summary>
        /// 释放对象
        /// </summary>
        /// <param name="disposing">是否立即释放</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                lock (sync)
                {
                    foreach (Type type in factories.Keys)
                    {
                        ChannelFactory factory = factories[type];
                        try
                        {
                            factory.Close();
                            continue;
                        }
                        catch
                        {
                            factory.Abort();
                            continue;
                        }
                    }
                    factories.Clear();
                }
            }
        }
        #endregion

        #region 公共方法
        /// <summary>
        /// 获取与指定服务契约类型相关的Channel Factory实例。
        /// </summary>
        /// <typeparam name="T">服务契约的类型。</typeparam>
        /// <returns>与指定服务契约类型相关的Channel Factory实例。</returns>
        public ChannelFactory<T> GetFactory<T>()
            where T : class, IApplicationServiceContract
        {
            lock (sync)
            {
                ChannelFactory factory = null;
                if (!factories.TryGetValue(typeof(T), out factory))
                {
                    factory = new ChannelFactory<T>(typeof(T).Name);
                    factory.Open();
                    factories.Add(typeof(T), factory);
                }
                return factory as ChannelFactory<T>;
            }
        }
        #endregion
    }
}
