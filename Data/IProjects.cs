using System.Collections.Generic;
using testgitdocker.Model;

namespace testgitdocker.Data{
    interface IProjects{
        IEnumerable<Projects> GetAllProjects();
        Projects GetProjectByID(int projID);

    }
}