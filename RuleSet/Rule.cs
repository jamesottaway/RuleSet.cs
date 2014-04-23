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

	public class Rule<T1, T2, T3, TResult>
	{
		public Func<T1,T2,T3,bool> Condition { get; set; }
		public TResult Result { get; set; }

		public Rule(Func<T1,T2,T3,bool> condition, TResult result)
		{
			this.Condition = condition;
			this.Result = result;
		}
	}

	public class Rule<T1, T2, T3, T4, TResult>
	{
		public Func<T1,T2,T3,T4,bool> Condition { get; set; }
		public TResult Result { get; set; }

		public Rule(Func<T1,T2,T3,T4,bool> condition, TResult result)
		{
			this.Condition = condition;
			this.Result = result;
		}
	}

	public class Rule<T1, T2, T3, T4, T5, TResult>
	{
		public Func<T1,T2,T3,T4,T5,bool> Condition { get; set; }
		public TResult Result { get; set; }

		public Rule(Func<T1,T2,T3,T4,T5,bool> condition, TResult result)
		{
			this.Condition = condition;
			this.Result = result;
		}
	}

	public class Rule<T1, T2, T3, T4, T5, T6, TResult>
	{
		public Func<T1,T2,T3,T4,T5,T6,bool> Condition { get; set; }
		public TResult Result { get; set; }

		public Rule(Func<T1,T2,T3,T4,T5,T6,bool> condition, TResult result)
		{
			this.Condition = condition;
			this.Result = result;
		}
	}

    public class Rule<T1, T2, T3, T4, T5, T6, T7, TResult>
    {
        public Func<T1,T2,T3,T4,T5,T6,T7,bool> Condition { get; set; }
        public TResult Result { get; set; }

        public Rule(Func<T1,T2,T3,T4,T5,T6,T7,bool> condition, TResult result)
        {
            this.Condition = condition;
            this.Result = result;
        }
    }

    public class Rule<T1, T2, T3, T4, T5, T6, T7, T8, TResult>
    {
        public Func<T1,T2,T3,T4,T5,T6,T7,T8,bool> Condition { get; set; }
        public TResult Result { get; set; }

        public Rule(Func<T1,T2,T3,T4,T5,T6,T7,T8,bool> condition, TResult result)
        {
            this.Condition = condition;
            this.Result = result;
        }
    }

    public class Rule<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>
    {
        public Func<T1,T2,T3,T4,T5,T6,T7,T8,T9,bool> Condition { get; set; }
        public TResult Result { get; set; }

        public Rule(Func<T1,T2,T3,T4,T5,T6,T7,T8,T9,bool> condition, TResult result)
        {
            this.Condition = condition;
            this.Result = result;
        }
    }
}

