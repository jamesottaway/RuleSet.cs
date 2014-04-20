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

}

