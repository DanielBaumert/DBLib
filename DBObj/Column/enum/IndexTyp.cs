using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBLib {
    public enum IndexTyp {
        /// <summary>
        /// None
        /// </summary>
        NONE,
        /// <summary>
        /// Primärschlüssel
        /// </summary>
        PRIMARY,
        /// <summary>
        /// Unique
        /// </summary>
        UNIQUE,
        /// <summary>
        /// Index
        /// </summary>
        INDEX,
        /// <summary>
        /// Volltext
        /// </summary>
        FULLTEXT

    }
}
