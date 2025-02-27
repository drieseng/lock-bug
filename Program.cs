using System.Threading;

namespace ConsoleApp1
{
    internal class Program
    {
        private static readonly Lock SyncLock = new Lock();

        static void Main(string[] args)
        {
            lock (SyncLock)
            {

            }
        }
    }
}
