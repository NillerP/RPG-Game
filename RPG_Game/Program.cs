using System.Runtime.Intrinsics.X86;
using RPG_GameLogic.GameManagement;
using RPG_GameLogic.Items.Weapons;
namespace RPG_Game
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Game game = new();
            await game.Start();
        }
    }
}
