using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace DatashaperDemo.Models
{
    public class ParentClass
    {
        public ParentClass()
        {
            ChildClasses = new Collection<ChildClass>();
        }

        public int Id { get; set; }
        public string UserId { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }

        public ICollection<ChildClass> ChildClasses { get; set; }
    }
}