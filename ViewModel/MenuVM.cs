namespace Restorant_Project.ViewModel
{
    public class MenuVM
    {
        public int MenuId { get; set; }
        public string? Image { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public double Price { get; set; }
        public int LebelId { get; set; }
        public bool IsActive { get; set; }
        public IFormFile? UploadImage { get; set; }

    }
}
