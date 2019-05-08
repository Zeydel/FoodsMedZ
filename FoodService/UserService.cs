using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Web.Script.Serialization;

namespace FoodService
{
	// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
	public class UserService : IUserService
	{
		public string GetUser(int value)
		{
			masterEntities m = new masterEntities();
			var userlst = from k in m.users where k.User_id == value select k;
			var user = new users();

			foreach (var usr in userlst)
			{
				user = usr;
			}
			return new JavaScriptSerializer().Serialize(user);
		}
		
		public int verifyUser(string userName, string password)
		{
			masterEntities m = new masterEntities();
			var userlst = from k in m.users where k.userName.Equals(userName) select k;
			foreach (var usr in userlst)
			{
				if (usr.password.Equals(password))
				{
					return usr.User_id;
				} else
				{
					return -2;
				}
			}
			return -1;
		}

		public void AddUser(string first_name, string last_name, string username, string password, double? weight, double? height, bool? vegetarian, bool? vegan, bool? dairyfree, bool? glutenfree, bool? gender)
		{
			masterEntities m = new masterEntities();
			users newUser = new users();
			newUser.First_name = first_name;
			newUser.Last_name = last_name;
			newUser.userName = username;
			newUser.password = password;
			newUser.weight = weight;
			newUser.height = height;
			newUser.vegetarian = vegetarian;
			newUser.vegan = vegan;
			newUser.dairyfree = dairyfree;
			newUser.glutenfree = glutenfree;
			m.users.Add(newUser);
			m.SaveChanges();
		}

		public void updateUser(users user)
		{
			masterEntities m = new masterEntities();
			m.Entry(user).State = System.Data.Entity.EntityState.Modified;
			m.SaveChanges();
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

		public users FindUserByUsername(string username)
		{
			masterEntities m = new masterEntities();
			var userlst = from k in m.users where k.userName.Equals(username) select k;

			foreach (var usr in userlst)
			{
				Console.WriteLine(usr.First_name);
				return usr;

			}
			return null;
		}
	}
}
