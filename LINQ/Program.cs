namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> videoGames = new List<string>{
            "The Legend of Zelda: Breath of the Wild",
            "Super Mario Odyssey",
            "Red Dead Redemption 2",
            "The Witcher 3: Wild Hunt",
            "Grand Theft Auto V",
            "Minecraft",
            "Patapon",
            "Overwatch",
            "Dark Souls III",
            "Final Fantasy VII",
            "God of War",
            "Uncharted 4: A Thief's End",
            "Assassin's Creed Odyssey",
            "Call of Duty: Modern Warfare",
            "FIFA 22",
            "Rocket League",
            "Halo: Master Chief Collection",
            "Destiny 2",
            "Mortal Kombat 11",
            "Splatoon 2",
            "Animal Crossing: New Horizons",
            "Fallout 4",
            "DOOM Eternal",
            "Cuphead",
            "Stardew Valley",
            "Among Us",
            "League of Legends",
            "World of Warcraft",
            "Dota 2",
            "Fortnite",
            "Persona 5",
            "Monster Hunter: World",
            "Street Fighter V",
            "Cyberpunk 2077",
            "Genshin Impact",
            "Rainbow Six Siege",
            "Star Wars Jedi: Fallen Order",
            "Borderlands 3",
            "The Elder Scrolls V: Skyrim",
            "BioShock Infinite",
            "The Last of Us Part II",
            "Far Cry 5",
            "Tom Clancy's Ghost Recon Breakpoint",
            "Sekiro: Shadows Die Twice",
            "Diablo III",
            "Cities: Skylines",
            "SimCity"
            };
            Console.WriteLine("Unordered list:\n-------------------------");
            videoGames.ForEach(x => Console.WriteLine(x));

            Console.WriteLine("Ordered by title length:\n-------------------------");
            videoGames = videoGames.OrderBy(x => x.Length).ThenBy(x => x).ToList();
            videoGames.ForEach(x => Console.WriteLine(x));
        }
    }
}
