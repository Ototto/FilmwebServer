using System;
using System.Security.Principal;

namespace Filmweb.Extensions
{
    public static class IdentityExtensions
    {
        public static int GetUserId(this IIdentity identity)
        {
            try
            {
                return int.Parse(identity.Name);
            }
            catch (Exception e)
            {
                throw new ApplicationException(e.Message);
            }
        }
    }
}
