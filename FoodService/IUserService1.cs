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

		[OperationContract]
		int verifyUser(string userName, string password);

		[OperationContract]
		void updateUser(users user);

		[OperationContract]
		void AddUser(String first_name, String last_name, String username, String password, double? weight, double? height, bool? vegetarian, bool? vegan, bool? dairyfree, bool? glutenfree, bool? gender);

		[OperationContract]
		CompositeType GetDataUsingDataContract(CompositeType composite);

		[OperationContract]
		users FindUserByUsername(String username);

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