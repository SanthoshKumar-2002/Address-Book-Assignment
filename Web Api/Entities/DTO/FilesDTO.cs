using System.Runtime.Serialization;
using System.Xml.Linq;

namespace WebApi2.Entities.DTO
{
    public class FilesDTO
    {
        [DataMember(Name = "id")]
        public Guid Id { get; set; }

        [DataMember(Name = "fileName")]
        public string? FileName { get; set; }
        [DataMember(Name = "fileType")]
        public string? FileType { get; set; }

        [DataMember(Name = "size")]
        public long? Size { get; set; }

        [DataMember(Name = "download url")]
        public string? DownloadUrl { get; set; }


        [DataMember(Name = "fileContent")]
        public byte[] FormFile { get; set; }
    }
}
