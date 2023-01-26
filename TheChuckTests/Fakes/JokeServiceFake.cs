﻿using TheChuck.Core;

namespace TheChuckTests.Fakes
{
    internal class JokeServiceFake : IJokeService
    {
        private readonly Joke joke;

        public JokeServiceFake(Joke joke)
        {
            this.joke = null;
        }

        public Task<Joke?> GetJokeFromCategory(string category)
        {
            throw new NotImplementedException();
        }

        public async Task<Joke?> GetRandomJoke()
        {
            return await Task.FromResult(joke);
        }
    }
}


