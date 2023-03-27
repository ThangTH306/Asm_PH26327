namespace Asm_PH26327.Models.IServices
{
    public interface IColorSerVices
    {
        public bool CreateColor(Color role);
        public bool UpdateColor(Color role);
        public bool DeleteColor(Guid id);
        public List<Color> GetAllColor();
        public Color GetColorById(Guid id);
        public List<Color> GetColorByName(string name);
    }
}
