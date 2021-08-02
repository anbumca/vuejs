using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Access2._0_POC.Services.IServices;
using EntityLibrary.Context;

namespace Access2._0_POC.Services
{
    public class ExternalEcomSystem : IExternalEcomSystem
    {
        private AccessDbContext _context;
        public ExternalEcomSystem(AccessDbContext Context)
        {
            _context = Context;
        }

        public IEnumerable<ExternalEcommSystem> Get()
        {
            try
            {
                return (from p in _context.ExternalEcommSystem
                        select p);
            }
            catch(Exception e)
            {
                return null;
            }
        }

        public KeyValuePair<bool, string> Add(ExternalEcommSystem input)
        {
            try
            {
                var recordStatus = _context.ExternalEcommSystem.Any(x => x.internal_id == input.internal_id);

                if (recordStatus)
                    throw new DataMisalignedException("Record already exist, cannot add!");

                input.CreatedBy = "Test User";
                input.CreatedOn = DateTime.UtcNow;
                _context.ExternalEcommSystem.Add(input);
                _context.SaveChanges();

                return new KeyValuePair<bool, string>(true, "Successfully added");
            }
            catch(Exception e)
            {
                return new KeyValuePair<bool, string>(false, e.Message);
            }
        }

        public KeyValuePair<bool, string> Update(ExternalEcommSystem input)
        {
            try
            {
                var record = _context.ExternalEcommSystem.Where(x => x.internal_id == input.internal_id).FirstOrDefault();

                if (record == null)
                    throw new NullReferenceException("Requested record not found");

                record.name = input.name;
                record.internal_code = input.internal_code;
                record.settings = input.settings;
                record.ModifiedBy = "Modified User";
                record.ModifiedOn = DateTime.UtcNow;

                _context.SaveChanges();

                return new KeyValuePair<bool, string>(true, "Successfully updated");
            }
            catch(Exception e)
            {
                return new KeyValuePair<bool, string>(false, e.Message);
            }
        }
    }
}
