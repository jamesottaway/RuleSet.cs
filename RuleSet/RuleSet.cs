using System;
using System.Collections.Generic;
using System.Linq;

namespace RuleSet
{
	public class RuleSet<T1,TResult>
	{
		internal readonly IList<Rule<T1, TResult>> rules;
		internal readonly TResult defaultResult;

		public RuleSet(TResult defaultResult = default(TResult)) : base()
		{
			this.rules = new List<Rule<T1, TResult>>();
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
		internal readonly IList<Rule<T1, T2, TResult>> rules;
		internal readonly TResult defaultResult;

		public RuleSet(TResult defaultResult = default(TResult)) : base()
		{
			this.rules = new List<Rule<T1, T2, TResult>>();
			this.defaultResult = defaultResult;
		}

		public When<RuleSet<T1,T2,TResult>,T1,T2,TResult> When(Func<T1,T2,bool> condition)
		{
			var when = new When<RuleSet<T1,T2,TResult>,T1,T2,TResult>(this, condition);
			return when;
		}

		public When<RuleSet<T1,T2,TResult>,T1,T2,TResult> When(T1 t1, T2 t2)
		{
			Func<T1,T2,bool> condition = (a,b) => a.Equals(t1) && b.Equals(t2);
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
		internal readonly IList<Rule<T1, T2, T3, TResult>> rules;
		internal readonly TResult defaultResult;

		public RuleSet(TResult defaultResult = default(TResult)) : base()
		{
			this.rules = new List<Rule<T1, T2, T3, TResult>>();
			this.defaultResult = defaultResult;
		}

		public When<RuleSet<T1,T2,T3,TResult>,T1,T2,T3,TResult> When(Func<T1,T2,T3,bool> condition)
		{
			var when = new When<RuleSet<T1,T2,T3,TResult>,T1,T2,T3,TResult>(this, condition);
			return when;
		}

		public When<RuleSet<T1,T2,T3,TResult>,T1,T2,T3,TResult> When(T1 t1, T2 t2, T3 t3)
		{
			Func<T1,T2,T3,bool> condition = (a,b,c) => a.Equals(t1) && b.Equals(t2) && c.Equals(t3);
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
}

