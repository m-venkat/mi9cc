using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mi9cc.JsonModel
{
    public class JsonParseError
    {
        public string error {
                get {
                    return "Could not decode request: JSON parsing failed";
                    }
            }
    }
}
