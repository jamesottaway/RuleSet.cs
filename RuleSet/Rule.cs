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

	public class Rule<T1, T2, TResult>
	{
		public Func<T1,T2,bool> Condition { get; set; }
		public TResult Result { get; set; }

		public Rule(Func<T1,T2,bool> condition, TResult result)
		{
			this.Condition = condition;
			this.Result = result;
		}
	}
}

