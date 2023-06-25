using UP.Models.Base;
using System.Collections.Generic;

namespace UP.Models
{
    public class PlaceOfResidence : BaseModel
    {
        public string name;

        public PlaceOfResidence() { }

        public string Name
        {
            get { return name; }
            set { Set(ref name, value); }
        }
    }
}
