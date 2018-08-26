using Microsoft.Azure.ServiceBus;
using System;

namespace CommunicationsLibrary
{
	public class CommLibMain
	{
		#region Fields
		/// <summary>
		/// The Azure Service Bus connection string that we read from the app settings file.
		/// </summary>
		internal static string ServiceBusConnectionString;

		/// <summary>
		/// The Azure Service Bus queue name that we will use to send and receive messages.
		/// </summary>
		internal static string QueueName;

		/// <summary>
		/// The object we will use to interact with the Azure Service Bus queue.
		/// </summary>
		internal static IQueueClient QueueClient;
		#endregion Fields

		#region Constructors
		public CommLibMain()
		{
		}
		#endregion Constructors

		#region Properties
		#endregion Properties

		#region Methods
		#endregion Methods

		#region Event Handlers
		#endregion Event Handlers
	}
}
