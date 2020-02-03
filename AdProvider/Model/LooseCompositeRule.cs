using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdProvider.Model
{
    class LooseCompositeRule : IRule
    {
        public IEnumerable<IRule> InnerRules { get; }

        public LooseCompositeRule(IEnumerable<IRule> innerRules)
        {
            InnerRules = innerRules;
        }
        public bool ShouldShowAd(Context context)
        {
                return InnerRules.Any(x => x.ShouldShowAd(context));
        }
    }
}
