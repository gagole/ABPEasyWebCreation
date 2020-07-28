using Abp.MultiTenancy;
using ABPEasyWebCreation.Authorization.Users;

namespace ABPEasyWebCreation.MultiTenancy
{
    public class Tenant : AbpTenant<User>
    {
        public Tenant()
        {            
        }

        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {
        }
    }
}
