using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace IdentityErrorLocalization.Multilang
{
    public static class IServiceCollectionExtensions
    {
        public static IServiceCollection AddMultilangIdentityErrorDescriberFactory(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<IdentityErrorDescriberFactory>(sp =>
            {
                var httpContext = sp.GetService<IHttpContextAccessor>()?.HttpContext;
                var culture = httpContext?.Request
                        .GetTypedHeaders()
                        .AcceptLanguage
                        .OrderByDescending(q => q.Quality)
                        .FirstOrDefault()?.Value.Value ?? string.Empty;
                return new IdentityErrorDescriberFactory(culture);

            });
            return serviceCollection;
        }
    }
}