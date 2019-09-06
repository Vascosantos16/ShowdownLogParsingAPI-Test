using System;
using System.Collections.Generic;
using System.Text;

namespace txtparser
{
    class Player
    {
        bool isMe = false;
        public bool isPlayerOne = false;
        string username;
        List<string> Lead = new List<string>();
        List<string> Team = new List<string>();

        public void SetUsername(string username)
        {
            this.username = username;
        }

        public string GetUsername()
        {
            return username;
        }

        public void SetIsMe(bool isMe)
        {
            this.isMe = isMe;
        }

        public void SetIsPlayerOne(bool isPlayerOne)
        {
            this.isPlayerOne = isPlayerOne;
        }

        public void AddToLead(string pokemon)
        {
            Lead.Add(pokemon);
        }

        public void AddToTeam(string pokemon)
        {
            Team.Add(pokemon);
        }

        public void ListUsernameAndLead()
        {
            if (isMe)
            {
                Console.WriteLine(username + "'s(me) lead: ");
                foreach (string s in Lead)
                {
                    Console.WriteLine(s);
                }
            }

            else
            {
                Console.WriteLine(username + "'s lead: ");
                foreach (string s in Lead)
                {
                    Console.WriteLine(s);
                }
            }

        }

        public void ListTeam()
        {
            if (isMe)
            {
                Console.WriteLine(username + "'s(me) Team: ");
                foreach (string s in Team)
                {
                    Console.WriteLine(s);
                }
            }

            else
            {
                Console.WriteLine(username + "'s Team: ");
                foreach (string s in Team)
                {
                    Console.WriteLine(s);
                }
            }

        }

        public int GetLeadCount()
        {
            return Lead.Count;
        }
    }
}
