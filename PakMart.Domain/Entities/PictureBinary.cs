
namespace PakMart.Domain.Entities
{
    public class PictureBinary
    {
        public int Id { get; set; }
        public int PictureId { get; set; }
        public Picture Picture { get; set; }
        public byte[]? BinaryData { get; set; }
    }
}
