using System;
using System.Configuration;
using System.ServiceModel.Configuration;

namespace CSMS3.Infrastructure.UnityExtensions
{
    /// <summary>
    /// 表示包含一个行为的扩展，它允许用户定制服务或端点行为，
    /// 以包括容器使用UnityServiceBehavior时要使用的结构元件
    /// </summary>
    public class UnityBehaviorExtensionElement : BehaviorExtensionElement
    {
        /// <summary>
        /// 对于容器名称的配置属性的名称。
        /// </summary>
        private const string ContainerConfigurationPropertyName = "containerName";

        /// <summary>
        /// 为使用OperationContext生命周期管理器的配置属性的名称。
        /// </summary>
        private const string OperationContextEnabledPropertyName = "operationContextEnabled";

        /// <summary>
        /// 为使用InstanceContext的生命周期的配置属性的名称。
        /// </summary>
        private const string InstanceContextEnabledPropertyName = "instanceContextEnabled";

        /// <summary>
        ///  为使用ServiceHostBase的生命周期的配置属性的名称。
        /// </summary>
        private const string ServiceHostBaseEnabledPropertyName = "serviceHostBaseEnabled";

        /// <summary>
        /// 为使用contextChannel的生命周期的配置属性的名称。
        /// </summary>
        private const string ContextChannelEnabledPropertyName = "contextChannelEnabled";

        /// <summary>
        /// 获取行为的类型
        /// </summary>
        /// <returns>
        /// A <see cref="UnityServiceBehavior"/> type.
        /// </returns>
        public override Type BehaviorType
        {
            get { return typeof(UnityServiceBehavior); }
        }

        /// <summary>
        /// 获取或设置ContainerName在配置创建服务时使用。
        /// </summary>
        /// <value>The container name in configuration to use when creating services.</value>
        [ConfigurationProperty(ContainerConfigurationPropertyName, IsRequired = false)]
        public string ContainerName
        {
            get { return (string)base[ContainerConfigurationPropertyName]; }
            set { base[ContainerConfigurationPropertyName] = value; }
        }

        /// <summary>
        /// Gets or sets a value indicating whether <see cref="UnityOperationContextLifetimeManager"/> support is enabled. 
        /// </summary>
        /// <value>true 去启用 Unity lifetime manager 支持wcf扩展, otherwise, false.</value>
        [ConfigurationProperty(OperationContextEnabledPropertyName, IsRequired = false, DefaultValue = false)]
        public bool OperationContextEnabled
        {
            get { return (bool)base[OperationContextEnabledPropertyName]; }
            set { base[OperationContextEnabledPropertyName] = value; }
        }

        /// <summary>
        /// Gets or sets a value indicating whether <see cref="UnityInstanceContextLifetimeManager"/> support is enabled. 
        /// </summary>
        /// <value>true to enable Unity lifetime manager support for the WCF InstanceContext extension, otherwise, false.</value>
        [ConfigurationProperty(InstanceContextEnabledPropertyName, IsRequired = false, DefaultValue = false)]
        public bool InstanceContextEnabled
        {
            get { return (bool)base[InstanceContextEnabledPropertyName]; }
            set { base[InstanceContextEnabledPropertyName] = value; }
        }

        /// <summary>
        /// Gets or sets a value indicating whether <see cref="UnityServiceHostBaseLifetimeManager"/> support is enabled. 
        /// </summary>
        /// <value>true to enable Unity lifetime manager support for the WCF ServiceHostBase extension, otherwise, false.</value>
        [ConfigurationProperty(ServiceHostBaseEnabledPropertyName, IsRequired = false, DefaultValue = false)]
        public bool ServiceHostBaseEnabled
        {
            get { return (bool)base[ServiceHostBaseEnabledPropertyName]; }
            set { base[ServiceHostBaseEnabledPropertyName] = value; }
        }

        /// <summary>
        /// Gets or sets a value indicating whether <see cref="UnityContextChannelLifetimeManager"/> support is enabled. 
        /// </summary>
        /// <value>true to enable Unity lifetime manager support for the WCF IContextChannel extension, otherwise, false.</value>
        [ConfigurationProperty(ContextChannelEnabledPropertyName, IsRequired = false, DefaultValue = false)]
        public bool ContextChannelEnabled
        {
            get { return (bool)base[ContextChannelEnabledPropertyName]; }
            set { base[ContextChannelEnabledPropertyName] = value; }
        }

        /// <summary>
        /// 创建一个基类配置
        /// </summary>
        /// <returns>
        /// The behavior extension.
        /// </returns>
        protected override object CreateBehavior()
        {
            return new UnityServiceBehavior()
            {
                ContainerName = this.ContainerName,
                ContextChannelEnabled = this.ContextChannelEnabled,
                InstanceContextEnabled = this.InstanceContextEnabled,
                OperationContextEnabled = this.OperationContextEnabled,
                ServiceHostBaseEnabled = this.ServiceHostBaseEnabled
            };
        }
    }
}
