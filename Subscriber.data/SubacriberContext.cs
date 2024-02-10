using Microsoft.EntityFrameworkCore;
using Subscriber.core.DTO;
using Subscriberr.data.model;


namespace Subscriberr.data
{
    public class SubacriberContext : DbContext
    {
        public SubacriberContext(DbContextOptions<SubacriberContext> options) : base(options)
        {
        }

        public DbSet<Card> Cards { get; set; }
        public DbSet<SubscriberTable> Subscribers { get; set; }
    }
}

