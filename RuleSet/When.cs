using System;

namespace RuleSet
{
	public class When<TRuleSet,T1,TResult>
		where TRuleSet : RuleSet<T1,TResult>
	{
		internal readonly TRuleSet ruleSet;
		internal readonly Func<T1,bool> condition;

		public When(TRuleSet ruleSet, Func<T1,bool> condition)
		{
			this.ruleSet = ruleSet;
			this.condition = condition;
		}

		public void Then(TResult result)
		{
			ruleSet.Add(condition, result);
		}
	}
}

