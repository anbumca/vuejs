using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContextCurrency = EntityLibrary.Context.Currency;
using EntityLibrary.Context;

namespace Access2._0_POC.Services.IServices
{
    public interface ICurrency
    {
        IEnumerable<ContextCurrency> Get();
        KeyValuePair<bool, string> Add(ContextCurrency input);
        KeyValuePair<bool, string> Update(ContextCurrency input);
    }
}
