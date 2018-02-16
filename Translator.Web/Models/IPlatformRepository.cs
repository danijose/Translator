using System.Collections.Generic;

namespace Translator.Web.Models
{
    public interface IPlatformRepository
    {
        IEnumerable<Platform> GetAll();

        Platform GetById(int id);
    }
}
