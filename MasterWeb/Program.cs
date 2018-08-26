using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace MasterWeb
{
	public class Program
    {
		#region Fields
		#endregion Fields

		/// <summary>
		/// The app entry point.
		/// </summary>
		/// <param name="args"></param>
		public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
