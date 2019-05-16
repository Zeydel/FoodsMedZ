using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_Reciever
{
	public sealed class SettingSingleton
	{

		static JsonSerializerSettings jsettings;
		public static JsonSerializerSettings GetJsonSerializerSettings()
		{
			if(jsettings == null)
			{
				jsettings = new JsonSerializerSettings()
				{
					PreserveReferencesHandling = PreserveReferencesHandling.Objects,
					Formatting = Formatting.Indented,
					ReferenceLoopHandling = ReferenceLoopHandling.Ignore

				};
			}
			return jsettings;
		}
		
	}
}
