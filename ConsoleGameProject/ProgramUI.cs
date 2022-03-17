using ConsoleGameProject.Opponent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleGameProject
{
    public class ProgramUI
    {
        public void Run()
        {
            bool continueToRun = true;
            while (continueToRun)
            {
                Console.Clear();
                Console.WriteLine("Welcome to the Coliseum! \n" +
                    "Do you have what it takes to become the Champion?\n" +
                    "Defeat these 4 contenders and claim your spot on the pantheon of Champions!\n" +
                    "Each fight can not take longer than 6 rounds!\n" +
                    "Fortune favors the bold!!\n\n\n");
                Console.WriteLine(
                    ". ...                          .......:,  .........   ....,..   ...,,,,,,,,:,,,,,,,,,:::::,:,,,,,,.....,,,,,\n" +
                    ".                                      ;;           ,,   :&BX&2:      .........     .....                 ..\n" +
                    ".                                      ,i9,      .;Ss...rh@@@@@@@5  ,,,,,,,,,:,,,,,,,,,,,,,,,,,,,,,,,,,,,,:.\n" +
                    "                                        .2#:     ;;,. :r5&BB@@@@@@@  ,,,,,,,:,,,,,,,.,,,,,,,,,,,,,,,,,,,,,,.\n" +
                    "                                         ,S@r   ,:,,    :iG#@@@@@@@# .,,,,:,,,,:,,,,.,,,,,,,,,,,,,,,,,,,,,,.\n" +
                    "                                         .s5@;  ;.      ;i3M@@@@@@@@S ,,,,,,,,,:,,,,,,,,,,,,,:::::,:::::,,,.\n" +
                    "  .                                        sB@       .sX5XXA#@###@@@H ,:::,,,,,,,,,,,,,,,,,,,::::::::::::::.\n" +
                    ". .                                         r@#    ..,@@HMXAB#@##@@@@ ,::,,,,,,,,,,,,,,,,,,,:::::::::;:::::.\n" +
                    ".                                            r@;      A2hM@@@####@@@@..::,,,,,,,,,,::,,,,,,,,::::::::::::::,\n" +
                    ".                                             r       9#H#@#####@@@@@;.::,,,,,,,,,,,:,,,,,,,:::::::::::::::,\n" +
                    "                                                  rM@M2hhB#@@##HAM@@@;.::,,,,,,,,,,,,,,,,,,,:::::::::::::::,\n" +
                    "  ..                                         ..:@@@Girhih&2AB##MMB#@@; ::,,,,,,,,,,,,,,.,,,,,::::::::::::::,\n" +
                    ". .                                           h@h:,:5S5hH@@@@##A9B9@@r ,:,,,,,,,,.,,,,,,,,,,:::::::::::::::,\n" +
                    ". .                                           r, .   r23A@@M#@&M@MH@@s ,,,,,,,,,,,,,,,,,,,,,:::::::::::::::,\n" +
                    ".                            ......... ...    r     ,s2i&@#B##3S#@@@@r .,,,.,,,,,,,,,,,,,,,::::::::::::::::,\n" +
                    "                           .................  .     rS&Gh@##@@&iA@@@@s ..,,,,,,,,,,,,,,::::::::::::::::::::,\n" +
                    "      .   ..  ..      .   ..................     .:,srhiA@@#@@Ar2@@@@@  .,,,,,,,,,,,,::::::::::::::::::::::,\n" +
                    "     ..  .  .....    .   ........,,,........     ,:;XrA5A@M#@@@23@#M@@, ,,.,,,,,,,,,:::::::::::::::::::::::,\n" +
                    "   .,.  .   .,...   .   ........,,,,,,,.,.,..   .,;rArHS9@H#@#@2:M#H#@: ........,,,:::::;::::::::::::::::::,\n" +
                    "  ... ..   .,.,.  ...  .........,,,,,,,,,,,;;   ,:rSHS2r3@M#@@@GrA@M#@, .......,,,:::::;;;;::::::::::::::::,\n" +
                    "  .. ..    ,,,,. ...  ...........,,,,,,,,,,:    ,:i2Hr5sG@#@@@@B3h#@@@  ....,,,,,,:::::;::;;;;;;;;;;:::::::,\n" +
                    ". . ..    ,,,,. ...  .........,,,,,,,,,,,,:.  . ::s5A;HGH@@@@@@#M#@@@#  ...,,,,,,::::;;;;;;;;;;;;;;;;:::,::,\n" +
                    ". .,.    ,,::, .:,...,,.,,,,,,,,,,,,,,,,:::.    ;iXHM3###@###BA@@@@@@&  ...,,,::::::::;;;;;;;;;;;;;;;;::,::,\n" +
                    ". ,,    ,::;:..,:,,,:;:::::::::::::::::::::  ,;rXsir9@#&@H&M#MA@@@@#@@GS;..,,::::::;;;;;;;;;;;;;;rrrrrrr;;;:\n" +
                    "..,    ,::;:. ,:,,:;;;;;;;;;;;;::::::::::::,:;.,XG#S@@#AB33#@@H3r:;;s&#@@B;.,,::::;;;;;;;;;;;;rrrssssrrrrrr:\n" +
                    ",     .,,::. ,:,,,::,,,::::::::;;;;;;;;;;:. .,rA#@#M@##&#@@@#MAX59ABM##@@@@::rsssisrrr;;;;;;;;rrrrssrr;;;;;,\n" +
                    ".    .,,::. ,:,.,,,,.,,,,:::::::;;;;;;;r:   M@@###MM@@@@@@2:rG@@@@@@@@@@@@#M#@@@@@@@@@@##BHA&&&9X5s;:::::::,\n" +
                    "    .,:::, ,:,,::::::::::::::;;;;;;;rrr;  r@@@@@@@@@@@@@Asr2B@@@@@@@@@@@M#@#HA&A#@@@@@@@@@@@@@@##@@H5;,::::,\n" +
                    "   ,::;;:.,;:,:;rrrrrr;;;;;;;rrrrrrrrrr:r@@@@@@@@@@@@MA&H@@@@@@@@@@M5:,:r23&G35siS3AM##@@@@@@@@##@@@@#X:::;:\n" +
                    "  ,:;;r:.,;;::rrrrrrrrrrrrrrssiiisrrrsrr@@@@@@@BXr.  :s&#@@@@@@#5:     ,:,::;rS2XGA&AAB##MMBHB#@@@@@@@i;rrr:\n" +
                    "  :;;;, .:;,:;rrrrrrrrsssiiisr;::;;rr:. ,.      ,;;rXMMM@@@@&;      ...,:,,,:::;i9A&GAAHH###BAH#@@##@@Xriii;\n" +
                    "..:::,..,,,,:::;;rrrssiiSs;:,,:;;s5B;    .;s;:iM@@@@@@@@@Ar     .,,...,:;;;rs23339ABHHBMAAM#@##M#@@@H2s;;rSr\n" +
                    ":,::;ii5i;;rirsssi5Sisrr:..,r2GBMhS2r,X@@@@@@@@@@@#@@@#r     ,::,   .,:;;;riXAM##BAHHBB#MGhAH####@@@@i .,;ir\n" +
                    ":,rS2XXXirs2hXr;;;;,. .,:;s2AMGr.   X#@@@HA#@@@@@@@@Ar     ,:,,.,2:.:;rr;;s29GA##MHAHM#@M###MBB#@@@@@@@iriSs\n" +
                    ";;S2225s;r29:  ::,..,rrriXM#S.       ;SA#####MM##Ai:    .,,..   5@9;siS5SS52XX9AB######@@#@@@#B##@@@@@@Ar55i\n" +
                    "rsXS532rriX5ri92sr;;i5ShB@3             ...,,:;;;.    .,:,,,,:;h@@irsiS5X9339G&AH######@@@@@@@@@M@@@@@@@2sis\n" +
                    "ssr;rrsssiiir:::r22X2XA#H,     ..,:          :  ,.   ..,:,,rB@@@#i;i222X9&&AAHHHH#####@@@@@#@@@@@@@@@@@@@9rs\n" +
                    "srsisrsrrr;,.,,;ssShAB@S  .. .. ,r;,         ,:,:sr ..,.,:;###M@9;i9G&&AAAAHHBMM###MM#@@@@@@@@@@@@@29@@@@@Sr\n" +
                    "r;rr;;:;;r;rGh2isiG##B##;;rr:.  :s:;:,       .r::;i.,,;XAHBHAH#@Xi3&AAAHBMMMM#####MMM#@@@@@@@@###@@9 M@@@@@2\n" +
                    "r;r;,..::rr;sGXiiH@BA&@@@2G2:    rr;rii   .  r;;;;i,:sBMHHHA&BH329AAHB##########MMMM#@@@@@##@@###@@# .@#ASri\n" +
                    "r;r;:;55,  .2BX2H#Ah3A@@@#2,      r;::rr;:  .s;rss5h9A99AAAGMAiS3GAM############MBBM###@@@@#@@@###@@; Hs ..,\n" +
                    "s;iSSXA2r::5M52HMA322#@@@3,  ...  :S;;:;;sr:irrrrsi5X23AHAABASi2XhAM#####MMMM#MBBBB#@##@@@#######M#@2;rs;:;;\n" +
                    "r;siii22XX3BXXA&&GX2H@#@@r,,,::,.  ,:s;:;rS2s;:.  ,,:r2HAAMhiSXG&&#@@@##@#MHHBHHHBB#@##@@@###@#####@9rsisrr;\n" +
                    "s;iSissi2AB99A&hG9G#@#@M:;:,,,:;;,.  ;Xiss:,:      ,,.:2AAA52hGAHM;s9hh9iH#BHAAAAHM@@#@@@@@########@M,...,;r\n" +
                    "SSXX2S2X9GGAMBAAAB@@##@@ 2Hs;;: .;:,,.:,s5;   .., .,:,,:SB&9AM#MB@  A3X2X##BMHAAAA#@##@@@@@@#######@@:  ,::r\n" +
                    "2ss52i52259hS5325#@###@@:A@G552i :;,.   rs,   :;..,;s;:;2H#######@r.@H&hH#MB#@MHAB#BM#@@##@@@######@@S;irsii\n" +
                    "5iXXX2222X2s;rssi2@#B#@@:h@#HGA3 :;r2i.;s; .;; .,::s:rr.:A.##.h##@3;@@@@#MM# 2@;X;r;,@s;G:r@@@####@@@r,;r235\n" +
                    "5i5irssssss;rr;rr5#@#@@@;X@#@#h,r&,r9X,,;;.  :  :,;: ;r. A BB &@#@2.@@@@@@@@& rXS @@A@;;@A @@@@@###@#:,,S&G2\n" +
                    "Sr;,  ,:;:.,::::;;i@@@@@.i@iSSX@@@AsSsrs;::  .  ,;s;..,.iHi9&SA#@@; @#######@As@#h9Hh@A&@#2@@@#####@@S.rhAh5\n" +
                    "i;:,  ,,,.,;:,;;, ,@@#@#;XBSri@@@@#i;sr :r;;.. .:,;;r::rhAHB##X59Msr32X352i2@@@X3@@@@@@@@@@@@###@##@@@AXG9XS\n" +
                    "r;sr;;;::;s;,,;;;,,@@@@@@@@@H,3@hGs,.  :ir;;;:,...r::rXhAX:;riS5XG#@##@@@@@@##MA@@@@@@@@@@#@@@#@@##@@@@MiSSs\n" +
                    "rr2225Sii55s;;rrr;;i:5233@@@@53HXi,,,.;9r;rrssrr;;,;55SSXi.,:;X2XhABM######@#&X3hS@@@@@@@@@@@@##@@@@@@@@Xrir\n" +
                    "iiX393XXXX25iiSisri: @AX 3@@@@3s2:,,;2hr;ir.,rssS5r5ri.i5X9hr G3X3hAM#####@25A#@@M@@@@@#@@@@@@@@##@@@@@@@rrr\n" +
                    "55XXX5SSSS55isiSSihX AAB@@@@@@@9;,;GAG2S5r . r5riS5G:r.AAHM@B.AhAhAMM@@###@  932Xh#@@@@@@@@@@@@522 #@@@@@9rr\n" +
                    "5S2SSs;rsrrsrrri5SAB,@@@@@;r5A#3  &SrX:, ... ,;sii5&:: B#HB#M.r;,AXrr,A@##@@XXXss; 29r@A,@;52,##@S3@@@@@@r;:\n" +
                    "irsrr;::;r;;;;;rsr#B.@##@@ S@@2G. @;.s., .  ,.rSi2Ai;r s#@#@A:@# A 2#G&@##@@@@@@@@.:5.@3 @ A@:s@@X@@@@@@:  .\n" +
                    "s;;;;;;rssssiSSsrs@3 @H&M@iH@#;25;#;r9s2;r;.,.r9XAS:rr :sXhMHr@@;@SrAX&@@X,#@@@#BS @@rH2s@s#@2X@#s@@M3M@.::.\n" +
                    "r:;;;rrsiS2XX9X2rX@G;@@#@@@@@@@M#@h2M@#BAGhXsA#BH#s:rr.iii2h@@@@@@@@#@@##@XS5XSSr,5@@@@@@@@@@@@@@@@#M3#@X&Ai\n" +
                    "r;srrrsiS52X2X2si#@@@#@@@@@@@@@&XXhA@####MMHG####HiSS5939GAM@@@@@@@@@##M##@@@##@#2XM@@@@@@@@@@@@@@@@@@@@2ShS\n" +
                    "iiSsi2SiX25iii5H@###@@@###@@@@32&HM#@#M##@@MA####52X99hG&H#@@@@@@@@@#########@@@@@MM#@@@@@@@@@@@@@@@@@@@i:i;\n" +
                    "5iirr52i2XSS52@@##@########@@M5GM###@#M##@@##@@@#&AHHAAHB#@@##M@@@@@@@###MMM#@@@@@###@@@@@@@@@@@@@@@@@@@@sS;\n" +
                    "2r:;i2X255is2@@##@@####@@#@@@&GH##########@@#@@@#####M##@@@###M##@###@@@@####@@@@@@###@@@@@@@@@@@@@@@@@@@22S\n" +
                    "Srriiisrssrr2######@@@@@@@@@#AAAM##M###MMM#M#@@#MMMMBBBM################################@@@@@@@@@@@@@@@@@XiS\n\n\n");
                
                AnyKey();
                Console.Clear();
                Console.WriteLine("Your next opponent is"); 
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(" Aethered the Unready\n"); 
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("He doesn't have many weapons...just a club...\n" +
                    "He does seem rather unready...");
                Fight(new Aethelred_Unready());

                Console.WriteLine("Your next opponent is");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write(" Maximus the Ready\n");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine( "He seems very dangerous.\n" +
                    "He is flourishing his sword with some skill!!");
                Fight(new Maximus_Ready());

                Console.WriteLine("Your next opponent is");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(" Arjuna the Archer!!");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine( "They are very confident their abilities!\n" +
                    "Look out for his bow!");
                Fight(new Arjuna());

                Console.WriteLine("Your next opponent is");
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine(" Radahn the Powerfull");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("His immense size is very intimidating.\n" +
                    "Watch out for his heavy blows!");
                Fight(new Radahn_Prepared());
                Thread.Sleep(2000);
                Console.WriteLine(
                    "██    ██  ██████  ██    ██     ██     ██ ██ ███    ██\n" +
                    " ██  ██  ██    ██ ██    ██     ██     ██ ██ ████   ██\n" +
                    "  ████   ██    ██ ██    ██     ██  █  ██ ██ ██ ██  ██\n" +
                    "   ██    ██    ██ ██    ██     ██ ███ ██ ██ ██  ██ ██\n" +
                    "   ██     ██████   ██████       ███ ███  ██ ██   ████\n");
                Thread.Sleep(800);
                foreach (char letter in"........")
                {
                    
                    Thread.Sleep(800);
                    Console.WriteLine(letter);
                }
                Console.WriteLine("The crowd is still craves more action has decided there shall be more bloodshed!");
                AnyKey();
                Console.Clear();
                Console.WriteLine($"SURPRISE!! There is another Champion already! \n" +
                    $"Your next opponent is");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine(" Jacob the Unstoppable!!!");
                Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine($"What hope do you possibly have?");
                Fight(new Jacob_Unstoppable());

                Console.WriteLine("You are now the Champion of the Coliseum!\n" +
                    "Be ready! Your own challengers are coming in now!");
                AnyKey();
            }
        }
        public void Fight(IOpponent opponent)
        {


            bool fight = true;
            int opponentHealth = 3;
            int userHealth = 3;
            int turns = 0;
            while (fight)
            {
                turns = turns + 1;
                Thread.Sleep(2000);
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"Please select a weapon to use against {opponent.Name}");
                Console.WriteLine("1. Club, heavey and slow, could over power a sword or bow\n" +
                    "2. Sword, solid and quick, could outreach a dagger or bow\n" +
                    "3. Dagger, light and fast, could slip inside a club or around a shield\n" +
                    "4. Bow, has reach, outreaches a dagger and outlasts a shield\n" +
                    "5. Shield, good defense, blocks out swords and clubs");
                string userattack = Console.ReadLine().ToLower();
                switch (userattack)
                {
                    case "1":
                    case "club":
                        //Attack with club
                        string opponentattack = opponent.Attack();
                        switch (opponentattack)
                        {
                            case "Club":
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("Nothing happens both your clubs trade blows. Your hands sting from the impact.");
                                break;
                            case "Bow":
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("You rush in with and bash their hands!\n" +
                                    "Their bow spins out of their hands.");
                                opponentHealth = opponentHealth - 1;
                                Console.WriteLine($"{opponent.Name}'s health is at {opponentHealth}");
                                break;
                            case "Sword":
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine($"You smack the sword out of {opponent.Name} and they take a hit!\n" +
                                    $" You see some teeth on the ground, thankfully not yours.");
                                opponentHealth = opponentHealth - 1;
                                Console.WriteLine($"Your health is at {userHealth}");
                                Console.WriteLine($"{opponent.Name} health is at {opponentHealth}");
                                break;
                            case "Shield":
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine($"Your club crashes off their shield!\n" +
                                    $"It bounces back and hits you in the face!!!");
                                userHealth = userHealth - 1;
                                Console.WriteLine($"Your health is at {userHealth}");
                                Console.WriteLine($"{opponent.Name} health is at {opponentHealth}");
                                break;
                            case "Dagger":
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine($"{opponent.Name} pulls out a dagger and swiftly stabs you before you can swing your club.\n" +
                                    $"Ooooooh thats gotta hurt!");
                                userHealth = userHealth - 1;
                                Console.WriteLine($"Your health is at {userHealth}");
                                Console.WriteLine($"{opponent.Name} health is at {opponentHealth}");
                                break;
                            default:
                                Console.WriteLine("Jacob uses STACK OVERFLOW");
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("You died");
                                Console.WriteLine("┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼");
                                Console.WriteLine("███▀▀▀██┼███▀▀▀███┼███▀█▄█▀███┼██▀▀▀");
                                Console.WriteLine("██┼┼┼┼██┼██┼┼┼┼┼██┼██┼┼┼█┼┼┼██┼██┼┼┼");
                                Console.WriteLine("██┼┼┼▄▄▄┼██▄▄▄▄▄██┼██┼┼┼▀┼┼┼██┼██▀▀▀");
                                Console.WriteLine("██┼┼┼┼██┼██┼┼┼┼┼██┼██┼┼┼┼┼┼┼██┼██┼┼┼");
                                Console.WriteLine("███▄▄▄██┼██┼┼┼┼┼██┼██┼┼┼┼┼┼┼██┼██▄▄▄");
                                Console.WriteLine("┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼");
                                Console.WriteLine("███▀▀▀███┼▀███┼┼██▀┼██▀▀▀┼██▀▀▀▀██▄┼");
                                Console.WriteLine("██┼┼┼┼┼██┼┼┼██┼┼██┼┼██┼┼┼┼██┼┼┼┼┼██┼");
                                Console.WriteLine("██┼┼┼┼┼██┼┼┼██┼┼██┼┼██▀▀▀┼██▄▄▄▄▄▀▀┼");
                                Console.WriteLine("██┼┼┼┼┼██┼┼┼██┼┼█▀┼┼██┼┼┼┼██┼┼┼┼┼██┼");
                                Console.WriteLine("███▄▄▄███┼┼┼─▀█▀┼┼─┼██▄▄▄┼██┼┼┼┼┼██▄");
                                Console.WriteLine("┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼");
                                fight = false;
                                Console.WriteLine("Restart?.......\n" +
                                    "1. Yes\n" +
                                    "2. No");
                                string retry = Console.ReadLine().ToLower();
                                switch (retry)
                                {
                                    case "1":
                                    case "Yes":
                                    case "y":
                                        var info = new System.Diagnostics.ProcessStartInfo(Environment.GetCommandLineArgs()[0]);
                                        System.Diagnostics.Process.Start(info);
                                        Environment.Exit(0);
                                        break;
                                    case "2":
                                    case "No":
                                    case "n":
                                        Environment.Exit(0);
                                        break;
                                }
                                break;
                        }
                        break;
                    case "2":
                    case "sword":
                        //Attack with sword
                        opponentattack = opponent.Attack();
                        switch (opponentattack)
                        {
                            case "Club":
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine($"The opponent {opponent.Name} bashes you in the head.\n" +
                                    $"You spit some teeth out on the ground.");
                                userHealth = userHealth - 1;
                                Console.WriteLine($"Your health is at {userHealth}");
                                Console.WriteLine($"{opponent.Name} health is at {opponentHealth}");
                                break;
                            case "Shield":
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine($"{opponent.Name} delfects your sword and knocks you down.\n" +
                                    $"You get up feeling winded and with some broken ribs");
                                userHealth = userHealth - 1;
                                Console.WriteLine($"Your health is at {userHealth}");
                                Console.WriteLine($"{opponent.Name} health is at {opponentHealth}");
                                break;
                            case "Sword":
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("Both your swords clash however.... nothing happens! \n" +
                                    "Someone yells that your fight is boring.");
                                break;
                            case "Bow":
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("You slice through their armor as they ready an arrow.\n" +
                                    "You flick the blood off your sword and stand ready.");
                                opponentHealth = opponentHealth - 1;
                                Console.WriteLine($"Your health is at {userHealth}");
                                Console.WriteLine($"{opponent.Name} health is at {opponentHealth}");
                                break;
                            case "Dagger":
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine($"You shank your opponent.\n" +
                                    $"They gasp in pain as the blade slides between their ribs.");
                                opponentHealth = opponentHealth - 1;
                                Console.WriteLine($"Your health is at {userHealth}");
                                Console.WriteLine($"{opponent.Name} health is at {opponentHealth}");
                                break;
                            default:
                                Console.WriteLine("Jacob uses STACK OVERFLOW");
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("You died");
                                Console.WriteLine("┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼");
                                Console.WriteLine("███▀▀▀██┼███▀▀▀███┼███▀█▄█▀███┼██▀▀▀");
                                Console.WriteLine("██┼┼┼┼██┼██┼┼┼┼┼██┼██┼┼┼█┼┼┼██┼██┼┼┼");
                                Console.WriteLine("██┼┼┼▄▄▄┼██▄▄▄▄▄██┼██┼┼┼▀┼┼┼██┼██▀▀▀");
                                Console.WriteLine("██┼┼┼┼██┼██┼┼┼┼┼██┼██┼┼┼┼┼┼┼██┼██┼┼┼");
                                Console.WriteLine("███▄▄▄██┼██┼┼┼┼┼██┼██┼┼┼┼┼┼┼██┼██▄▄▄");
                                Console.WriteLine("┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼");
                                Console.WriteLine("███▀▀▀███┼▀███┼┼██▀┼██▀▀▀┼██▀▀▀▀██▄┼");
                                Console.WriteLine("██┼┼┼┼┼██┼┼┼██┼┼██┼┼██┼┼┼┼██┼┼┼┼┼██┼");
                                Console.WriteLine("██┼┼┼┼┼██┼┼┼██┼┼██┼┼██▀▀▀┼██▄▄▄▄▄▀▀┼");
                                Console.WriteLine("██┼┼┼┼┼██┼┼┼██┼┼█▀┼┼██┼┼┼┼██┼┼┼┼┼██┼");
                                Console.WriteLine("███▄▄▄███┼┼┼─▀█▀┼┼─┼██▄▄▄┼██┼┼┼┼┼██▄");
                                Console.WriteLine("┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼");
                                fight = false;
                                Console.WriteLine("Restart?.......\n" +
                                    "1. Yes\n" +
                                    "2. No");
                                string retry = Console.ReadLine().ToLower();
                                switch (retry)
                                {
                                    case "1":
                                    case "Yes":
                                    case "y":
                                        var info = new System.Diagnostics.ProcessStartInfo(Environment.GetCommandLineArgs()[0]);
                                        System.Diagnostics.Process.Start(info);
                                        Environment.Exit(0);
                                        break;
                                    case "2":
                                    case "No":
                                    case "n":
                                        Environment.Exit(0);
                                        break;
                                }
                                break;
                        }
                        break;
                    case "3":
                    case "dagger":
                        //Attack with dagger
                        opponentattack = opponent.Attack();
                        switch (opponentattack)
                        {
                            case "Club":
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("You. Just. Keep. Shanking. Them.\n" +
                                    "Someone yells from the crowd to stop!");
                                opponentHealth = opponentHealth - 1;
                                Console.WriteLine($"Your health is at {userHealth}");
                                Console.WriteLine($"{opponent.Name} health is at {opponentHealth}");
                                break;
                            case "Shield":
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("You slip around their shield and Just. Keep. Shanking. Them.\n" +
                                    "It's a little much honestly");
                                opponentHealth = opponentHealth - 1;
                                Console.WriteLine($"Your health is at {userHealth}");
                                Console.WriteLine($"{opponent.Name} health is at {opponentHealth}");
                                break;
                            case "Sword":
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine($"{opponent.Name} slashes open your guts. \n" +
                                    $"Breathing becomes very difficult.");
                                userHealth = userHealth - 1;
                                Console.WriteLine($"Your health is at {userHealth}");
                                Console.WriteLine($"{opponent.Name} health is at {opponentHealth}");
                                break;
                            case "Bow":
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine($"As you rush in {opponent.Name} hits you with an arrow!\n" +
                                    $"Someone calls out 'Nice Shot!' ");
                                userHealth = userHealth - 1;
                                Console.WriteLine($"Your health is at {userHealth}");
                                Console.WriteLine($"{opponent.Name} health is at {opponentHealth}");
                                break;
                            case "Dagger":
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine($"Two daggers clang off each other, nothing happens!");
                                break;
                            default:
                                Console.WriteLine("Jacob uses STACK OVERFLOW");
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("You died");
                                Console.WriteLine("┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼");
                                Console.WriteLine("███▀▀▀██┼███▀▀▀███┼███▀█▄█▀███┼██▀▀▀");
                                Console.WriteLine("██┼┼┼┼██┼██┼┼┼┼┼██┼██┼┼┼█┼┼┼██┼██┼┼┼");
                                Console.WriteLine("██┼┼┼▄▄▄┼██▄▄▄▄▄██┼██┼┼┼▀┼┼┼██┼██▀▀▀");
                                Console.WriteLine("██┼┼┼┼██┼██┼┼┼┼┼██┼██┼┼┼┼┼┼┼██┼██┼┼┼");
                                Console.WriteLine("███▄▄▄██┼██┼┼┼┼┼██┼██┼┼┼┼┼┼┼██┼██▄▄▄");
                                Console.WriteLine("┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼");
                                Console.WriteLine("███▀▀▀███┼▀███┼┼██▀┼██▀▀▀┼██▀▀▀▀██▄┼");
                                Console.WriteLine("██┼┼┼┼┼██┼┼┼██┼┼██┼┼██┼┼┼┼██┼┼┼┼┼██┼");
                                Console.WriteLine("██┼┼┼┼┼██┼┼┼██┼┼██┼┼██▀▀▀┼██▄▄▄▄▄▀▀┼");
                                Console.WriteLine("██┼┼┼┼┼██┼┼┼██┼┼█▀┼┼██┼┼┼┼██┼┼┼┼┼██┼");
                                Console.WriteLine("███▄▄▄███┼┼┼─▀█▀┼┼─┼██▄▄▄┼██┼┼┼┼┼██▄");
                                Console.WriteLine("┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼");
                                fight = false;
                                Console.WriteLine("Restart?.......\n" +
                                    "1. Yes\n" +
                                    "2. No");
                                string retry = Console.ReadLine().ToLower();
                                switch (retry)
                                {
                                    case "1":
                                    case "Yes":
                                    case "y":
                                        var info = new System.Diagnostics.ProcessStartInfo(Environment.GetCommandLineArgs()[0]);
                                        System.Diagnostics.Process.Start(info);
                                        Environment.Exit(0);
                                        break;
                                    case "2":
                                    case "No":
                                    case "n":
                                        Environment.Exit(0);
                                        break;
                                }
                                break;
                        }
                        break;
                    case "4":
                    case "Bow":
                        opponentattack = opponent.Attack();
                        switch (opponentattack)
                        {
                            case "Club":
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("As you ready an arrow the club blindsides you in the head\n" +
                                    "Your ears wont stop ringing!");
                                userHealth = userHealth - 1;
                                Console.WriteLine($"Your health is at {userHealth}");
                                Console.WriteLine($"{opponent.Name} health is at {opponentHealth}");
                                break;
                            case "Shield":
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("You keep shooting until you get a hit!\n" +
                                    "They can't block them all!!");
                                opponentHealth = opponentHealth - 1;
                                Console.WriteLine($"Your health is at {userHealth}");
                                Console.WriteLine($"{opponent.Name} health is at {opponentHealth}");
                                break;
                            case "Sword":
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine($"{opponent.Name} slashes open your guts. \n" +
                                    $"Breathing becomes very difficult.");
                                userHealth = userHealth - 1;
                                Console.WriteLine($"Your health is at {userHealth}");
                                Console.WriteLine($"{opponent.Name} health is at {opponentHealth}");
                                break;
                            case "Bow":
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine($"You both shoot arrows and they collide in mid-air!!\n" +
                                    $"Someone calls out 'Nice Shot!' ");
                                Console.WriteLine($"Your health is at {userHealth}");
                                Console.WriteLine($"{opponent.Name} health is at {opponentHealth}");
                                break;
                            case "Dagger":
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine($"{opponent.Name} gets their dagger ready as your arrow strikes them!\n" +
                                    $"Ooooo thats has got to hurt! (Them, not you)");
                                opponentHealth = opponentHealth - 1;
                                Console.WriteLine($"Your health is at {userHealth}");
                                Console.WriteLine($"{opponent.Name} health is at {opponentHealth}");
                                break;
                            default:
                                Console.WriteLine("Jacob uses STACK OVERFLOW");
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("You died");
                                Console.WriteLine("┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼");
                                Console.WriteLine("███▀▀▀██┼███▀▀▀███┼███▀█▄█▀███┼██▀▀▀");
                                Console.WriteLine("██┼┼┼┼██┼██┼┼┼┼┼██┼██┼┼┼█┼┼┼██┼██┼┼┼");
                                Console.WriteLine("██┼┼┼▄▄▄┼██▄▄▄▄▄██┼██┼┼┼▀┼┼┼██┼██▀▀▀");
                                Console.WriteLine("██┼┼┼┼██┼██┼┼┼┼┼██┼██┼┼┼┼┼┼┼██┼██┼┼┼");
                                Console.WriteLine("███▄▄▄██┼██┼┼┼┼┼██┼██┼┼┼┼┼┼┼██┼██▄▄▄");
                                Console.WriteLine("┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼");
                                Console.WriteLine("███▀▀▀███┼▀███┼┼██▀┼██▀▀▀┼██▀▀▀▀██▄┼");
                                Console.WriteLine("██┼┼┼┼┼██┼┼┼██┼┼██┼┼██┼┼┼┼██┼┼┼┼┼██┼");
                                Console.WriteLine("██┼┼┼┼┼██┼┼┼██┼┼██┼┼██▀▀▀┼██▄▄▄▄▄▀▀┼");
                                Console.WriteLine("██┼┼┼┼┼██┼┼┼██┼┼█▀┼┼██┼┼┼┼██┼┼┼┼┼██┼");
                                Console.WriteLine("███▄▄▄███┼┼┼─▀█▀┼┼─┼██▄▄▄┼██┼┼┼┼┼██▄");
                                Console.WriteLine("┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼");
                                fight = false;
                                Console.WriteLine("Restart?.......\n" +
                                    "1. Yes\n" +
                                    "2. No");
                                string retry = Console.ReadLine().ToLower();
                                switch (retry)
                                {
                                    case "1":
                                    case "Yes":
                                    case "y":
                                        var info = new System.Diagnostics.ProcessStartInfo(Environment.GetCommandLineArgs()[0]);
                                        System.Diagnostics.Process.Start(info);
                                        Environment.Exit(0);
                                        break;
                                    case "2":
                                    case "No":
                                    case "n":
                                        Environment.Exit(0);
                                        break;
                                }
                                break;
                        }
                        break;
                    case "5":
                    case "shield":
                        opponentattack = opponent.Attack();
                        switch (opponentattack)
                        {
                            case "Club":
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Your shield deflects the club back at their face!\n" +
                                    "Now THAT is funny!");
                                opponentHealth = opponentHealth - 1;
                                Console.WriteLine($"Your health is at {userHealth}");
                                Console.WriteLine($"{opponent.Name} health is at {opponentHealth}");
                                break;
                            case "Shield":
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("You both just stand there with shields....\n" +
                                    "It's quite until someone from the crowd yells 'BOOOOOO'");
                                Console.WriteLine($"Your health is at {userHealth}");
                                Console.WriteLine($"{opponent.Name} health is at {opponentHealth}");
                                break;
                            case "Sword":
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine($"You deflect {opponent.Name}s sword and knock them to the ground\n" +
                                    $"It looks hard for them to breath");
                                opponentHealth = opponentHealth - 1;
                                Console.WriteLine($"Your health is at {userHealth}");
                                Console.WriteLine($"{opponent.Name} health is at {opponentHealth}");
                                break;
                            case "Bow":
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine($"As you rush in {opponent.Name} hits you with an arrow!\n" +
                                    $"You couldn't block them all in time!");
                                userHealth = userHealth - 1;
                                Console.WriteLine($"Your health is at {userHealth}");
                                Console.WriteLine($"{opponent.Name} health is at {opponentHealth}");
                                break;
                            case "Dagger":
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine($"They slip around your shield and Just. Keep. Shanking. You.\n" +
                                    $"A child in the crowd is crying.");
                                userHealth = userHealth - 1;
                                Console.WriteLine($"Your health is at {userHealth}");
                                Console.WriteLine($"{opponent.Name} health is at {opponentHealth}");
                                break;
                            default:
                                Console.WriteLine("Jacob uses STACK OVERFLOW");
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("You died");
                                Console.WriteLine("┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼");
                                Console.WriteLine("███▀▀▀██┼███▀▀▀███┼███▀█▄█▀███┼██▀▀▀");
                                Console.WriteLine("██┼┼┼┼██┼██┼┼┼┼┼██┼██┼┼┼█┼┼┼██┼██┼┼┼");
                                Console.WriteLine("██┼┼┼▄▄▄┼██▄▄▄▄▄██┼██┼┼┼▀┼┼┼██┼██▀▀▀");
                                Console.WriteLine("██┼┼┼┼██┼██┼┼┼┼┼██┼██┼┼┼┼┼┼┼██┼██┼┼┼");
                                Console.WriteLine("███▄▄▄██┼██┼┼┼┼┼██┼██┼┼┼┼┼┼┼██┼██▄▄▄");
                                Console.WriteLine("┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼");
                                Console.WriteLine("███▀▀▀███┼▀███┼┼██▀┼██▀▀▀┼██▀▀▀▀██▄┼");
                                Console.WriteLine("██┼┼┼┼┼██┼┼┼██┼┼██┼┼██┼┼┼┼██┼┼┼┼┼██┼");
                                Console.WriteLine("██┼┼┼┼┼██┼┼┼██┼┼██┼┼██▀▀▀┼██▄▄▄▄▄▀▀┼");
                                Console.WriteLine("██┼┼┼┼┼██┼┼┼██┼┼█▀┼┼██┼┼┼┼██┼┼┼┼┼██┼");
                                Console.WriteLine("███▄▄▄███┼┼┼─▀█▀┼┼─┼██▄▄▄┼██┼┼┼┼┼██▄");
                                Console.WriteLine("┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼");
                                fight = false;
                                Console.WriteLine("Restart?.......\n" +
                                    "1. Yes\n" +
                                    "2. No");
                                string retry = Console.ReadLine().ToLower();
                                switch (retry)
                                {
                                    case "1":
                                    case "Yes":
                                    case "y":
                                        var info = new System.Diagnostics.ProcessStartInfo(Environment.GetCommandLineArgs()[0]);
                                        System.Diagnostics.Process.Start(info);
                                        Environment.Exit(0);
                                        break;
                                    case "2":
                                    case "No":
                                    case "n":
                                        Environment.Exit(0);
                                        break;
                                }
                                break;
                        }



                        break;
                    default:
                        Console.WriteLine("That isn't a weapon you can use!!!");
                        Console.WriteLine("The Opponent Slaps you\n");
                        userHealth = userHealth - 1;
                        Console.WriteLine($"Your health is at {userHealth}");
                        AnyKey();
                        break;
                }
                if (opponentHealth == 0)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine($"Their body falls to ground. \n" +
                        $"You finish the fight with a swing.\n" +
                        $"Congradulations you have defeated {opponent.Name}");
                    AnyKey();
                    Console.Clear();
                    fight = false;
                }
                else if (userHealth == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("YOU DIED...\n\n");
                    Console.WriteLine("┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼");
                    Console.WriteLine("███▀▀▀██┼███▀▀▀███┼███▀█▄█▀███┼██▀▀▀");
                    Console.WriteLine("██┼┼┼┼██┼██┼┼┼┼┼██┼██┼┼┼█┼┼┼██┼██┼┼┼");
                    Console.WriteLine("██┼┼┼▄▄▄┼██▄▄▄▄▄██┼██┼┼┼▀┼┼┼██┼██▀▀▀");
                    Console.WriteLine("██┼┼┼┼██┼██┼┼┼┼┼██┼██┼┼┼┼┼┼┼██┼██┼┼┼");
                    Console.WriteLine("███▄▄▄██┼██┼┼┼┼┼██┼██┼┼┼┼┼┼┼██┼██▄▄▄");
                    Console.WriteLine("┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼");
                    Console.WriteLine("███▀▀▀███┼▀███┼┼██▀┼██▀▀▀┼██▀▀▀▀██▄┼");
                    Console.WriteLine("██┼┼┼┼┼██┼┼┼██┼┼██┼┼██┼┼┼┼██┼┼┼┼┼██┼");
                    Console.WriteLine("██┼┼┼┼┼██┼┼┼██┼┼██┼┼██▀▀▀┼██▄▄▄▄▄▀▀┼");
                    Console.WriteLine("██┼┼┼┼┼██┼┼┼██┼┼█▀┼┼██┼┼┼┼██┼┼┼┼┼██┼");
                    Console.WriteLine("███▄▄▄███┼┼┼─▀█▀┼┼─┼██▄▄▄┼██┼┼┼┼┼██▄");
                    Console.WriteLine("┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼\n\n\n");
                    fight = false;
                    Console.WriteLine("Restart?.......\n" +
                        "1. Yes\n" +
                        "2. No");
                    string retry = Console.ReadLine().ToLower();
                    switch (retry)
                    {
                        case "1":
                        case "Yes":
                        case "y":
                            var info = new System.Diagnostics.ProcessStartInfo(Environment.GetCommandLineArgs()[0]);
                            System.Diagnostics.Process.Start(info);
                            Environment.Exit(0);
                            break;
                        case "2":
                        case "No":
                        case "n":
                            Environment.Exit(0);
                            break;
                    }
                }
                else if (turns == 6)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("The Crowd has grown tired of the prolonged fight...\n");
                    Thread.Sleep(50);
                    Console.WriteLine("A trap door opens up under you...\n");
                    Thread.Sleep(50);
                    Console.WriteLine("and...\n");
                    Thread.Sleep(50);
                    Console.Write(".");
                    Thread.Sleep(50);
                    Console.Write(".");
                    Thread.Sleep(50);
                    Console.Write(".\n");
                    Thread.Sleep(50);
                    Console.WriteLine("YOU DIED...\n");
                    Console.WriteLine("┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼");
                    Console.WriteLine("███▀▀▀██┼███▀▀▀███┼███▀█▄█▀███┼██▀▀▀");
                    Console.WriteLine("██┼┼┼┼██┼██┼┼┼┼┼██┼██┼┼┼█┼┼┼██┼██┼┼┼");
                    Console.WriteLine("██┼┼┼▄▄▄┼██▄▄▄▄▄██┼██┼┼┼▀┼┼┼██┼██▀▀▀");
                    Console.WriteLine("██┼┼┼┼██┼██┼┼┼┼┼██┼██┼┼┼┼┼┼┼██┼██┼┼┼");
                    Console.WriteLine("███▄▄▄██┼██┼┼┼┼┼██┼██┼┼┼┼┼┼┼██┼██▄▄▄");
                    Console.WriteLine("┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼");
                    Console.WriteLine("███▀▀▀███┼▀███┼┼██▀┼██▀▀▀┼██▀▀▀▀██▄┼");
                    Console.WriteLine("██┼┼┼┼┼██┼┼┼██┼┼██┼┼██┼┼┼┼██┼┼┼┼┼██┼");
                    Console.WriteLine("██┼┼┼┼┼██┼┼┼██┼┼██┼┼██▀▀▀┼██▄▄▄▄▄▀▀┼");
                    Console.WriteLine("██┼┼┼┼┼██┼┼┼██┼┼█▀┼┼██┼┼┼┼██┼┼┼┼┼██┼");
                    Console.WriteLine("███▄▄▄███┼┼┼─▀█▀┼┼─┼██▄▄▄┼██┼┼┼┼┼██▄");
                    Console.WriteLine("┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼\n\n\n");
                    fight = false;
                    Console.WriteLine("Restart?.......\n" +
                        "1. Yes\n" +
                        "2. No");
                    string retry = Console.ReadLine().ToLower();
                    switch (retry)
                    {
                        case "1":
                        case "Yes":
                        case "y":
                            var info = new System.Diagnostics.ProcessStartInfo(Environment.GetCommandLineArgs()[0]);
                            System.Diagnostics.Process.Start(info);
                            Environment.Exit(0);
                            break;
                        case "2":
                        case "No":
                        case "n":
                            Environment.Exit(0);
                            break;
                    }
                }
            }
        }
            private void AnyKey()
            {
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
        }
    } 
