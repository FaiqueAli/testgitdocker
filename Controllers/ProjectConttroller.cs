using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using testgitdocker.Data;
using testgitdocker.Model;

namespace testgitdocker.Controllers{
[Route("/api/Project")]
[ApiController]
    public class ProjectController:ControllerBase
    {
        private readonly MockProjects _repository=new MockProjects();
        [HttpGet]
        public ActionResult<IEnumerable<Projects>> GetAllProject()
        {
            return Ok(_repository.GetAllProjects());
        }
        [HttpGet("{id}")]
        public ActionResult<IEnumerable<Projects>> GetProjectByID(int id)
        {
            return  Ok(_repository.GetProjectByID(id));
        }
    }
}