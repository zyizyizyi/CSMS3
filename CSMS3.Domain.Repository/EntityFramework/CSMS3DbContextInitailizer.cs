using System.Data.Entity;

namespace CSMS3.Domain.Repository.EntityFramework
{
    /// <summary>
    /// 表示由Byteart Retail专用的数据访问上下文初始化器。
    /// </summary>
    public sealed class CSMS3DbContextInitailizer : CreateDatabaseIfNotExists<CSMS3DbContext>
    {
        // 请在使用CSMS3DbContextInitializer作为数据库初始化器（Database Initializer）时，去除以下代码行
        // 的注释，以便在数据库重建时，相应的SQL脚本会被执行。对于已有数据库的情况，请直接注释掉以下代码行。
        //protected override void Seed(CSMS3DbContext context)
        //{
        //    context.Database.ExecuteSqlCommand("CREATE UNIQUE INDEX IDX_CUSTOMER_USERNAME ON Customers(UserName)");
        //    context.Database.ExecuteSqlCommand("CREATE UNIQUE INDEX IDX_CUSTOMER_EMAIL ON Customers(Email)");
        //    context.Database.ExecuteSqlCommand("CREATE UNIQUE INDEX IDX_LAPTOP_NAME ON Laptops(Name)");
        //    base.Seed(context);
        //}

        ///// <summary>
        ///// 执行对数据库的初始化操作。
        ///// </summary>
        //public static void Initialize()
        //{
        //    //to do测试配置改变是否会重新初始化
        //    //需要不对数据库有任何操作
        //    //Database.SetInitializer<CSMS3DbContext>(null);

        //    using (var db = new CSMS3DbContext())
        //    {
        //        db.Database.Initialize(false);
        //    }

        //}
    }
}
