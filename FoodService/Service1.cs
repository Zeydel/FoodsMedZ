using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace FoodService
{
	// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
	public class UserService : IUserService
	{
		public string GetUser(int value)
		{
			masterEntities m = new masterEntities();
			var user = from k in m.users where k.id == value select k;
			return user;
		}

		public void AddUser(String first_name, String last_name, String username, String password, double weight, double height, byte vegetarian, byte vegan, byte dairyfree, byte glutenfree)
		{
			user newUser = new user();
			newUser.First_name = first_name;
			newUser.Last_name = last_name;
			newUser.userName = username;
			newUser.password = password;
			newUser.weight = weight;
			newUser.height = height;
			newUser.
		}

		public CompositeType GetDataUsingDataContract(CompositeType composite)
		{
			if (composite == null)
			{
				throw new ArgumentNullException("composite");
			}
			if (composite.BoolValue)
			{
				composite.StringValue += "Suffix";
			}
			return composite;
		}
	}
}
