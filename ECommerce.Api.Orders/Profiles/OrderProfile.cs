using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.Api.Orders.Profiles
{
    public class OrderProfile : AutoMapper.Profile
    {
        public OrderProfile()
        {
            CreateMap<DBContext.Order, Models.Order>();
            CreateMap<DBContext.OrderItem, Models.OrderItem>();
        }
    }
}
