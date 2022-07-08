using System.Threading;
using System.Threading.Tasks;

namespace Hop_Windows
{
    internal class Player
    {
        public string Name { get; set; }
        public Player(string name)
        {
            Name = name;
        }


        public async Task<string> Play(int counter,int refereeNumber)
        {
            string result = "";
            await Task.Run(() =>
            {
                result = IsMultiple(counter, refereeNumber) ? "HOP" : counter.ToString();
            });
            return result;
        }

        private bool IsMultiple(int i,int refereeNumber)
        {
            return i % refereeNumber == 0;
        }


    }
}
