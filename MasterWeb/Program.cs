using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace MasterWeb
{
	public class Program
    {
		#region Fields
		#endregion Fields

		#region Constructors
		#endregion Constructors

		#region Properties
		#endregion Properties

		#region Methods
		/// <summary>
		/// The app entry point.
		/// </summary>
		/// <param name="args"></param>
		public static void Main(string[] args)
		{
			CreateWebHostBuilder(args).Build().Run();
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="args"></param>
		/// <returns></returns>
		public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
			WebHost.CreateDefaultBuilder(args)
				.UseStartup<Startup>();
		#endregion Methods

		#region Event Handlers
		#endregion Event Handlers
	}
}
