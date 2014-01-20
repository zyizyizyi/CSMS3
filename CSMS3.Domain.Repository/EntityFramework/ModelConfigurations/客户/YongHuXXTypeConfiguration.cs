using CSMS3.Domain.Model;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace CSMS3.Domain.Repository.EntityFramework.ModelConfigurations
{
    /// <summary>
    /// 用户信息配置
    /// </summary>
    public class YongHuXXTypeConfiguration : EntityTypeConfiguration<YongHuXX>
    {
        public YongHuXXTypeConfiguration()
        {
            HasKey<Guid>(c => c.ID);
            Property(c => c.ID)
                .IsRequired()
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(c => c.S_CID)
                .IsRequired()
                .HasMaxLength(50);
        }
    }
}
