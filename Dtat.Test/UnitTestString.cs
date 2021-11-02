namespace Dtat.Test
{
	public class UnitTestString : object
	{
		public UnitTestString() : base()
		{
		}

		[Xunit.Fact]
		public void Test01()
		{
			string actual =
				String.Fix(text: null);

			Xunit.Assert.Null(@object: actual);
			//Xunit.Assert.Equal(expected: null, actual: actual);
		}

		[Xunit.Fact]
		public void Test02()
		{
			string actual =
				String.Fix(text: "");

			Xunit.Assert.Null(@object: actual);
			//Xunit.Assert.Equal(expected: null, actual: actual);
		}

		[Xunit.Fact]
		public void Test03()
		{
			string actual =
				String.Fix(text: "     ");

			Xunit.Assert.Null(@object: actual);
			//Xunit.Assert.Equal(expected: null, actual: actual);
		}

		[Xunit.Fact]
		public void Test04()
		{
			string actual =
				String.Fix(text: "     Ali Reza Alavi     ");

			Xunit.Assert.Equal(expected: "Ali Reza Alavi", actual: actual);
		}

		[Xunit.Fact]
		public void Test05()
		{
			string actual =
				String.Fix(text: "     Ali  Reza  Alavi     ");

			Xunit.Assert.Equal(expected: "Ali Reza Alavi", actual: actual);
		}

		[Xunit.Fact]
		public void Test06()
		{
			string actual =
				String.Fix(text: "     Ali     Reza     Alavi     ");

			Xunit.Assert.Equal(expected: "Ali Reza Alavi", actual: actual);
		}
	}
}
