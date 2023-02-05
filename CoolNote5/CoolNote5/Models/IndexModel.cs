using CoolNote5;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CoolNote5.Models
{
    public class IndexModel : PageModel
    {
        public string Note  => DataManager.Note;
        public int EditsAmount => DataManager.EditsAmount; 
    }
}