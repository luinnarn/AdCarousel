using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdProvider.Model
{
    class StrictCompositeRule : IRule
    {
        public IEnumerable<IRule> InnerRules { get; }

        public StrictCompositeRule(List<IRule> innerRules)
        {
            InnerRules = innerRules;
        }
        public bool ShouldShowAd(Context context)
        {
            return InnerRules.All(x => x.ShouldShowAd(context));
        }
    }
}
