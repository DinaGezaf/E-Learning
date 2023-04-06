﻿using E_Learning_Platform.Models;

namespace E_Learning_Platform.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public int Duration { get; set; }
        public float Rating { get; set; }
        public float Price { get; set; }
        public string Image { get; set; }
        public int StudentId { get; set; }
        public virtual Student Student { get; set; }
        public virtual List<Lesson> Lessons { get; set; }

    }
}
