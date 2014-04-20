using System;

namespace RuleSet
{
	public class Rule<T1, TResult>
	{
		public Func<T1,bool> Condition { get; set; }
		public TResult Result { get; set; }

		public Rule(Func<T1,bool> condition, TResult result)
		{
			this.Condition = condition;
			this.Result = result;
		}
	}
}

