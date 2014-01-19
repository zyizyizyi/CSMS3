using System;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Dispatcher;

namespace CSMS3.Infrastructure.UnityExtensions
{
    /// <summary>
    /// 初始化和清理线程本地（thead local）存储，为了线程去调用用户代码和去支持 <see cref="UnityContextChannelLifetimeManager"/>.
    /// </summary>
    public class UnityCallContextInitializer : ICallContextInitializer
    {
        /// <summary>
        /// 初始化一个实例 <see cref="UnityCallContextInitializer"/> 类.
        /// </summary>
        public UnityCallContextInitializer()
            : base()
        {
        }

        /// <summary>
        /// 清除这个线程在调用完 <see cref="UnityContextChannelExtension"/>以后.
        /// </summary>
        /// <param name="correlationState">The correlation object returned from the BeforeInvoke method.</param>
        public void AfterInvoke(object correlationState)
        {
            // It feels wrong going through the OperationContext to get to the channel, but since it's not passed as a parameter
            // to this method, like BeforeInvoke(), we have to do it this way.  Should we return a correlation state
            // from BeforeInvoke() to get to this?
            OperationContext.Current.Channel.Extensions.Remove(UnityContextChannelExtension.Current);
        }

        /// <summary>
        ///在初始化之前 <see cref="UnityContextChannelExtension"/> to the WCF client channel.
        /// </summary>
        /// <param name="instanceContext">The service instance for the operation.</param>
        /// <param name="channel">The client channel.</param>
        /// <param name="message">The incoming message.</param>
        /// <returns>A correlation object passed back as a parameter of the AfterInvoke method.</returns>
        public object BeforeInvoke(InstanceContext instanceContext, IClientChannel channel, Message message)
        {
            if (channel == null)
            {
                throw new ArgumentNullException("channel");
            }

            channel.Extensions.Add(new UnityContextChannelExtension());
            return null;
        }
    }
}
