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

	public class When<TRuleSet,T1,T2,TResult>
		where TRuleSet : RuleSet<T1,T2,TResult>
	{
		internal readonly TRuleSet ruleSet;
		internal readonly Func<T1,T2,bool> condition;

		public When(TRuleSet ruleSet, Func<T1,T2,bool> condition)
		{
			this.ruleSet = ruleSet;
			this.condition = condition;
		}

		public void Then(TResult result)
		{
			ruleSet.Add(condition, result);
		}
	}

	public class When<TRuleSet,T1,T2,T3,TResult>
		where TRuleSet : RuleSet<T1,T2,T3,TResult>
	{
		internal readonly TRuleSet ruleSet;
		internal readonly Func<T1,T2,T3,bool> condition;

		public When(TRuleSet ruleSet, Func<T1,T2,T3,bool> condition)
		{
			this.ruleSet = ruleSet;
			this.condition = condition;
		}

		public void Then(TResult result)
		{
			ruleSet.Add(condition, result);
		}
	}

	public class When<TRuleSet,T1,T2,T3,T4,TResult>
		where TRuleSet : RuleSet<T1,T2,T3,T4,TResult>
	{
		internal readonly TRuleSet ruleSet;
		internal readonly Func<T1,T2,T3,T4,bool> condition;

		public When(TRuleSet ruleSet, Func<T1,T2,T3,T4,bool> condition)
		{
			this.ruleSet = ruleSet;
			this.condition = condition;
		}

		public void Then(TResult result)
		{
			ruleSet.Add(condition, result);
		}
	}

	public class When<TRuleSet,T1,T2,T3,T4,T5,TResult>
		where TRuleSet : RuleSet<T1,T2,T3,T4,T5,TResult>
	{
		internal readonly TRuleSet ruleSet;
		internal readonly Func<T1,T2,T3,T4,T5,bool> condition;

		public When(TRuleSet ruleSet, Func<T1,T2,T3,T4,T5,bool> condition)
		{
			this.ruleSet = ruleSet;
			this.condition = condition;
		}

		public void Then(TResult result)
		{
			ruleSet.Add(condition, result);
		}
	}

	public class When<TRuleSet,T1,T2,T3,T4,T5,T6,TResult>
		where TRuleSet : RuleSet<T1,T2,T3,T4,T5,T6,TResult>
	{
		internal readonly TRuleSet ruleSet;
		internal readonly Func<T1,T2,T3,T4,T5,T6,bool> condition;

		public When(TRuleSet ruleSet, Func<T1,T2,T3,T4,T5,T6,bool> condition)
		{
			this.ruleSet = ruleSet;
			this.condition = condition;
		}

		public void Then(TResult result)
		{
			ruleSet.Add(condition, result);
		}
	}

    public class When<TRuleSet,T1,T2,T3,T4,T5,T6,T7,TResult>
        where TRuleSet : RuleSet<T1,T2,T3,T4,T5,T6,T7,TResult>
    {
        internal readonly TRuleSet ruleSet;
        internal readonly Func<T1,T2,T3,T4,T5,T6,T7,bool> condition;

        public When(TRuleSet ruleSet, Func<T1,T2,T3,T4,T5,T6,T7,bool> condition)
        {
            this.ruleSet = ruleSet;
            this.condition = condition;
        }

        public void Then(TResult result)
        {
            ruleSet.Add(condition, result);
        }
    }

    public class When<TRuleSet,T1,T2,T3,T4,T5,T6,T7,T8,TResult>
        where TRuleSet : RuleSet<T1,T2,T3,T4,T5,T6,T7,T8,TResult>
    {
        internal readonly TRuleSet ruleSet;
        internal readonly Func<T1,T2,T3,T4,T5,T6,T7,T8,bool> condition;

        public When(TRuleSet ruleSet, Func<T1,T2,T3,T4,T5,T6,T7,T8,bool> condition)
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

