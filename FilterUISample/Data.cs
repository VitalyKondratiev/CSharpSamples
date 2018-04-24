using System;
using System.Collections.Generic;
using System.Threading;

namespace FilterUISample
{
    public struct Data
    {
        public string name { get; set; }
        public string state { get; set; }
        public double price { get; set; }
        public DateTime time { get; set; }

        public Data(string g)
        {
            name = Guid.NewGuid().ToString();
            state = Guid.NewGuid().ToString();
            price = ((StaticRandom.Instance.Next(1, 10000) * 5) / 9);
            time = new DateTime(1995, 1, 1).AddDays(StaticRandom.Instance.Next((DateTime.Today - new DateTime(1995, 1, 1)).Days));
            price = Math.Round(price, 4);
        }
    }

    public class DataList
    {
        public List<Data> list = new List<Data>();

        public DataList()
        {
            for (int i = 0; i < 500; i++)
                list.Add(new Data(string.Empty));
        }
    }

    public static class StaticRandom
    {
        private static int seed;

        private static ThreadLocal<Random> threadLocal = new ThreadLocal<Random>
            (() => new Random(Interlocked.Increment(ref seed)));

        static StaticRandom()
        {
            seed = Environment.TickCount;
        }

        public static Random Instance { get { return threadLocal.Value; } }
    }
}
