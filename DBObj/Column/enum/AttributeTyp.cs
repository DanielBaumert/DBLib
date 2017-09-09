using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBLib {
    public enum AttributeTyp {
        /// <summary>
        /// BINARY
        /// </summary>
        BINARY,
        /// <summary>
        /// UNSIGNED
        /// </summary>
        UNSIGNED,
        /// <summary>
        /// UNSIGNED ZEROFILL
        /// </summary>
        UNSIGNED_ZEROFILL,
        /// <summary>
        /// on update CURRENT_TIMESTAMP
        /// </summary>
        CURRENT_TIMESTAMP
    }

    
}
