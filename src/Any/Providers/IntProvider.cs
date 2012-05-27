using System;
using Any.Framework;

namespace Any.Providers
{
    class IntProvider : IAnyProvider
    {
        private readonly Random _randomGenerator;

        public IntProvider()
        {
            _randomGenerator = new Random();
        }

        public dynamic Any()
        {
            return _randomGenerator.Next(0, int.MaxValue);
        }

        public dynamic AnyBetween(dynamic lower, dynamic upper)
        {
            return _randomGenerator.Next(lower, upper);
        }

        public dynamic AnyExcept(dynamic exception)
        {
            var result = Any();
            if (result == exception)
                return AnyExcept(exception);
            return result;
        }
    }
}