using System.Linq;

namespace Dtat.Net
{
	public static class IPAddress
	{
		static IPAddress()
		{
		}

		public static string Fix(string ipV4Address)
		{
			ipV4Address =
				String.Fix(ipV4Address);

			if (ipV4Address == null)
			{
				return null;
			}

			ipV4Address =
				ipV4Address
				.Replace(":", ".")
				.Replace(" ", string.Empty)
				;

			if (ipV4Address.Length > 15)
			{
				return null;
			}

			string[] parts =
				ipV4Address.Split('.');

			if (parts.Length != 4)
			{
				return null;
			}

			string result = string.Empty;

			for (int index = 0; index <= parts.Length - 1; index++)
			{
				var part =
					parts[index].PadLeft(totalWidth: 1, '0');

				// باید همه اجزاء عددی باشند
				try
				{
					System.Convert.ToInt32(part);
				}
				catch
				{
					return null;
				}

				result += part;

				if (index != parts.Length - 1)
				{
					result += ".";
				}
			}

			return result;
		}

		public static string Format
			(string ipV4Address, char padLeftCharacter = '_')
		{
			// **************************************************
			string value =
				Fix(ipV4Address);

			if (value == null)
			{
				return null;
			}
			// **************************************************

			string[] parts =
				value.Split('.');

			string result = string.Empty;

			for (int index = 0; index <= parts.Length - 1; index++)
			{
				var part =
					parts[index].PadLeft(totalWidth: 3, padLeftCharacter);

				result += part;

				if (index != parts.Length - 1)
				{
					result += ".";
				}
			}

			return result;
		}

		public static uint? ToNumber(string ipV4Address)
		{
			// **************************************************
			string value =
				Fix(ipV4Address);

			if (value == null)
			{
				return null;
			}
			// **************************************************

			//string[] parts =
			//	value.Split('.');

			//long result =
			//	System.Convert.ToInt32(parts[0]) * (2 ^ 24) +
			//	System.Convert.ToInt32(parts[1]) * (2 ^ 16) +
			//	System.Convert.ToInt32(parts[2]) * (2 ^ 8) +
			//	System.Convert.ToInt32(parts[3])
			//	;

			//long result =
			//	System.Convert.ToInt64(parts[0]) * 16777216 +
			//	System.Convert.ToInt64(parts[1]) * 65536 +
			//	System.Convert.ToInt64(parts[2]) * 256 +
			//	System.Convert.ToInt64(parts[3])
			//	;

			//if (result > uint.MaxValue)
			//{
			//	return null;
			//}

			//return (int)result;

			try
			{
				var ipAddress =
					System.Net.IPAddress.Parse(ipString: value);

				var bytes =
					ipAddress.GetAddressBytes().Reverse().ToArray();

				var result =
					System.BitConverter.ToUInt32(value: bytes, startIndex: 0);

				return result;
			}
			catch
			{
				return null;
			}
		}

		public static string ToString(uint ipV4Address)
		{
			byte[] bytes =
				System.BitConverter.GetBytes(value: ipV4Address);

			// Flip little endian to big-endian (network order)
			if (System.BitConverter.IsLittleEndian)
			{
				System.Array.Reverse(bytes);
			}

			try
			{
				var result =
					new System.Net.IPAddress(address: bytes).ToString();

				return result;
			}
			catch
			{
				return null;
			}
		}
	}
}
