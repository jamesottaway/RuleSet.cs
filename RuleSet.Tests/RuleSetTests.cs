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

	[TestFixture]
	public class RuleSetTestsWithThreeGenericInputTypes
	{
		private Func<int, int, int, bool> asc;
		private Func<int, int, int, bool> desc;

		[SetUp]
		public void SetUp()
		{
			asc = (a, b, c) => c > b && b > a;
			desc = (a, b, c) => a > b && b > c;
		}

		[Test]
		public void TestFirstReturnsFirstResultWhereTheConditionIsMet()
		{
			var ruleSet = new RuleSet<int, int, int, string>();

			ruleSet.When(asc).Then("ascending");
			ruleSet.When(asc).Then("definitely ascending");

			Assert.That(ruleSet.First(1,2,3), Is.EqualTo("ascending"));
		}

		[Test]
		public void TestFirstReturnsDefaultResultWhereNoConditionIsMet()
		{
			var ruleSet = new RuleSet<int, int, int, string>("default");

			ruleSet.When(asc).Then("ascending");

			Assert.That(ruleSet.First(5,5,5), Is.EqualTo("default"));
		}

		[Test]
		public void TestAllReturnsAllResultsWhereTheConditionIsMet()
		{
			var ruleSet = new RuleSet<int, int, int, string>();

			ruleSet.When(desc).Then("descending");
			ruleSet.When(asc).Then("ascending");
			ruleSet.When(asc).Then("definitely ascending");

			var results = ruleSet.All(1,2,3);

			Assert.That(results.Count(), Is.EqualTo(2));
			Assert.That(results, Contains.Item("ascending"));
			Assert.That(results, Contains.Item("definitely ascending"));
		}
	}

	[TestFixture]
	public class RuleSetTestsWithFourGenericInputTypes
	{
		private Func<int, int, int, int, bool> asc;
		private Func<int, int, int, int, bool> desc;

		[SetUp]
		public void SetUp()
		{
			asc = (a, b, c, d) => d > c && c > b && b > a;
			desc = (a, b, c, d) => a > b && b > c && c > d;
		}

		[Test]
		public void TestFirstReturnsFirstResultWhereTheConditionIsMet()
		{
			var ruleSet = new RuleSet<int, int, int, int, string>();

			ruleSet.When(asc).Then("ascending");
			ruleSet.When(asc).Then("definitely ascending");

			Assert.That(ruleSet.First(1,2,3,4), Is.EqualTo("ascending"));
		}

		[Test]
		public void TestFirstReturnsDefaultResultWhereNoConditionIsMet()
		{
			var ruleSet = new RuleSet<int, int, int, int, string>("default");

			ruleSet.When(asc).Then("ascending");

			Assert.That(ruleSet.First(5,5,5,5), Is.EqualTo("default"));
		}

		[Test]
		public void TestAllReturnsAllResultsWhereTheConditionIsMet()
		{
			var ruleSet = new RuleSet<int, int, int, int, string>();

			ruleSet.When(desc).Then("descending");
			ruleSet.When(asc).Then("ascending");
			ruleSet.When(asc).Then("definitely ascending");

			var results = ruleSet.All(1,2,3,4);

			Assert.That(results.Count(), Is.EqualTo(2));
			Assert.That(results, Contains.Item("ascending"));
			Assert.That(results, Contains.Item("definitely ascending"));
		}
	}

	[TestFixture]
	public class RuleSetTestsWithFiveGenericInputTypes
	{
		private Func<int, int, int, int, int, bool> asc;
		private Func<int, int, int, int, int, bool> desc;

		[SetUp]
		public void SetUp()
		{
			asc = (a, b, c, d, e) => e > d && d > c && c > b && b > a;
			desc = (a, b, c, d, e) => a > b && b > c && c > d && d > e;
		}

		[Test]
		public void TestFirstReturnsFirstResultWhereTheConditionIsMet()
		{
			var ruleSet = new RuleSet<int, int, int, int, int, string>();

			ruleSet.When(asc).Then("ascending");
			ruleSet.When(asc).Then("definitely ascending");

			Assert.That(ruleSet.First(1,2,3,4,5), Is.EqualTo("ascending"));
		}

		[Test]
		public void TestFirstReturnsDefaultResultWhereNoConditionIsMet()
		{
			var ruleSet = new RuleSet<int, int, int, int, int, string>("default");

			ruleSet.When(asc).Then("ascending");

			Assert.That(ruleSet.First(5,5,5,5,5), Is.EqualTo("default"));
		}

		[Test]
		public void TestAllReturnsAllResultsWhereTheConditionIsMet()
		{
			var ruleSet = new RuleSet<int, int, int, int, int, string>();

			ruleSet.When(desc).Then("descending");
			ruleSet.When(asc).Then("ascending");
			ruleSet.When(asc).Then("definitely ascending");

			var results = ruleSet.All(1,2,3,4,5);

			Assert.That(results.Count(), Is.EqualTo(2));
			Assert.That(results, Contains.Item("ascending"));
			Assert.That(results, Contains.Item("definitely ascending"));
		}
	}
}

