﻿using UP.Models.Base;

namespace UP.Models
{
    public class Ward : BaseModel
    {
        private byte[]? document;

        public Ward() { }

        public byte[]? Document
        {
            get { return document; }
            set { Set(ref document, value); }
        }
    }
}
