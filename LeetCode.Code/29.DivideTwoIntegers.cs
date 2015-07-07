using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Code
{
	public class DivideTwoIntegers
	{
		public int Divide(int dividend, int divisor)
		{
			if (divisor == 0
				|| dividend == int.MinValue
				&& divisor == -1)
				return int.MaxValue;

			if (dividend == int.MinValue
				&& divisor == 1)
				return int.MinValue;

			if (divisor == int.MinValue)
				return dividend == int.MinValue
					? 1
					: 0;

			var direction = true;
			if (dividend > 0)
			{
				dividend = -dividend;
				direction = !direction;
			}

			if (divisor > 0)
			{
				divisor = -divisor;
				direction = !direction;
			}

			var result = 0;
			while (dividend <= divisor)
			{
				var @base = 1;
				var cutter = divisor;
				while (dividend < 0
					&& dividend <= divisor)
				{
					dividend -= cutter;
					result -= @base;
					cutter += cutter;
					@base += @base;
				}

				@base = 1;
				cutter = divisor;

				while (dividend > 0)
				{
					dividend += cutter;
					result += @base;
					cutter += cutter;
					@base += @base;
				}
			}

			return direction
				? -result
				: result;
		}
	}
}
