using System.Collections.Generic;
using testgitdocker.Model;

namespace testgitdocker.Data{

    public class MockProjects : IProjects
    {
        
        public IEnumerable<Projects> GetAllProjects()
        {
            var ProjectsList = new List<Projects>{
                new Projects{projectID=1,ProjectName="Java",ProjectDescription="java Basic Project"},
                new Projects{projectID=2,ProjectName="C# Projects",ProjectDescription="C#  orginal Project"},
                new Projects{projectID=3,ProjectName="Python projects",ProjectDescription="Python sample Project"},
            };
            return ProjectsList;
        }

        public Projects GetProjectByID(int projID)
        {
               return new Projects{projectID=1,ProjectName="C#", ProjectDescription="C# Project"};
        }
    }
}