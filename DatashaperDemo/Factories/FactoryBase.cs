using System;
using System.Linq;
using System.Threading;

namespace DatashaperDemo.Factories
{
    public class FactoryBase
    {
        internal string GetRandomString()
        {
            Thread.Sleep(1);
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var random = new Random();
            return new string(
                Enumerable.Repeat(chars, 8)
                          .Select(s => s[random.Next(s.Length)])
                          .ToArray());
        }

        internal int GetRandomNumber()
        {
            return new Random().Next(1000000);
        }

        internal string GetGuid()
        {
            return Guid.NewGuid().ToString();
        }
    }
}
