﻿namespace Restorant_Project.Models
{
    public class Menu
    {
        public int MenuId { get; set; }
        public string? Image { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public double Price { get; set; }
        public int LebelId { get; set; }
        public bool IsActive { get; set; }

    }

    public class Lebel
    {
        public int LebelId { get; set; }
        public string? LebelName { get; set; }
    }
}
