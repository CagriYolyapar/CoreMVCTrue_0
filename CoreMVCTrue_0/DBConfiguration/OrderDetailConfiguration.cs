using CoreMVCTrue_0.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CoreMVCTrue_0.DBConfiguration
{
    public class OrderDetailConfiguration:BaseConfiguration<OrderDetail>
    {
        public override void Configure(EntityTypeBuilder<OrderDetail> builder)
        {
            base.Configure(builder);
            builder.HasKey(x => new
            {
                x.OrderID,
                x.ProductID
            });
            builder.Ignore(x => x.ID);
            builder.ToTable("Satıslar");
        }
    }
}
