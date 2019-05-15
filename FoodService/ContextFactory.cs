using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodService
{
	public sealed class ContextFactory
	{
		private static readonly masterEntities m = new masterEntities();
		public static masterEntities getContext()
		{
			return m;
		}
	}
}
