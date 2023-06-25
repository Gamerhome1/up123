using UP.Models.Base;

namespace UP.Models
{
    public class Disability : BaseModel
    {
        private byte[]? document;

        public Disability() { }

        public byte[]? Document
        {
            get { return document; } 
            set { Set(ref document, value); }
        }
    }
}
