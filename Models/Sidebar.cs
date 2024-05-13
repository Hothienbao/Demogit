using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data;

namespace WebApplication1.Models
{
	public class Sidebar : ViewComponent
	{
		private readonly WebApplication1Context _context;

		public Sidebar(WebApplication1Context context)
		{
			_context = context;
		}
		/* Sidebar là một lớp kế thừa từ ViewComponent, là một thành phần giao diện trong ASP.NET Core.
		Trong constructor của Sidebar, WebApplication1Context được dependency injected để có thể tương tác với cơ sở dữ liệu. */
		public IViewComponentResult Invoke()
		{
			return View(_context.Category.ToList());
		}
		/* Phương thức Invoke() là một phương thức mặc định của ViewComponent được gọi khi component này được sử dụng.
		Trong phương thức này, _context.Category.ToList() được gọi để lấy danh sách các danh mục từ cơ sở dữ liệu (biến _context 
		là đối tượng của WebApplication1Context).
		Kết quả của phương thức Invoke() là một IViewComponentResult, thường là một View được sử dụng để render giao diện của component. */
	}
}

