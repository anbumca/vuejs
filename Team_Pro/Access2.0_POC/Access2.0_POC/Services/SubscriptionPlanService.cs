using Access2._0_POC.Services.IServices;
using EntityLibrary.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Access2._0_POC.Services
{
    public class SubscriptionPlanService : ISubscriptionPlan
    {
        private AccessDbContext _context;

        public SubscriptionPlanService(AccessDbContext Context)
        {
            _context = Context;
        }

        public KeyValuePair<bool, string> Add(SubscriptionPlan input)
        {
            try
            {
                var recordStatus = _context.Currency.Any(x => x.internal_id == input.internal_id);

                if (recordStatus)
                    throw new DataMisalignedException("Record already exist, cannot add!");

                _context.SubscriptionPlan.Add(input);
                _context.SaveChanges();

                return new KeyValuePair<bool, string>(true, "Successfully added");

            }
            catch(Exception e)
            {
                return new KeyValuePair<bool, string>(false, e.Message);
            }
        }
    }
}
