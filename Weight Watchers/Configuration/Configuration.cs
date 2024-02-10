using AutoMapper;
using Subscribe.core.Interface;
using Subscriber.core.Interface_Service;
using Subscriber.DAL.Repository;
using Subscriber.Services;
using Subscriber_.Services;
using Subscriberr.core.Interface;

namespace Subscriber.Weight_Watchers.Configuration
{
    public static class ConfigurationService
    {

        public static void ConfigurationServices(this IServiceCollection services)
        {
            services.AddScoped<ISubscriberRepository, SubscribeRepository>();
            services.AddScoped<ISubscribeService, SubscribeService>();


            services.AddScoped<ICardRepository, CardRepository>();
            services.AddScoped<ICardService, CardService>();



            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new SubscriberProfiler());
            });

            IMapper mapper = mappingConfig.CreateMapper();

            services.AddSingleton(mapper);

        }
    }
}
