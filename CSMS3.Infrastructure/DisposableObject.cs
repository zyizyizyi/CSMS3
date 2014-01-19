using System;

namespace CSMS3.Infrastructure
{
    /// <summary>
    /// 表示该派生类是一个可释放对象
    /// </summary>
    public abstract class DisposableObject : IDisposable
    {
        #region Finalization Constructs
        /// <summary>
        ///析构函数
        /// </summary>
        ~DisposableObject()
        {
            this.Dispose(false);
        }
        #endregion

        #region Protected Methods
        /// <summary>
        /// 释放对象
        /// </summary>
        /// <param name="disposing">一个bool值，指示对象是否要被立即释放</param>
        protected abstract void Dispose(bool disposing);
        /// <summary>
        /// 提供一个显式的释放对象的方法,
        /// 防止析构函数被调用后，对象被显式释放。
        /// </summary>
        protected void ExplicitDispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }
        #endregion

        #region IDisposable Members
        /// <summary>
        /// 执行与释放或重置非托管资源相关的应用程序定义的任务。
        /// </summary>
        public void Dispose()
        {
            this.ExplicitDispose();
        }
        #endregion
    }
}
