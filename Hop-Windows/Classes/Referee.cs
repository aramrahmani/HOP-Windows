using System;

namespace Hop_Windows
{
    internal class Referee
    {
        private static Referee _instance = null;
        private static readonly object objLock = new object();
        private const int max = 50;
        private Referee()
        {
        }

        public static Referee GetInstance()
        {
            lock (objLock)
            {
                if (_instance is null)
                    _instance = new Referee();
                return _instance;
            }
        }
        public int GenerateStartingNumberOfGame()
        {
            Random rand = new Random();
            int refereeNumber = rand.Next(1, max);
            return refereeNumber;
        }
    }
}
