using System.Collections.Generic;
using testgitdocker.Model;

namespace testgitdocker.Data{
    public interface IProjects{
        IEnumerable<Projects> GetAllProjects();
        Projects GetProjectByID(int projID);

    }
}