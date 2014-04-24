using System;
using System.Collections.Generic;
using System.Linq;

namespace RuleSet
{
	public class RuleSet<T1,TResult>
	{
		internal readonly IList<Rule<T1,TResult>> rules;
		internal readonly TResult defaultResult;

		public RuleSet(TResult defaultResult = default(TResult)) : base()
		{
			this.rules = new List<Rule<T1,TResult>>();
			this.defaultResult = defaultResult;
		}

		public When<RuleSet<T1,TResult>,T1,TResult> When(Func<T1,bool> condition)
		{
			var when = new When<RuleSet<T1,TResult>,T1,TResult>(this, condition);
			return when;
		}

		public When<RuleSet<T1,TResult>,T1,TResult> When(T1 value)
		{
			Func<T1,bool> condition = v => v.Equals(value);
			var when = new When<RuleSet<T1,TResult>,T1,TResult>(this, condition);
			return when;
		}

		public IEnumerable<TResult> All(T1 value)
		{
			return rules.Where(r => r.Condition(value)).Select(r => r.Result);
		}

		public TResult First(T1 value)
		{
			var rule = rules.FirstOrDefault(r => r.Condition(value));
			return rule != null ? rule.Result : defaultResult;
		}

		internal void Add(Func<T1,bool> condition, TResult result)
		{
			var rule = new Rule<T1,TResult>(condition, result);
			rules.Add(rule);
		}
	}

	public class RuleSet<T1,T2,TResult>
	{
		internal readonly IList<Rule<T1,T2,TResult>> rules;
		internal readonly TResult defaultResult;

		public RuleSet(TResult defaultResult = default(TResult)) : base()
		{
			this.rules = new List<Rule<T1,T2,TResult>>();
			this.defaultResult = defaultResult;
		}

		public When<RuleSet<T1,T2,TResult>,T1,T2,TResult> When(Func<T1,T2,bool> condition)
		{
			var when = new When<RuleSet<T1,T2,TResult>,T1,T2,TResult>(this, condition);
			return when;
		}

		public IEnumerable<TResult> All(T1 t1, T2 t2)
		{
			return rules.Where(r => r.Condition(t1, t2)).Select(r => r.Result);
		}

		public TResult First(T1 t1, T2 t2)
		{
			var rule = rules.FirstOrDefault(r => r.Condition(t1, t2));
			return rule != null ? rule.Result : defaultResult;
		}

		internal void Add(Func<T1,T2,bool> condition, TResult result)
		{
			var rule = new Rule<T1,T2,TResult>(condition, result);
			rules.Add(rule);
		}
	}

	public class RuleSet<T1,T2,T3,TResult>
	{
		internal readonly IList<Rule<T1,T2,T3,TResult>> rules;
		internal readonly TResult defaultResult;

		public RuleSet(TResult defaultResult = default(TResult)) : base()
		{
			this.rules = new List<Rule<T1,T2,T3,TResult>>();
			this.defaultResult = defaultResult;
		}

		public When<RuleSet<T1,T2,T3,TResult>,T1,T2,T3,TResult> When(Func<T1,T2,T3,bool> condition)
		{
			var when = new When<RuleSet<T1,T2,T3,TResult>,T1,T2,T3,TResult>(this, condition);
			return when;
		}

		public IEnumerable<TResult> All(T1 t1, T2 t2, T3 t3)
		{
			return rules.Where(r => r.Condition(t1, t2, t3)).Select(r => r.Result);
		}

		public TResult First(T1 t1, T2 t2, T3 t3)
		{
			var rule = rules.FirstOrDefault(r => r.Condition(t1, t2, t3));
			return rule != null ? rule.Result : defaultResult;
		}

		internal void Add(Func<T1,T2,T3,bool> condition, TResult result)
		{
			var rule = new Rule<T1,T2,T3,TResult>(condition, result);
			rules.Add(rule);
		}
	}

	public class RuleSet<T1,T2,T3,T4,TResult>
	{
		internal readonly IList<Rule<T1,T2,T3,T4,TResult>> rules;
		internal readonly TResult defaultResult;

		public RuleSet(TResult defaultResult = default(TResult)) : base()
		{
			this.rules = new List<Rule<T1,T2,T3,T4,TResult>>();
			this.defaultResult = defaultResult;
		}

		public When<RuleSet<T1,T2,T3,T4,TResult>,T1,T2,T3,T4,TResult> When(Func<T1,T2,T3,T4,bool> condition)
		{
			var when = new When<RuleSet<T1,T2,T3,T4,TResult>,T1,T2,T3,T4,TResult>(this, condition);
			return when;
		}

		public IEnumerable<TResult> All(T1 t1, T2 t2, T3 t3, T4 t4)
		{
			return rules.Where(r => r.Condition(t1, t2, t3, t4)).Select(r => r.Result);
		}

		public TResult First(T1 t1, T2 t2, T3 t3, T4 t4)
		{
			var rule = rules.FirstOrDefault(r => r.Condition(t1, t2, t3, t4));
			return rule != null ? rule.Result : defaultResult;
		}

		internal void Add(Func<T1,T2,T3,T4,bool> condition, TResult result)
		{
			var rule = new Rule<T1,T2,T3,T4,TResult>(condition, result);
			rules.Add(rule);
		}
	}

	public class RuleSet<T1,T2,T3,T4,T5,TResult>
	{
		internal readonly IList<Rule<T1,T2,T3,T4,T5,TResult>> rules;
		internal readonly TResult defaultResult;

		public RuleSet(TResult defaultResult = default(TResult)) : base()
		{
			this.rules = new List<Rule<T1,T2,T3,T4,T5,TResult>>();
			this.defaultResult = defaultResult;
		}

		public When<RuleSet<T1,T2,T3,T4,T5,TResult>,T1,T2,T3,T4,T5,TResult> When(Func<T1,T2,T3,T4,T5,bool> condition)
		{
			var when = new When<RuleSet<T1,T2,T3,T4,T5,TResult>,T1,T2,T3,T4,T5,TResult>(this, condition);
			return when;
		}

		public IEnumerable<TResult> All(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5)
		{
			return rules.Where(r => r.Condition(t1, t2, t3, t4, t5)).Select(r => r.Result);
		}

		public TResult First(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5)
		{
			var rule = rules.FirstOrDefault(r => r.Condition(t1, t2, t3, t4, t5));
			return rule != null ? rule.Result : defaultResult;
		}

		internal void Add(Func<T1,T2,T3,T4,T5,bool> condition, TResult result)
		{
			var rule = new Rule<T1,T2,T3,T4,T5,TResult>(condition, result);
			rules.Add(rule);
		}
	}

	public class RuleSet<T1,T2,T3,T4,T5,T6,TResult>
	{
		internal readonly IList<Rule<T1,T2,T3,T4,T5,T6,TResult>> rules;
		internal readonly TResult defaultResult;

		public RuleSet(TResult defaultResult = default(TResult)) : base()
		{
			this.rules = new List<Rule<T1,T2,T3,T4,T5,T6,TResult>>();
			this.defaultResult = defaultResult;
		}

		public When<RuleSet<T1,T2,T3,T4,T5,T6,TResult>,T1,T2,T3,T4,T5,T6,TResult> When(Func<T1,T2,T3,T4,T5,T6,bool> condition)
		{
			var when = new When<RuleSet<T1,T2,T3,T4,T5,T6,TResult>,T1,T2,T3,T4,T5,T6,TResult>(this, condition);
			return when;
		}

		public IEnumerable<TResult> All(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6)
		{
			return rules.Where(r => r.Condition(t1, t2, t3, t4, t5, t6)).Select(r => r.Result);
		}

		public TResult First(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6)
		{
			var rule = rules.FirstOrDefault(r => r.Condition(t1, t2, t3, t4, t5, t6));
			return rule != null ? rule.Result : defaultResult;
		}

		internal void Add(Func<T1,T2,T3,T4,T5,T6,bool> condition, TResult result)
		{
			var rule = new Rule<T1,T2,T3,T4,T5,T6,TResult>(condition, result);
			rules.Add(rule);
		}
	}

    public class RuleSet<T1,T2,T3,T4,T5,T6,T7,TResult>
    {
        internal readonly IList<Rule<T1,T2,T3,T4,T5,T6,T7,TResult>> rules;
        internal readonly TResult defaultResult;

        public RuleSet(TResult defaultResult = default(TResult)) : base()
        {
            this.rules = new List<Rule<T1,T2,T3,T4,T5,T6,T7,TResult>>();
            this.defaultResult = defaultResult;
        }

        public When<RuleSet<T1,T2,T3,T4,T5,T6,T7,TResult>,T1,T2,T3,T4,T5,T6,T7,TResult> When(Func<T1,T2,T3,T4,T5,T6,T7,bool> condition)
        {
            var when = new When<RuleSet<T1,T2,T3,T4,T5,T6,T7,TResult>,T1,T2,T3,T4,T5,T6,T7,TResult>(this, condition);
            return when;
        }

        public IEnumerable<TResult> All(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7)
        {
            return rules.Where(r => r.Condition(t1, t2, t3, t4, t5, t6, t7)).Select(r => r.Result);
        }

        public TResult First(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7)
        {
            var rule = rules.FirstOrDefault(r => r.Condition(t1, t2, t3, t4, t5, t6, t7));
            return rule != null ? rule.Result : defaultResult;
        }

        internal void Add(Func<T1,T2,T3,T4,T5,T6,T7,bool> condition, TResult result)
        {
            var rule = new Rule<T1,T2,T3,T4,T5,T6,T7,TResult>(condition, result);
            rules.Add(rule);
        }
    }

    public class RuleSet<T1,T2,T3,T4,T5,T6,T7,T8,TResult>
    {
        internal readonly IList<Rule<T1,T2,T3,T4,T5,T6,T7,T8,TResult>> rules;
        internal readonly TResult defaultResult;

        public RuleSet(TResult defaultResult = default(TResult)) : base()
        {
            this.rules = new List<Rule<T1,T2,T3,T4,T5,T6,T7,T8,TResult>>();
            this.defaultResult = defaultResult;
        }

        public When<RuleSet<T1,T2,T3,T4,T5,T6,T7,T8,TResult>,T1,T2,T3,T4,T5,T6,T7,T8,TResult> When(Func<T1,T2,T3,T4,T5,T6,T7,T8,bool> condition)
        {
            var when = new When<RuleSet<T1,T2,T3,T4,T5,T6,T7,T8,TResult>,T1,T2,T3,T4,T5,T6,T7,T8,TResult>(this, condition);
            return when;
        }

        public IEnumerable<TResult> All(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8)
        {
            return rules.Where(r => r.Condition(t1, t2, t3, t4, t5, t6, t7, t8)).Select(r => r.Result);
        }

        public TResult First(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8)
        {
            var rule = rules.FirstOrDefault(r => r.Condition(t1, t2, t3, t4, t5, t6, t7, t8));
            return rule != null ? rule.Result : defaultResult;
        }

        internal void Add(Func<T1,T2,T3,T4,T5,T6,T7,T8,bool> condition, TResult result)
        {
            var rule = new Rule<T1,T2,T3,T4,T5,T6,T7,T8,TResult>(condition, result);
            rules.Add(rule);
        }
    }

    public class RuleSet<T1,T2,T3,T4,T5,T6,T7,T8,T9,TResult>
    {
        internal readonly IList<Rule<T1,T2,T3,T4,T5,T6,T7,T8,T9,TResult>> rules;
        internal readonly TResult defaultResult;

        public RuleSet(TResult defaultResult = default(TResult)) : base()
        {
            this.rules = new List<Rule<T1,T2,T3,T4,T5,T6,T7,T8,T9,TResult>>();
            this.defaultResult = defaultResult;
        }

        public When<RuleSet<T1,T2,T3,T4,T5,T6,T7,T8,T9,TResult>,T1,T2,T3,T4,T5,T6,T7,T8,T9,TResult> When(Func<T1,T2,T3,T4,T5,T6,T7,T8,T9,bool> condition)
        {
            var when = new When<RuleSet<T1,T2,T3,T4,T5,T6,T7,T8,T9,TResult>,T1,T2,T3,T4,T5,T6,T7,T8,T9,TResult>(this, condition);
            return when;
        }

        public IEnumerable<TResult> All(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9)
        {
            return rules.Where(r => r.Condition(t1, t2, t3, t4, t5, t6, t7, t8, t9)).Select(r => r.Result);
        }

        public TResult First(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9)
        {
            var rule = rules.FirstOrDefault(r => r.Condition(t1, t2, t3, t4, t5, t6, t7, t8, t9));
            return rule != null ? rule.Result : defaultResult;
        }

        internal void Add(Func<T1,T2,T3,T4,T5,T6,T7,T8,T9,bool> condition, TResult result)
        {
            var rule = new Rule<T1,T2,T3,T4,T5,T6,T7,T8,T9,TResult>(condition, result);
            rules.Add(rule);
        }
    }
}
