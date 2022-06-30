using System;

namespace VotingSystemPreventingDuplicates
{
    class Program
    {
        static void Main(string[] args)
        {
            var system = new VotingSystem();
            system.addVoter("Mohamed", Candidates.Biden);
            system.addVoter("Ahmed", Candidates.Trump);
            system.addVoter("Hanem", Candidates.Trump);
            system.addVoter("Mohamed", Candidates.Biden);
            system.getWinner();
        }
    }
}
