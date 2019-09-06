using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace txtparser
{
    class ParseUtilities
    {

        public static void ParseUserandLeads(Player myPlayer, Player Opponent)
        {
            StreamReader sR = File.OpenText("replay.txt");
            string line;
            while ((line = sR.ReadLine()) != null)
            {
                string[] words = line.Split('|');

                for (int i = 0; i < words.Length; i++)
                {
                    if (words[i].ToLower() == "player" && (words[i + 1].ToLower() == "p1" || words[i + 1].ToLower() == "p2"))
                    {
                        if (words[i + 2] == myPlayer.GetUsername())
                        {
                            myPlayer.SetIsMe(true);
                            if (words[i + 1].ToLower() == "p1")
                            {
                                myPlayer.SetIsPlayerOne(true);
                            }
                            break;
                        }
                        else
                        {
                            if (words[i + 1].ToLower() == "p1")
                            {
                                Opponent.SetIsPlayerOne(true);
                            }

                            Opponent.SetUsername(words[i + 2]);
                            break;
                        }
                    }

                    if (words[i].ToLower() == "switch")
                    {
                        string pokemonName = words[i + 2].Split(',')[0];
                        switch (words[i + 1].Split(' ')[0])
                        {
                            case "p1a:":
                                if (myPlayer.isPlayerOne && myPlayer.GetLeadCount() < 2)
                                {
                                    myPlayer.AddToLead(pokemonName);
                                }
                                else
                                {
                                    if (Opponent.GetLeadCount() < 2)
                                    {
                                        Opponent.AddToLead(pokemonName);
                                    }
                                }
                                break;
                            case "p1b:":
                                if (myPlayer.isPlayerOne && myPlayer.GetLeadCount() < 2)
                                {
                                    myPlayer.AddToLead(pokemonName);
                                }
                                else
                                {
                                    if (Opponent.GetLeadCount() < 2)
                                    {
                                        Opponent.AddToLead(pokemonName);
                                    }
                                }
                                break;
                            case "p2a:":
                                if (!myPlayer.isPlayerOne && myPlayer.GetLeadCount() < 2)
                                {
                                    myPlayer.AddToLead(pokemonName);
                                }
                                else
                                {
                                    if (Opponent.GetLeadCount() < 2)
                                    {
                                        Opponent.AddToLead(pokemonName);
                                    }
                                }
                                break;
                            case "p2b:":
                                if (!myPlayer.isPlayerOne && myPlayer.GetLeadCount() < 2)
                                {
                                    myPlayer.AddToLead(pokemonName);
                                }
                                else
                                {
                                    if (Opponent.GetLeadCount() < 2)
                                    {
                                        Opponent.AddToLead(pokemonName);
                                    }
                                }
                                break;
                        }
                        break;
                    }
                }


            }
        }

        public static void ParseToTeam(Player myPlayer, Player Opponent)
        {
            StreamReader sR = File.OpenText("replay.txt");
            string line;
            while ((line = sR.ReadLine()) != null)
            {
                string[] words = line.Split('|');

                for (int i = 0; i < words.Length; i++)
                {
                    if(words[i] == "poke" && words[i+1] == "p1")
                    {
                        string nomePoke = words[i + 2].Split(',')[0];
                        if(myPlayer.isPlayerOne)
                        {
                            myPlayer.AddToTeam(nomePoke);
                        }

                        else
                        {
                            Opponent.AddToTeam(nomePoke);
                        }
                    }

                    else if (words[i] == "poke" && words[i + 1] == "p2")
                    {
                        string nomePoke = words[i + 2].Split(',')[0];
                        if (!myPlayer.isPlayerOne)
                        {
                            myPlayer.AddToTeam(nomePoke);
                        }

                        else
                        {
                            Opponent.AddToTeam(nomePoke);
                        }
                    }
                }
            }
        }

        public static void FindWinner(Player myPlayer, Player Opponent)
        {
            StreamReader sR = File.OpenText("replay.txt");
            string line;
            while ((line = sR.ReadLine()) != null)
            {
                string[] words = line.Split('|');

                for (int i = 0; i < words.Length; i++)
                {
                    if(words[i] == "win" && words[i+1] == myPlayer.GetUsername())
                    {

                    }
                }
            }
        }
    }
}
