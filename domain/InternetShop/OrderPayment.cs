using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetShop
{
    public class OrderPayment
    {
        public string UniqieCode { get; }
        public string Description { get; }

        public IReadOnlyDictionary<string, string> Parametrs { get; }
        public OrderPayment(string uniqueCode,
                             string description,
                             IReadOnlyDictionary<string ,string> parametrs)
        {
            if (string.IsNullOrWhiteSpace(uniqueCode))
                throw new ArgumentException(nameof(uniqueCode));

            if (string.IsNullOrWhiteSpace(description))
                throw new ArgumentException(nameof(uniqueCode));

            if (parametrs == null)
                throw new ArgumentNullException(nameof(parametrs));

            UniqieCode = uniqueCode;
            Description = description;
            Parametrs = parametrs;

        }
    }
}
