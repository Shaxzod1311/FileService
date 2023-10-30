using FileService.Infrastructure.Interfaces;

namespace FileService.Infrastructure.Models
{
#pragma warning disable
    public class File : IFileModel
    {
        public string MimeType { get; set; }
        public string Name { get; set; }
        public byte[] Content { get; set; }
        public string Extension { get; set; }
        public long Size { get; set; }
    }
}
