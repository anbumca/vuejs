using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EntityLibrary.Context;

namespace Access2._0_POC.Services.IServices
{
    public interface IExternalEcomSystem
    {
        IEnumerable<ExternalEcommSystem> Get();
        KeyValuePair<bool, string> Add(ExternalEcommSystem input);
        KeyValuePair<bool, string> Update(ExternalEcommSystem input);
    }
}
