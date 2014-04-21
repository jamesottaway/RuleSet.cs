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

	[TestFixture]
	public class RuleSetTestsWithTwoGenericInputTypes
	{
		private Func<object, object, bool> equal;
		private Func<object, object, bool> notEqual;

		[SetUp]
		public void SetUp()
		{
			equal = (a, b) => a == b;
			notEqual = (a, b) => a != b;
		}

		[Test]
		public void TestFirstReturnsFirstResultWhereTheConditionIsMet()
		{
			var ruleSet = new RuleSet<object, object, string>();

			ruleSet.When(equal).Then("equal");
			ruleSet.When(equal).Then("definitely equal");

			Assert.That(ruleSet.First("foo", "foo"), Is.EqualTo("equal"));
		}

		[Test]
		public void TestFirstReturnsDefaultResultWhereNoConditionIsMet()
		{
			var ruleSet = new RuleSet<object, object, string>("default");

			ruleSet.When(equal).Then("equal");

			Assert.That(ruleSet.First("foo", "bar"), Is.EqualTo("default"));
		}

		[Test]
		public void TestAllReturnsAllResultsWhereTheConditionIsMet()
		{
			var ruleSet = new RuleSet<object, object, string>();

			ruleSet.When(notEqual).Then("not equal");
			ruleSet.When(equal).Then("equal");
			ruleSet.When(equal).Then("definitely equal");

			var results = ruleSet.All("foo", "foo");

			Assert.That(results.Count(), Is.EqualTo(2));
			Assert.That(results, Contains.Item("equal"));
			Assert.That(results, Contains.Item("definitely equal"));
		}
	}
}

