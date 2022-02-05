using DevFreela.Core.Entities;
using System;
using System.Collections.Generic;

namespace DevFreela.Infrastructure.Percistence
{
    public class DevFreelaDbContext
    {
        public DevFreelaDbContext()
        {
            Projects = new List<Project>()
            {
                new Project("Meu projeto Asp.Net Core 1", "Minha descrição de Projeto 1", 1, 1, 10000),
                new Project("Meu projeto Asp.Net Core 2", "Minha descrição de Projeto 2", 1, 1, 20000),
                new Project("Meu projeto Asp.Net Core 3", "Minha descrição de Projeto 3", 1, 1, 30000)
            };

            Users = new List<User>()
            {
                new User("Edson Santos", "dev.escode@hotmail.com", new DateTime(1990,1,1)),
                new User("Lin Jah Kin", "linjahkin@hotmail.com", new DateTime(1989,7,1)),
                new User("Huy Li", "huyli@hotmail.com", new DateTime(1995,10,15))
            };

            Skills = new List<Skill>()
            {
                new Skill(".NET 5"),
                new Skill("T-SQL"),
                new Skill("PostgreSQL")
            };
        }

        public List<Project> Projects { get; set; }
        public List<User> Users { get; set; }
        public List<Skill> Skills { get; set; }
    }
}
