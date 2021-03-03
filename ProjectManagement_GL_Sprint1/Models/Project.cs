using System;
using System.ComponentModel.DataAnnotations;
using ProjectManagement.Data;

namespace ProjectManagement.Models
{
    public class Project:IEntity
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Detail { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
