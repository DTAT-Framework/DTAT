namespace Dtat.Test.Net
{
	public class UnitTestIP : object
	{
		public UnitTestIP() : base()
		{
		}

		[Xunit.Fact]
		public void Test01()
		{
			var actual =
				Dtat.Net.IPAddress.Fix(ipV4Address: null);

			Xunit.Assert.Null(@object: actual);
			//Xunit.Assert.Equal(expected: null, actual: actual);
		}

		[Xunit.Fact]
		public void Test02()
		{
			var actual =
				Dtat.Net.IPAddress.Fix(ipV4Address: "");

			Xunit.Assert.Null(@object: actual);
			//Xunit.Assert.Equal(expected: null, actual: actual);
		}

		[Xunit.Fact]
		public void Test03()
		{
			var actual =
				Dtat.Net.IPAddress.Fix(ipV4Address: "     ");

			Xunit.Assert.Null(@object: actual);
			//Xunit.Assert.Equal(expected: null, actual: actual);
		}

		[Xunit.Fact]
		public void Test04()
		{
			var actual =
				Dtat.Net.IPAddress.Fix(ipV4Address: "     ABC    ");

			Xunit.Assert.Null(@object: actual);
			//Xunit.Assert.Equal(expected: null, actual: actual);
		}

		[Xunit.Fact]
		public void Test05()
		{
			var actual =
				Dtat.Net.IPAddress.Fix(ipV4Address: "     ABC    ");

			Xunit.Assert.Null(@object: actual);
			//Xunit.Assert.Equal(expected: null, actual: actual);
		}

		[Xunit.Fact]
		public void Test06()
		{
			var actual =
				Dtat.Net.IPAddress.Fix
				(ipV4Address: "     ABC   .   DEF   .   GHI   .   JKL    ");

			Xunit.Assert.Null(@object: actual);
			//Xunit.Assert.Equal(expected: null, actual: actual);
		}

		[Xunit.Fact]
		public void Test07()
		{
			var actual =
				Dtat.Net.IPAddress.Fix
				(ipV4Address: "     ABC1   .   DEF2   .   GHI3   .   JKL4    ");

			Xunit.Assert.Null(@object: actual);
			//Xunit.Assert.Equal(expected: null, actual: actual);
		}

		[Xunit.Fact]
		public void Test08()
		{
			var actual =
				Dtat.Net.IPAddress.Fix
				(ipV4Address: "    1111    :    2222    :    3333    :    4444    ");

			Xunit.Assert.Null(@object: actual);
			//Xunit.Assert.Equal(expected: null, actual: actual);
		}

		[Xunit.Fact]
		public void Test09_1()
		{
			var actual =
				Dtat.Net.IPAddress.Fix
				(ipV4Address: "    111    :    222    :    333    :    444    ");

			Xunit.Assert.Equal(expected: "111.222.333.444", actual: actual);
		}

		[Xunit.Fact]
		public void Test09_2()
		{
			var actual =
				Dtat.Net.IPAddress.Format
				(ipV4Address: "    111    :    222    :    333    :    444    ");

			Xunit.Assert.Equal(expected: "111.222.333.444", actual: actual);
		}

		[Xunit.Fact]
		public void Test09_3()
		{
			var actual =
				Dtat.Net.IPAddress.Format
				(ipV4Address: "    111    :    222    :    333    :    444    ", padLeftCharacter: '0');

			Xunit.Assert.Equal(expected: "111.222.333.444", actual: actual);
		}

		[Xunit.Fact]
		public void Test10_1()
		{
			var actual =
				Dtat.Net.IPAddress.Fix
				(ipV4Address: "    :    :    :    1    ");

			Xunit.Assert.Equal(expected: "0.0.0.1", actual: actual);
		}

		[Xunit.Fact]
		public void Test10_2()
		{
			var actual =
				Dtat.Net.IPAddress.Format
				(ipV4Address: "    :    :    :    1    ");

			Xunit.Assert.Equal(expected: "__0.__0.__0.__1", actual: actual);
		}

		[Xunit.Fact]
		public void Test10_3()
		{
			var actual =
				Dtat.Net.IPAddress.Format
				(ipV4Address: "    :    :    :    1    ", padLeftCharacter: '0');

			Xunit.Assert.Equal(expected: "000.000.000.001", actual: actual);
		}

		[Xunit.Fact]
		public void Test21()
		{
			var actual =
				Dtat.Net.IPAddress.ToNumber(ipV4Address: null);

			Xunit.Assert.Null(@object: actual);
			//Xunit.Assert.Equal(expected: null, actual: actual);
		}

		[Xunit.Fact]
		public void Test22()
		{
			var actual =
				Dtat.Net.IPAddress.ToNumber(ipV4Address: "");

			Xunit.Assert.Null(@object: actual);
			//Xunit.Assert.Equal(expected: null, actual: actual);
		}

		[Xunit.Fact]
		public void Test23()
		{
			var actual =
				Dtat.Net.IPAddress.ToNumber(ipV4Address: "     ");

			Xunit.Assert.Null(@object: actual);
			//Xunit.Assert.Equal(expected: null, actual: actual);
		}

		[Xunit.Fact]
		public void Test24()
		{
			var actual =
				Dtat.Net.IPAddress.ToNumber(ipV4Address: "     ABC    ");

			Xunit.Assert.Null(@object: actual);
			//Xunit.Assert.Equal(expected: null, actual: actual);
		}

		[Xunit.Fact]
		public void Test25()
		{
			var actual =
				Dtat.Net.IPAddress.ToNumber(ipV4Address: "     ABC    ");

			Xunit.Assert.Null(@object: actual);
			//Xunit.Assert.Equal(expected: null, actual: actual);
		}

		[Xunit.Fact]
		public void Test26()
		{
			var actual =
				Dtat.Net.IPAddress.ToNumber
				(ipV4Address: "     ABC   .   DEF   .   GHI   .   JKL    ");

			Xunit.Assert.Null(@object: actual);
			//Xunit.Assert.Equal(expected: null, actual: actual);
		}

		[Xunit.Fact]
		public void Test27()
		{
			var actual =
				Dtat.Net.IPAddress.ToNumber
				(ipV4Address: "     ABC1   .   DEF2   .   GHI3   .   JKL4    ");

			Xunit.Assert.Null(@object: actual);
			//Xunit.Assert.Equal(expected: null, actual: actual);
		}

		[Xunit.Fact]
		public void Test28()
		{
			var actual =
				Dtat.Net.IPAddress.ToNumber
				(ipV4Address: "    1111    :    2222    :    3333    :    4444    ");

			Xunit.Assert.Null(@object: actual);
			//Xunit.Assert.Equal(expected: null, actual: actual);
		}

		[Xunit.Fact]
		public void Test29()
		{
			var actual =
				Dtat.Net.IPAddress.ToNumber
				(ipV4Address: "    111    :    222    :    333    :    444    ");

			//Xunit.Assert.Equal(expected: 1876905660, actual: actual.Value);

			Xunit.Assert.Null(@object: actual);
			//Xunit.Assert.Equal(expected: null, actual: actual);
		}

		[Xunit.Fact]
		public void Test30()
		{
			var actual =
				Dtat.Net.IPAddress.ToNumber
				(ipV4Address: "    :    :    :    1    ");

			Xunit.Assert.Equal(expected: 1, actual: actual);
		}

		[Xunit.Fact]
		public void Test31()
		{
			var actual =
				Dtat.Net.IPAddress.ToNumber
				(ipV4Address: "0.0.0.1");

			Xunit.Assert.Equal(expected: 1, actual: actual);
		}

		[Xunit.Fact]
		public void Test32()
		{
			var actual =
				Dtat.Net.IPAddress.ToNumber
				(ipV4Address: "    999    :    999    :    999    :    999    ");

			//Xunit.Assert.Equal(expected: 16826165991, actual: actual.Value);

			Xunit.Assert.Null(@object: actual);
			//Xunit.Assert.Equal(expected: null, actual: actual);
		}

		[Xunit.Fact]
		public void Test40()
		{
			var actual =
				Dtat.Net.IPAddress.ToString
				(ipV4Address: 1);

			Xunit.Assert.Equal(expected: "0.0.0.1", actual: actual);
		}

		[Xunit.Fact]
		public void Test41()
		{
			var actual =
				Dtat.Net.IPAddress.ToString
				(ipV4Address: 1876905660);

			Xunit.Assert.Equal(expected: "111.223.78.188", actual: actual);
		}

		[Xunit.Fact]
		public void Test42()
		{
			var actual =
				Dtat.Net.IPAddress.ToString
				(ipV4Address: 91373456);

			Xunit.Assert.Equal(expected: "5.114.63.144", actual: actual);
		}

		[Xunit.Fact]
		public void Test43()
		{
			var actual =
				Dtat.Net.IPAddress.ToString
				(ipV4Address: 3221226219);

			Xunit.Assert.Equal(expected: "192.0.2.235", actual: actual);
		}
	}
}
