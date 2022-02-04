using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Core.Entities
{
    public class User : BaseEntity
    {
        public User(string fullName, string email, DateTime birthDate, DateTime createdAt, 
            List<UserSkill> skills, List<Project> ownedProjects, List<Project> freelanceProjects)
        {
            FullName = fullName;
            Email = email;
            BirthDate = birthDate;
            CreatedAt = createdAt;
            Skills = skills;
            OwnedProjects = ownedProjects;
            FreelanceProjects = freelanceProjects;
        }

        public string FullName { get; private set; }
        public string Email { get; private set; }
        public DateTime BirthDate { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public List<UserSkill> Skills { get; private set; }
        public List<Project> OwnedProjects { get; private set; }
        public List<Project> FreelanceProjects { get; private set; }
    }
}
