using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBLib {
    public enum ColumnTyp {
        /// <summary>
        /// Ein 4-Byte-Integer, Bereich mit Vorzeichen ist -2.147.483.648 bis 2.147.483.647, ohne Vorzeichen 0 bis 4.294.967.295
        /// </summary>
        INT,
        /// <summary>
        /// Eine Zeichenkette mit variabler Länge (0-65,535), die tatsächliche maximale Länge hängt von der maximalen Anzahl Zeilen ab
        /// </summary>
        VARCHAR,
        /// <summary>
        /// Eine TEXT-Spalte mit einer maximalen Länge von 65.535 (2^16 - 1) Zeichen, gespeichert mit einem Zwei-Byte-Präfix, der die Länge des Wertes in Bytes angibt
        /// </summary>
        TEXT,
        /// <summary>
        /// Ein Datum, unterstützter Bereich ist 1000-01-01 bis 9999-12-31
        /// </summary>
        DATE,
        /// <summary>
        /// Ein 1-Byte-Integer, Bereich mit Vorzeichen ist -128 bis 127, ohne Vorzeichen 0 bis 255
        /// </summary>
        TINYINT,
        /// <summary>
        /// Ein 2-Byte-Integer, Bereich mit Vorzeichen ist -32.768 bis 32.767, ohne Vorzeichen 0 bis 65.535
        /// </summary>
        SMALLINT,
        /// <summary>
        /// Ein 3-Byte-Integer, Bereich mit Vorzeichen ist -8.388.608 bis 8.388.607, ohne Vorzeichen 0 bis 16.277.215
        /// </summary>
        MEDIUMINT,
        /// <summary>
        /// Ein 8-Byte-Integer, Bereich mit Vorzeichen ist -9.223.372.036.854.775.808 bis 9.223.372.036.854.775.807, ohne Vorzeichen 0 bis 18.446.744.073.709.551.615
        /// </summary>
        BIGINT,
        /// <summary>
        /// Eine Fixkommazahl (M, D) - die maximale Anzahl Ziffern (M) ist 65 (Standard 10), die maximale Anzahl Dezimale (D) ist 30 (Standard 0)
        /// </summary>
        DECIMAL,
        /// <summary>
        /// Eine kleine Fließkommazahl, erlaubte Werte sind -3,402823466E+38 bis -1,175494351E-38, 0, und 1,175494351E-38 bis 3,402823466E+38
        /// </summary>
        FLOAT,
        /// <summary>
        /// Eine Fließkommazahl mit doppelter Genauigkeit, erlaubte Werte sind -1,7976931348623157E+308 bis -2,2250738585072014E-308, 0, und 2,2250738585072014E-308 bis 1.7976931348623157E+308
        /// </summary>
        DOUBLE,
        /// <summary>
        /// Synonym für DOUBLE (Ausnahme: im SQL-Modus REAL_AS_FLOAT ein Synonym für FLOAT)
        /// </summary>
        REAL,
        /// <summary>
        /// Ein Bitfeld-Typ (M), der M Bits pro Wert speichert (Standard ist 1, Maximum ist 64)
        /// </summary>
        BIT,
        /// <summary>
        /// Ein Synonym für TINYINT(1), ein Null-Wert wird als falsch angesehen, Nicht-Null-Werte werden als wahr angesehen
        /// </summary>
        BOOLEAN,
        /// <summary>
        /// Ein Alias für BIGINT UNSIGNED NOT NULL AUTO_INCREMENT UNIQUE
        /// </summary>
        SERIAL,
        /// <summary>
        /// Eine Kombination aus Datum und Uhrzeit, unterstützter Bereich ist 1000-01-01 00:00:00 bis 9999-12-31 23:59:59
        /// </summary>
        DATETIME,
        /// <summary>
        /// Ein Zeitstempel, Bereich ist 1970-01-01 00:00:01 UTC bis 2038-01-09 03:14:07 UTC, gespeichert als Anzahl Sekunden seit Beginn der UNIX-Epoche (1970-01-01 00:00:00 UTC)
        /// </summary>
        TIMESTAMP,
        /// <summary>
        /// Eine Uhrzeit, Bereich ist -838:59:59 bis 838:59:59
        /// </summary>
        TIME,
        /// <summary>
        /// Ein Jahr im vier- (4, Standard) oder zweistelligen (2) Format, die erlaubten Werte sind 70 (1970) bis 69 (2069) oder 1901 bis 2155 und 0000
        /// </summary>
        YEAR,
        /// <summary>
        /// Eine Zeichenkette mit fester Länge (0-255, Standard 1), die rechts beim Speichern immer mit Leerzeichen auf die angegebene Länge aufgefüllt wird
        /// </summary>
        CHAR,
        /// <summary>
        /// Eine TEXT-Spalte mit einer maximalen Länge von 255 (2^8 - 1) Zeichen, gespeichert mit einem Ein-Byte-Präfix, der die Länge des Wertes in Bytes angibt
        /// </summary>
        TINYTEXT,
        /// <summary>
        /// Eine TEXT-Spalte mit einer maximalen Länge von 16.777.215 (2^24 - 1) Zeichen, gespeichert mit einem Drei-Byte-Präfix, der die Länge des Wertes in Bytes angibt
        /// </summary>
        MEDIUMTEXT,
        /// <summary>
        /// Eine TEXT-Spalte mit einer maximalen Länge von 4.294.967.295 oder 4GiB (2^32 - 1) Zeichen, gespeichert mit einem Vier-Byte-Präfix, der die Länge des Wertes in Bytes angibt
        /// </summary>
        LONGTEXT,
        /// <summary>
        /// Ähnlich wie der CHAR-Typ, speichert aber binäre Byte-Zeichenketten anstelle von nicht-binären Buchstaben-Zeichenketten
        /// </summary>
        BINARY,
        /// <summary>
        /// Ähnlich wie der VARCHAR-Typ, speichert aber binäre Byte-Zeichenketten anstelle von nicht-binären Buchstaben-Zeichenketten
        /// </summary>
        VARBINARY,
        /// <summary>
        /// Eine BLOB-Spalte mit einer maximalen Länge von 255 (2^8 - 1) Bytes, gespeichert mit einem Ein-Byte-Präfix, der die Länge des Wertes angibt
        /// </summary>
        TINYBLOB,
        /// <summary>
        /// Eine BLOB-Spalte mit einer maximalen Länge von 16.777.215 (2^24 - 1) Bytes, gespeichert mit einem Drei-Byte-Präfix, der die Länge des Wertes angibt
        /// </summary>
        MEDIUMBLOB,
        /// <summary>
        /// Eine BLOB-Spalte mit einer maximalen Länge von 65.535 (2^16 - 1) Bytes, gespeichert mit einem Zwei-Byte-Präfix, der die Länge des Wertes angibt
        /// </summary>
        BLOB,
        /// <summary>
        /// Eine BLOB-Spalte mit einer maximalen Länge von 4.294.967.295 oder 4GiB (2^32 - 1) Bytes, gespeichert mit einem Vier-Byte-Präfix, der die Länge des Wertes angibt
        /// </summary>
        LONGBLOB,
        /// <summary>
        /// Eine Aufzählung, gewählt aus der Liste von bis zu 65.535 Werten oder dem besonderen '' Fehler-Wert
        /// </summary>
        ENUM,
        /// <summary>
        /// Ein einzelner Wert gewählt aus einem Satz von bis zu 64 Einträgen
        /// </summary>
        SET,
        /// <summary>
        /// Ein Typ, der die Geometrie irgendeines Typs speichern kann
        /// </summary>
        GEOMETRY,
        /// <summary>
        /// Ein Punkt im 2-dimensionalen Raum
        /// </summary>
        POINT,
        /// <summary>
        /// Eine Kurve mit linearer Interpolation zwischen Punkten
        /// </summary>
        LINESTRING,
        /// <summary>
        /// Ein Vieleck (Polygon)
        /// </summary>
        POLYGON,
        /// <summary>
        /// Eine Punkte-Sammlung
        /// </summary>
        MULTIPOINT,
        /// <summary>
        /// Eine Kurven-Sammlung mit linearer Interpolation zwischen Punkten
        /// </summary>
        MULTILINESTRING,
        /// <summary>
        /// Eine Polygon-Sammlung
        /// </summary>
        MULTIPOLYGON,
        /// <summary>
        /// Eine Sammlung von Geometrie-Objekten irgendeines Typs
        /// </summary>
        GEOMETRYCOLLECTION
    }
}
