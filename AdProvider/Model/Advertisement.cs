using System.Collections.Generic;
using System.Linq;

namespace AdProvider.Model
{
    public class Advertisement
    {
        public Advertisement(string productName, IRule rule)
        {
            ProductName = productName;
            Rule = rule;
        }

        public string ProductName { get; }

        IRule Rule { get; }

        public override string ToString()
        {
            return $"{ProductName}";
        }

        public bool ShouldShowAd(Context context)
        {
            return Rule.ShouldShowAd(context);
        }
    }
}
