using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGameProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            
                SoundPlayer backgroundMusic = new SoundPlayer("John Williams - Duel of the Fates (Star Wars Soundtrack) [HQ].wav");
                backgroundMusic.Load();
                backgroundMusic.PlayLooping();
            
            ProgramUI game = new ProgramUI();
            game.Run();
        }
    }
}
