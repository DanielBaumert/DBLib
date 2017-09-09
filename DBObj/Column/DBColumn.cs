using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBLib {
    public class DBColumn {
        public string Name { get; set; }
        public ColumnTyp Typ { get; set; }
        public int Länge { get; set; }
        public BasicTyp Standard { get; set; }
        public string StandardText { get; set; }
        public KollationTyp Kollation { get; set; }
        public AttributeTyp Attribute { get; set; }
        public bool Null { get; set; }
        public IndexTyp Index { get; set; }
        public bool A_I { get; set; }
        public string Kommentare { get; set; }
        public MIMETyp MIMETyp { get; set; }
        public DarstellungsumwandlungTyp Darstellungsumwandlung { get; set; }
        public string Umwandlungsoptionen { get; set; }
        /// <summary>
        /// Erstellt ein Objekt vom Typ DBColumn
        /// </summary>
        /// <param name="name">Name der Spalte</param>
        /// <param name="typ">Typ der Spalte</param>
        public DBColumn(string name, ColumnTyp typ) {
            Name = name;
            Typ = typ;
            AttributeTyp.CURRENT_TIMESTAMP.toString();
        }
    }
}
