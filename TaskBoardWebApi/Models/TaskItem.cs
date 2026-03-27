using System;
using System.Collections.Generic;
using System.Linq;
using TaskBoardWebApi.Enums;

namespace TaskBoardWebApi.Models
{
    public class TaskItem : BaseEntity
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public Enums.TaskStatus Status { get; set; }
        public Enums.TaskPriority Priority { get; set; }

        public DateTime DueDate { get; set; }
        public bool IsArchived { get; set; }

        public Guid ProjectId { get; set; }
        public Project Project { get; set; }

        // Creator
        public Guid CreatedById { get; set; }
        public AppUser CreatedUser { get; set; }

        // Assignee
        public Guid AssignedToId { get; set; }
        public AppUser AssignedUser { get; set; }
    }
}