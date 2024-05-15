using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data;

namespace WebApplication1.Models
{
	public class Search : ViewComponent
	{
		private readonly WebApplication1Context _context;

		public Search(WebApplication1Context context)
		{
			_context = context;
		}
		
		public IViewComponentResult Invoke()
		{
			return View(_context.Category.ToList());
		}
	}
}
