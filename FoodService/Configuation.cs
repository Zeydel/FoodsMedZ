using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Globalization;

namespace FoodService
{
	/// <summary>
	/// Configuration helper class
	/// </summary>
	public class Configuration
	{
		/// <summary>
		/// Get AppSetting as string, throw exception if not defined.
		/// </summary>
		/// <param name="setting"></param>
		/// <returns></returns>
		public static string GetAppSetting(string setting)
		{
			try
			{
				return System.Configuration.ConfigurationManager.AppSettings[setting];
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.ToString());
				return null;
			}
		}

		/// <summary>
		/// Get Application Settings
		/// </summary>
		/// <param name="setting"></param>
		/// <param name="defaultvalue"></param>
		/// <returns></returns>
		public static string GetAppSetting(string setting, string defaultvalue)
		{
			try
			{
				string value = System.Configuration.ConfigurationManager.AppSettings[setting];
				if (value == null)
					return defaultvalue;
				else
					return value;
			}
			catch
			{
				return defaultvalue;
			}
		}

		/// <summary>
		/// Get Application Settings
		/// </summary>
		/// <param name="setting"></param>
		/// <param name="separator"></param>
		/// <returns></returns>
		public static List<string> GetAppSettingList(string setting, char separator)
		{
			List<string> list = new List<string>();
			try
			{
				string value = System.Configuration.ConfigurationManager.AppSettings[setting];
				if (value != null)
				{
					list.AddRange(value.ToLower().Split(separator));
				}
			}
			catch
			{
			}

			return list;
		}

		/// <summary>
		/// Get AppSetting as boolean, throw exception if not defined.
		/// </summary>
		/// <param name="setting"></param>
		/// <returns></returns>
		public static bool GetAppSettingBoolean(string setting)
		{
			try
			{
				string svalue = System.Configuration.ConfigurationManager.AppSettings[setting];
				return Convert.ToBoolean(svalue, CultureInfo.InvariantCulture);
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.ToString());
				return false;
			}
		}


		/// <summary>
		/// Get AppSetting as boolean, throw exception if not defined.
		/// </summary>
		/// <param name="setting"></param>
		/// <param name="defaultvalue"></param>
		/// <returns></returns>
		public static bool GetAppSettingBoolean(string setting, bool defaultvalue)
		{
			try
			{
				string svalue = System.Configuration.ConfigurationManager.AppSettings[setting];
				if (svalue == null)
					return defaultvalue;
				else
					return Convert.ToBoolean(svalue, CultureInfo.InvariantCulture);
			}
			catch
			{
				return defaultvalue;
			}
		}

		/// <summary>
		/// Get AppSetting as integer, throw exception if not defined.
		/// </summary>
		/// <param name="setting"></param>
		/// <param name="defaulttime"></param>
		/// <returns></returns>
		public static DateTime GetAppSettingDateTime(string setting, DateTime defaulttime)
		{
			try
			{
				string svalue = System.Configuration.ConfigurationManager.AppSettings[setting];
				if (svalue == null)
					return defaulttime;
				else
					return DateTime.Parse(svalue, CultureInfo.InvariantCulture);
			}
			catch
			{
				return defaulttime;
			}
		}

		/// <summary>
		/// Get AppSetting as integer, throw exception if not defined.
		/// </summary>
		/// <param name="setting"></param>
		/// <returns></returns>
		public static int GetAppSettingInt(string setting)
		{
			try
			{
				string svalue = System.Configuration.ConfigurationManager.AppSettings[setting];
				return int.Parse(svalue);
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.ToString());
				return -1;
			}
		}

		/// <summary>
		/// Get AppSetting as integer, throw exception if not defined.
		/// </summary>
		/// <param name="setting"></param>
		/// <param name="defaultvalue"></param>
		/// <returns></returns>
		public static int GetAppSettingInt(string setting, int defaultvalue)
		{
			try
			{
				string svalue = System.Configuration.ConfigurationManager.AppSettings[setting];
				if (svalue == null)
					return defaultvalue;
				else
					return int.Parse(svalue);
			}
			catch
			{
				return defaultvalue;
			}
		}

	}
}