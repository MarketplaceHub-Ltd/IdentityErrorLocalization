using Microsoft.AspNetCore.Identity;

namespace IdentityErrorLocalization.Multilang
{
    public static class IdentityBuilderExtensions
    {
        public static IdentityBuilder AddMultilangIdentityErrorDescriber(this IdentityBuilder identityBuilder)
            => identityBuilder.AddErrorDescriber<MultilangIdentityErrorDescriber>();
    }
}