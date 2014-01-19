using System;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace CSMS3.Application.DTO
{
    /// <summary>
    /// 表示wcf的异常信息
    /// </summary>
    [DataContract]
    public class FaultData
    {
        #region 公共属性
        /// <summary>
        /// 异常信息
        /// </summary>
        [DataMember(Order = 0)]
        public string Message { get; set; }
        /// <summary>
        /// 完整异常信息
        /// </summary>
        [DataMember(Order = 1)]
        public string FullMessage { get; set; }
        /// <summary>
        /// 堆栈异常信息
        /// </summary>
        [DataMember(Order = 2)]
        public string StackTrace { get; set; }
        #endregion

        #region 公共静态方法
        /// <summary>
        /// 创建一个异常对象
        /// </summary>
        /// <param name="ex">错误信息</param>
        /// <returns>新的异常类</returns>
        public static FaultData CreateFromException(Exception ex)
        {
            return new FaultData
            {
                Message = ex.Message,
                FullMessage = ex.ToString(),
                StackTrace = ex.StackTrace
            };
        }
        /// <summary>
        /// 创建一个异常对象
        /// </summary>
        /// <param name="ex">错误信息</param>
        /// <returns>新的异常类</returns>
        public static FaultReason CreateFaultReason(Exception ex)
        {
            return new FaultReason(ex.Message);
        }
        #endregion
    }
}
