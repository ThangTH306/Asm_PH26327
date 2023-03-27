namespace Asm_PH26327.Models.IServices
{
    public interface ISizeServices
    {
        public bool CreateSize(Size sz);
        public bool UpdateSize(Size sz);
        public bool DeleteSize(Guid id);
        public List<Size> GetSizes();
        public Size GetSizeById(Guid id);

        public List<Size> GetSizeByName(string name);
    }
}
