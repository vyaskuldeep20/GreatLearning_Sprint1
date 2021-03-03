using System;
using System.ComponentModel.DataAnnotations;
using ProjectManagement.Data;

namespace ProjectManagement.Models
{
    public class Task:IEntity
    {
        [Key]
        public int Id { get; set; }
        public int ProjectId { get; set; }
        public int Status { get; set; }
        public int AssignedToUserId { get; set; }
        public string Detail { get; set; }
        public DateTime CreatedOn { get; set; }

    }
}
