using CSMS3.Domain.Model;
using CSMS3.Domain.Repository.EntityFramework.ModelConfigurations;
using System.Data.Entity;

namespace CSMS3.Domain.Repository.EntityFramework
{
    /// <summary>
    /// 表示专用于营业收费数据库访问上下文。
    /// </summary>
    public sealed class CSMS3DbContext : DbContext
    {
        #region 构造函数
        /// <summary>
        /// 构造函数，初始化一个新的<c>CSMS3DbContext</c>实例。
        /// </summary>
        public CSMS3DbContext()
            : base("CSMS3")
        {
            this.Configuration.AutoDetectChangesEnabled = true;
            this.Configuration.LazyLoadingEnabled = true;
        }
        #endregion

        #region 公共属性
        /// <summary>
        /// 获取<c>YongHuXX</c>s.
        /// </summary>
        public DbSet<YongHuXX> YongHuXXs
        {
            get { return Set<YongHuXX>(); }
        }

        /// <summary>
        /// 获取<c>Menu</c>s.
        /// </summary>
        public DbSet<Menu> Menus
        {
            get { return Set<Menu>(); }
        }
        #endregion

        #region Protected Methods
        /// <summary>
        /// 创建模型时加载属性配置
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder
                .Configurations
                .Add(new YongHuXXTypeConfiguration())
                //to do 其他类型配置
                ;
            base.OnModelCreating(modelBuilder);
        }
        #endregion
    }
}
