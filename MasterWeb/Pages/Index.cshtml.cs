using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MasterWeb.Pages
{
    public class IndexModel : PageModel
    {
        public void OnGet()
        {

        }

	    public int UnfilledShifts { get; set; }
	    public int UrgentNotifications { get; set; }
	    public int ActiveProjects { get; set; }
	    public List<object> Assignments { get; set; }
    }
}
