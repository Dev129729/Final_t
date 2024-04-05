using System;

namespace final_t
{
    internal class Counter : IDisposable
    {
        public void Add(ref int cnt)
        {
            cnt++;
        }

        public void Dispose() => Console.WriteLine("Счетчик очистился!");
    }
}
