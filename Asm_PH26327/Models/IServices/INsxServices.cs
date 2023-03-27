namespace Asm_PH26327.Models.IServices
{
    public interface INsxServices
    {
        public bool CreateNsx(Nsx role);
        public bool UpdateNsx(Nsx role);
        public bool DeleteNsx(Guid id);
        public List<Nsx> GetAllNsxs();
        public Nsx GetNsxById(Guid id);
        public List<Nsx> GetNsxByName(string name);
    }
}
