using System;
using System.Collections.Generic;
using System.IO;

namespace txtparser
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("inserir utilizador");
            

            Player myPlayer = new Player();
            Player Opponent = new Player();

            myPlayer.SetUsername(Console.ReadLine());

            ParseUtilities.ParseUserandLeads(myPlayer, Opponent);
            ParseUtilities.ParseToTeam(myPlayer,Opponent);
            
            myPlayer.ListUsernameAndLead();
            Opponent.ListUsernameAndLead();

            myPlayer.ListTeam();
            Opponent.ListTeam();
        }
    }

    
}
