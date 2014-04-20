using System;
using System.Linq;
using NUnit.Framework;

namespace RuleSet.Tests
{
	[TestFixture]
	public class RuleSetTests
	{
		private Func<int, bool> even;
		private Func<int, bool> odd;

		[SetUp]
		public void SetUp()
		{
			even = i => i % 2 == 0;
			odd = i => i % 2 != 0;
		}

		[Test]
		public void TestFirstReturnsFirstResultWhereTheConditionIsMet()
		{
			var ruleSet = new RuleSet<int, string>();

			ruleSet.When(even).Then("even");
			ruleSet.When(even).Then("definitely even");

			Assert.That(ruleSet.First(2), Is.EqualTo("even"));
		}

		[Test]
		public void TestFirstReturnsDefaultResultWhereNoConditionIsMet()
		{
			var ruleSet = new RuleSet<int, string>("default");

			ruleSet.When(odd).Then("odd");

			Assert.That(ruleSet.First(2), Is.EqualTo("default"));
		}

		[Test]
		public void TestAllReturnsAllResultsWhereTheConditionIsMet()
		{
			var ruleSet = new RuleSet<int, string>();

			ruleSet.When(odd).Then("odd");
			ruleSet.When(even).Then("even");
			ruleSet.When(even).Then("definitely even");

			var results = ruleSet.All(2);

			Assert.That(results.Count(), Is.EqualTo(2));
			Assert.That(results, Contains.Item("even"));
			Assert.That(results, Contains.Item("definitely even"));
		}

		[Test]
		public void TestPassingGenericTypeToWhenInsteadOfFunc()
		{
			var ruleSet = new RuleSet<int, string>();

			ruleSet.When(1).Then("one");

			Assert.That(ruleSet.First(1), Is.EqualTo("one"));
		}
	}
}

