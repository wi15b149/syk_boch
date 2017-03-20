using System.Collections.Generic;

namespace MyFirstAspNetWebService
{
    public class Person
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int Age { get; set; }

        public List<SkillSet> Skills { get; set; }

        public Person()
        {
            Skills = new List<SkillSet>();
            Skills.Add(new SkillSet() { Name = "C# Programming", Rank = 10 });
            Skills.Add(new SkillSet() { Name = "Java Programming", Rank = 5 });
            Skills.Add(new SkillSet() { Name = "C++ Programming", Rank = 1 });
        }

    }
}