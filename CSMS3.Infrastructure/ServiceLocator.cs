using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CSMS3.Infrastructure
{
    /// <summary>
    /// 表示服务定位器
    /// </summary>
    public sealed class ServiceLocator : IServiceProvider
    {
        #region 私有成员
        private readonly IUnityContainer container;
        #endregion

        #region 私有静态成员
        private static readonly ServiceLocator instance = new ServiceLocator();
        #endregion

        #region 构造函数
        /// <summary>
        /// 构造一个服务定位器实例
        /// </summary>
        private ServiceLocator()
        {
            UnityConfigurationSection section = (UnityConfigurationSection)ConfigurationManager.GetSection("unity");
            container = new UnityContainer();
            section.Configure(container);
        }
        #endregion

        #region 公共静态属性
        /// <summary>
        /// 获取单例类
        /// </summary>
        public static ServiceLocator Instance
        {
            get { return instance; }
        }
        #endregion

        #region 私有方法
        /// <summary>
        /// 构造函数参数重载
        /// </summary>
        /// <param name="overridedArguments">构造函数参数</param>
        /// <returns></returns>
        private IEnumerable<ParameterOverride> GetParameterOverrides(object overridedArguments)
        {
            List<ParameterOverride> overrides = new List<ParameterOverride>();
            Type argumentsType = overridedArguments.GetType();
            argumentsType.GetProperties(BindingFlags.Public | BindingFlags.Instance)
                .ToList()
                .ForEach(property =>
                {
                    var propertyValue = property.GetValue(overridedArguments, null);
                    var propertyName = property.Name;
                    overrides.Add(new ParameterOverride(propertyName, propertyValue));
                });
            return overrides;
        }
        #endregion

        #region 公有方法
        /// <summary>
        /// 通过被给类型获取服务实例
        /// </summary>
        /// <typeparam name="T">服务类型</typeparam>
        /// <returns>服务实例</returns>
        public T GetService<T>()
        {
            return container.Resolve<T>();
        }

        /// <summary>
        ///返回所有被注册的实例 
        /// </summary>
        /// <typeparam name="T">服务类型</typeparam>
        /// <returns>IEnumerable</returns>
        public IEnumerable<T> ResolveAll<T>()
        {
            return container.ResolveAll<T>();
        }
        /// <summary>
        /// 通过被给参数获取服务实例
        /// </summary>
        /// <typeparam name="T">服务类型</typeparam>
        /// <param name="overridedArguments">参数</param>
        /// <returns>服务实例</returns>
        public T GetService<T>(object overridedArguments)
        {
            var overrides = GetParameterOverrides(overridedArguments);
            return container.Resolve<T>(overrides.ToArray());
        }
        /// <summary>
        /// 通过被给参数获取服务实例
        /// </summary>
        /// <param name="serviceType">服务类型</param>
        /// <param name="overridedArguments">参数</param>
        /// <returns>服务实例</returns>
        public object GetService(Type serviceType, object overridedArguments)
        {
            var overrides = GetParameterOverrides(overridedArguments);
            return container.Resolve(serviceType, overrides.ToArray());
        }
        #endregion

        #region IServiceProvider 成员
        /// <summary>
        /// 通过被给参数获取服务实例
        /// </summary>
        /// <param name="serviceType">服务类型</param>
        /// <returns>服务实例</returns>
        public object GetService(Type serviceType)
        {
            return container.Resolve(serviceType);
        }

        #endregion
    }
}
