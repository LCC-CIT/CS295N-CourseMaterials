using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PigGame.Web.Pages
{
    public class IndexModel : PageModel
    {
        PigLogic game;

        [BindProperty]
        public string PlayerName { get; set; }
        public int Roll { get; set; }
        public PigLogic Game { 
            get { return game; }
        }      
        
        public void OnGet()
        {
            game = new PigLogic();
        }

        public IActionResult OnPost()
        {
            game = new PigLogic();
            game.Player1Name = PlayerName;
            return Page();
        }

        public IActionResult OnPostRoll()
        {
            game = new PigLogic();
            Roll = game.RollDie();
            return Page();
        }
    }
}
