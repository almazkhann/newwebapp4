using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPage1.Pages
{
    public class IndexModel : PageModel
    {
        public string Messege { get; set; }
        [BindProperty]
        public string? Email { get; set; }
        [BindProperty]
        public string? Password { get; set; }

        public void OnGet(string? email, string? pass)
        {
            if (pass != null && email != null)
            {
                Email = email;
                Password = pass;

            }
            else {  }
        }
        public void OnPost()
        {
            if (Password != null && Email != null)
            {
                Messege = $"Email: {Email}\nPassword: {Password}";
            }
            else { }
        }
    }
}
