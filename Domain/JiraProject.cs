using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain
{
    public class JiraProject
    {
        public int Id { get; set; }
        public string Key { get; set; }
        public string Name { get; set; }
    }
}