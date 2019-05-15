using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace FoodService
{
	// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
	[ServiceContract]
	public interface IUserService
	{
		
		[OperationContract]
		string GetUser(int value);

		/// <summary>
		/// Checks a username a password againts the database
		/// </summary>
		/// <param name="userName"></param>
		/// <param name="password"></param>
		/// <returns>A status </returns>
		[OperationContract]
		int verifyUser(string userName, string password);

		/// <summary>
		/// Updates a user in the database
		/// </summary>
		/// <param name="user"></param>
		[OperationContract]
		void updateUser(string user);

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
		[OperationContract]
		void AddUser(String first_name, String last_name, String username, String password, double? weight, double? height, bool? vegetarian, bool? vegan, bool? dairyfree, bool? glutenfree, bool? gender);

		/// <summary>
		/// Finds a user in the databse by username
		/// </summary>
		/// <param name="username"></param>
		/// <returns>Returns a user object</returns>
		[OperationContract]
		User FindUserByUsername(String username);

		[OperationContract]
		CompositeType GetDataUsingDataContract(CompositeType composite);


		// TODO: Add your service operations here
	}

	// Use a data contract as illustrated in the sample below to add composite types to service operations.
	// You can add XSD files into the project. After building the project, you can directly use the data types defined there, with the namespace "FoodService.ContractType".
	[DataContract]
	public class CompositeType
	{
		bool boolValue = true;
		string stringValue = "Hello ";

		[DataMember]
		public bool BoolValue
		{
			get { return boolValue; }
			set { boolValue = value; }
		}

		[DataMember]
		public string StringValue
		{
			get { return stringValue; }
			set { stringValue = value; }
		}

	}

}