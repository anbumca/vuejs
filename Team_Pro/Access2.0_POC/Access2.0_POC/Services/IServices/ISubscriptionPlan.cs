using EntityLibrary.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Access2._0_POC.Services.IServices
{
    public interface ISubscriptionPlan
    {
        KeyValuePair<bool, string> Add(SubscriptionPlan subscriptionPlan);
    }
}
