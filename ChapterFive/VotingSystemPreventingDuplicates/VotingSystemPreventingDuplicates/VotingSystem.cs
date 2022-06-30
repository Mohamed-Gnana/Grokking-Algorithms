using System;
using System.Collections.Generic;
using System.Text;

namespace VotingSystemPreventingDuplicates
{
    public class VotingSystem
    {
        Dictionary<string, bool> voters;
        int totalNumber, trumpVotes, bidenVotes;

        public VotingSystem()
        {
            voters = new Dictionary<string, bool>();
            totalNumber = trumpVotes = bidenVotes = 0;
        }

        public void addVoter(string name, Candidates cand)
        {
            if (voters.ContainsKey(name.ToLower()))
            {
                Console.WriteLine("Get that Jackass out of Here!!!");
            }
            else
            {
                voters.Add(name.ToLower(), true);
                addVote(cand);
            }
        }

        public void checkVoter(string name)
        {
            if (voters.ContainsKey(name.ToLower()))
                Console.WriteLine("You voted before!!! Get out of here!!");
            else
                Console.WriteLine("You still need to vote!!!");
        }

        public int getTrumpVotes()
        {
            return trumpVotes;
        }
        public int getBidenVotes()
        {
            return bidenVotes;
        }
        public int getTotalvotes()
        {
            return totalNumber;
        }
        public void getWinner()
        {
            string winner = trumpVotes > bidenVotes ? "Trump" : "Biden";
            Console.WriteLine($"And the winner is : Mr.{winner}");
        }

        void addVote(Candidates cand)
        {
            totalNumber += 1;
            if (cand == Candidates.Trump)
                trumpVotes += 1;
            else
                bidenVotes += 1;
        }
    }
}
