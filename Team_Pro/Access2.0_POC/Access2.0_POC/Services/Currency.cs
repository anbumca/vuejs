using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Access2._0_POC.Services.IServices;
using ContextCurrency = EntityLibrary.Context.Currency;
using EntityLibrary.Context;

namespace Access2._0_POC.Services
{
    public class Currency : ICurrency
    {
        private AccessDbContext _context;

        public Currency(AccessDbContext Context)
        {
            _context = Context;
        }

        public IEnumerable<ContextCurrency> Get()
        {
            try
            {
                return _context.Currency.ToList();
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public KeyValuePair<bool, string> Add(ContextCurrency input)
        {
            try
            {
                var recordStatus = _context.Currency.Any(x => x.internal_id == input.internal_id);

                if (recordStatus)
                    throw new DataMisalignedException("Record already exist, cannot add!");

                _context.Currency.Add(input);
                _context.SaveChanges();

                return new KeyValuePair<bool, string>(true, "Successfully added");
            }
            catch(Exception e)
            {
                return new KeyValuePair<bool, string>(false, e.Message);
            }
        }

        public KeyValuePair<bool, string> Update(ContextCurrency input)
        {
            try
            {
                var record = _context.Currency.Where(x => x.internal_id == input.internal_id).FirstOrDefault();

                if (record == null)
                    throw new NullReferenceException("Requested record not found");

                record.internal_code = input.internal_code;
                record.default_display_name = input.default_display_name;
                record.symbol = input.symbol;

                _context.SaveChanges();

                return new KeyValuePair<bool, string>(true, "Successfully updated");
            }
            catch (Exception e)
            {
                return new KeyValuePair<bool, string>(false, e.Message);
            }

        }
    }
}
