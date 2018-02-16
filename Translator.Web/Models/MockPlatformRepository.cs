using System.Collections.Generic;
using System.Linq;

namespace Translator.Web.Models
{
    public class MockPlatformRepository : IPlatformRepository
    {
        private List<Platform> _platforms;
        public MockPlatformRepository()
        {
            if (_platforms == null)
            {
                InitializePlatforms();
            }
        }
        public void InitializePlatforms()
        {
            _platforms = new List<Platform>
            {
                new Platform { Id = 1, Name = "Windows" },
                new Platform { Id = 2, Name = "Android" },
                new Platform { Id = 3, Name = "iOS" }
            };
        }

        public IEnumerable<Platform> GetAll()
        {
            return _platforms;
        }

        public Platform GetById(int id)
        {
            return _platforms.FirstOrDefault(p => p.Id == id);
        }

    }
}
