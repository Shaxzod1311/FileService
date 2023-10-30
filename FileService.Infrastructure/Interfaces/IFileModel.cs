using System.ComponentModel.DataAnnotations;

namespace FileService.Infrastructure.Interfaces
{
    public interface IFileModel
    {
        [Required]
        string Name { get; set; }
        byte[] Content { get; set; }
        string Extension { get; set; }
        string MimeType { get; set; }
        [Required]
        long Size { get; set; }
    }
}
