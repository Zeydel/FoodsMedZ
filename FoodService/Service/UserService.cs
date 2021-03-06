﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Web.Script.Serialization;

namespace FoodService
{
	public class UserService : IUserService
	{

		JsonSerializerSettings jsettings = SettingSingleton.GetJsonSerializerSettings();
		/// <summary>
		/// Gets one user from backend
		/// </summary>
		/// <param name="value">Id of the desired </param>
		/// <returns></returns>
		public string GetUser(int value)
		{
            masterEntities m = ContextSingleton.getContext();
			var userlst = from k in m.User where k.User_id == value select k;
			var user = new User();

			foreach (var usr in userlst)
			{
				user = usr;
			}
			m.Entry(user).State = System.Data.Entity.EntityState.Detached;
			return JsonConvert.SerializeObject(user, jsettings);
		}

		/// <summary>
		/// Checks a username a password againts the database
		/// </summary>
		/// <param name="userName"></param>
		/// <param name="password"></param>
		/// <returns>A status </returns>
		public int verifyUser(string userName, string password)
		{
			masterEntities m = ContextSingleton.getContext();
			var userlst = from k in m.User where k.userName.Equals(userName) select k;
			foreach (var usr in userlst)
			{
				if (usr.password.Equals(password))
				{
					return usr.User_id;
				}
				else
				{
					return -2;
				}
			}
			return -1;
		}

		/// <summary>
		/// Adds a user to the database
		/// </summary>
		/// <param name="first_name"></param>
		/// <param name="last_name"></param>
		/// <param name="username"></param>
		/// <param name="password"></param>
		/// <param name="weight"></param>
		/// <param name="height"></param>
		/// <param name="vegetarian"></param>
		/// <param name="vegan"></param>
		/// <param name="dairyfree"></param>
		/// <param name="glutenfree"></param>
		/// <param name="gender"></param>
		public void AddUser(string first_name, string last_name, string username, string password, double? weight, double? height, bool? vegetarian, bool? vegan, bool? dairyfree, bool? glutenfree, bool? gender)
		{
			masterEntities m = ContextSingleton.getContext();
			User newUser = new User();
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
            newUser.gender = gender; 
			m.User.Add(newUser);
			m.SaveChanges();
		}


		/// <summary>
		/// Updates a user in the database
		/// </summary>
		/// <param name="user"></param>
		public void updateUser(string str)
		{
			masterEntities m = ContextSingleton.getContext();
			RecipeService recipeclient = new RecipeService();
			
			User user = JsonConvert.DeserializeObject<User>(str, jsettings);
			User updateUser = JsonConvert.DeserializeObject<User>(GetUser(user.User_id), jsettings);
			updateUser.dairyfree = user.dairyfree;
			updateUser.favJokes = user.favJokes;
			updateUser.favTrivia = user.favTrivia;
			updateUser.favorites = user.favorites;
			updateUser.First_name = user.First_name;
			updateUser.gender = user.gender;
			updateUser.glutenfree = user.glutenfree;
			updateUser.height = user.height;
			updateUser.Last_name = user.Last_name;
			updateUser.password = user.password;
			updateUser.userName = user.userName;
			updateUser.User_id = user.User_id;
			updateUser.vegan = user.vegan;
			updateUser.vegetarian = user.vegetarian;
			updateUser.weight = user.weight;
			m.Entry(updateUser).State = System.Data.Entity.EntityState.Modified;
			
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

		/// <summary>
		/// Finds a user in the databse by username
		/// </summary>
		/// <param name="username"></param>
		/// <returns>Returns a user object</returns>
		public User FindUserByUsername(string username)
		{
			masterEntities m = ContextSingleton.getContext();
			var userlst = from k in m.User where k.userName.Equals(username) select k;

			foreach (var usr in userlst)
			{
				Console.WriteLine(usr.First_name);
				return usr;

			}
			return null;
		}
	}
}
