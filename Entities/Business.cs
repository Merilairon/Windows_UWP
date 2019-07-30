using Windows_UWP.Enums;

namespace Windows_UWP.Entities
{
    public class Business
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public BusinessType Type { get; set; }
        public string Address { get; set; }
    }
}