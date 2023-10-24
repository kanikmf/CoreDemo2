using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.ViewComponents
{
	public class CommentList : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			var commentvalues = new List<UserComment>
			{
				new UserComment
				{
					ID = 1,
					Username = "Murat"
				},
				new UserComment
				{
					ID = 2,
					Username = "Mesut"
				},
				new UserComment
				{
					ID = 3,
					Username = "Merve"
				}
			};
			return View(commentvalues);
		}
	}
}
