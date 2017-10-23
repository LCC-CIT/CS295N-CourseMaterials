/* Lab 3 - Pig Game starter
 * 10/10/17
 */

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PigGame.Web.Pages
{
    public class IndexModel : PageModel
    {
        PigLogic game;

        static string PLAYER_NAME = "PlayerName";
        static string PLAYER1_SCORE = "Player1Score";
        static string PLAYER2_SCORE = "Player2Score";
        static string TURN_POINTS = "TurnPoints";
        static string TURN = "TURN";

        [BindProperty]
        public string PlayerName { get; set; }
        public int Roll { get; set; }
        public PigLogic Game
        {
            get { return game; }
        }

        public void OnGet()
        {
            game = new PigLogic();
        }

        public IActionResult OnPost()   // Enter name button
        {
            RetrieveGame();
            game.Player1Name = PlayerName;
            SaveGame();

            return Page();
        }

        public IActionResult OnPostRoll()   // Roll button
        {
            RetrieveGame();
            Roll = game.RollDie();
            SaveGame();

            return Page();
        }

        private void RetrieveGame()
        {
            int player1Score = HttpContext.Session.GetInt32(PLAYER1_SCORE) ?? 0;
            int player2Score = HttpContext.Session.GetInt32(PLAYER2_SCORE) ?? 0;
            int turnScore = HttpContext.Session.GetInt32(TURN_POINTS) ?? 0;
            int turn = HttpContext.Session.GetInt32(TURN) ?? 1;
            game = new PigLogic(player1Score, player2Score, turnScore, turn);
            game.Player1Name = HttpContext.Session.GetString(PLAYER_NAME);
        }

        private void SaveGame()
        {
            HttpContext.Session.SetInt32(PLAYER1_SCORE, game.Player1Score);
            HttpContext.Session.SetInt32(PLAYER2_SCORE, game.Player2Score);
            HttpContext.Session.SetInt32(TURN_POINTS, game.TurnPoints);
            HttpContext.Session.SetInt32(TURN, game.Turn);
            HttpContext.Session.SetString(PLAYER_NAME, game.Player1Name);

        }
    }
}
