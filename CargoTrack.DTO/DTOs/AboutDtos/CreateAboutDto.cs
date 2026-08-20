

namespace CargoTrack.DTO.DTOs.AboutDtos
{
    public class CreateAboutDto
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
    }
}
