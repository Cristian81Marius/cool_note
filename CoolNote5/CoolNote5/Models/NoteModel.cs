using System.ComponentModel.DataAnnotations;
using CoolNote5;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CoolNote5.Models
{
    public class NoteModel : PageModel
    {
        [BindProperty, Required]
        public string Note
        {
            get => DataManager.Note;
            set => DataManager.Note = value;
        }

        public int EditsAmount
        {
            get => DataManager.EditsAmount;
            set => DataManager.EditsAmount = value;
        }

        public IActionResult OnPost()
        {
            EditsAmount++;
            return Redirect("/Index");
        }
    }
}