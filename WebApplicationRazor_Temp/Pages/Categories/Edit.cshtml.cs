using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplicationRazor_Temp.Data;
using WebApplicationRazor_Temp.Models;

namespace WebApplicationRazor_Temp.Pages.Categories
{
    [BindProperties]
    public class EditModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        public Category Category { get; set; }
        public EditModel(ApplicationDbContext db)
        {
            _db = db;
        }
        public void OnGet( int? id)
        {
            if(id!=null && id!=0)   
            {
                Category = _db.Categories.Find(id); 
            }
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                _db.Categories.Update(Category);
                _db.SaveChanges();
                TempData["sucess"] = "Category updated sucessfully";
                return RedirectToPage("Index");
            }
            return Page();
        }
       
    }
}
