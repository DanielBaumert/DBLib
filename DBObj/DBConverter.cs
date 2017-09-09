using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBLib.Converter { 
    public static class DBConverter {
        public static string toString(this AttributeTyp typ) {
            switch(typ) {
                case AttributeTyp.UNSIGNED_ZEROFILL:
                    return "UNSIGNED ZEROFILL";
                case AttributeTyp.CURRENT_TIMESTAMP:
                    return "on update CURRENT_TIMESTAMP";
                case AttributeTyp.UNSIGNED:
                    return "UNSIGNED";
                case AttributeTyp.BINARY:
                    return "BINARY";
            }
            return "";
        }
    }
}
