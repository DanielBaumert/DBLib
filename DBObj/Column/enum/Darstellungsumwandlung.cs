using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBLib {
    public enum DarstellungsumwandlungTyp {
        /// <summary>
        /// Zeigt einen Link an, um die binären Daten eines Feldes herunterladen zu können. In der ersten Möglichkeit benennen Sie den Dateinamen. Als zweite Option wird ein Spaltenname durch den Dateinamen gesetzt. Sollte die zweite Option gesetzt sein, ist es notwendig, die erste Option auf einen Leerstring zu setzen.
        /// </summary>
        ApplicationOctetstreamDownload,
        /// <summary>
        /// Daten in hexadezimaler Schreibweise darstellen. Der optionale Parameter legt fest, nach wie vielen Halbbyte ein Leerzeichen eingefügt werden soll (Standardwert ist 2).
        /// </summary>
        ApplicationOctetstreamHex,
        /// <summary>
        /// Ein klickbares Vorschaubild anzeigen. Optionen: Breite und Höhe in Pixeln, wobei das ursprüngliche Seitenverhältnis berücksichtigt wird.
        /// </summary>
        ImageJPEGInline,
        /// <summary>
        /// Einen Link zum Bild anzeigen, z. B. zum Download von BLOB-Daten.
        /// </summary>
        ImageJPEGLink,
        /// <summary>
        /// Ein klickbares Vorschaubild anzeigen. Optionen: Breite und Höhe in Pixeln, wobei das ursprüngliche Seitenverhältnis berücksichtigt wird.
        /// </summary>
        ImagePNGInline,
        /// <summary>
        /// Boolische Werte werden in Text umgewandelt (Standard: 'T' und 'F'. Der erste Wert steht für TRUE, der zweite für FALSE. Ungleich Null entspricht TRUE.
        /// </summary>
        TextPlainBool2text,
        /// <summary>
        /// Zeigt eine TIME-, TIMESTAMP-, DATETIME- oder numerisches Unixtimestamp-Spalte als formatiertes Datum an. Die erste Option ist der Offset (in Stunden), der zum Timestamp hinzugefügt wird (Vorgabe: 0). Verwenden Sie die zweite Option, um eine abweichende Datum-/Zeit-Format-Zeichenkette anzugeben. Die dritte Option bestimmt, ob Sie das lokale Datum oder das entsprechende UTC-Datum sehen wollen ("local" oder "utc" verwenden). Dementsprechend hat das Datumsformat verschiedene Werte - für "lokal" siehe PHP-Dokumentation für die strftime()-Funktion und für "utc" wird es mittels der gmdate()-Funktion konvertiert.
        /// </summary>
        TextPlainDateformat,
        /// <summary>
        /// NUR FÜR LINUX: Startet ein externes Programm und verwendet die Daten der Spalte für die Standardeingabe. Gibt die Standardausgabe der Anwendung zurück. Die Voreinstellung wurde für Tidy optimiert, um HTML code optisch zu formatieren. Aus Sicherheitsgründen müssen Sie die Datei libraries/plugins/transformations/Text_Plain_External.class.php von Hand bearbeiten, um weitere Programme verfügbar zu machen. Die erste Option ist die Nummer des dort hinterlegten Programmes und die zweite Option legt die Parameter für das externe Programm fest. Die dritte Option bestimmt, falls auf 1 gesetzt, dass die Ausgabe mit htmlspecialchars() formatiert wird (Standard: 1). Die vierte Option bestimmt, falls auf 1 gesetzt, ob ein NOWRAP-Parameter der Tabellenzelle hinzugefügt wird, um einen automatischen Umbruch der Standardausgabe zu verhindern (Standard: 1).
        /// </summary>
        TextPlainExternal,
        /// <summary>
        /// Stellt den Inhalt der Spalten in der ursprünglichen Formatierung dar, ohne dass diese htmlspecialchars() durchläuft. Das heißt, es wird angenommen, dass die Spalte gültiges HTML enthält.
        /// </summary>
        TextPlainFormatted,
        /// <summary>
        /// Zeigt ein Bild und einen Link; die Spalte enthält den Dateinamen. Die erste Option ist ein URL-Präfix, wie "http://www.example.com/". Die zweite Option ist die Breite des Bildes und die dritte Option die Höhe in Pixeln.
        /// </summary>
        TextPlainImagelink,
        /// <summary>
        /// Zeigt einen Link an; die Spalte enthält den Dateinamen. Die erste Option ist ein Präfix, wie " http://www.example.com/" . Die zweite Option ist der darzustellende Titel des Links.
        /// </summary>
        TextPlainLink,
        /// <summary>
        /// Konvertiert eine (IPv4) Internet Netzwerk-Adresse in eine Zeichenkette im Punkt-Format.
        /// </summary>
        TextPlainLongtoipv4,
        /// <summary>
        /// Hängt Text an eine Zeichenfolge an oder stellt ihn voran. Die erste Option ist der Text der vorangestellt werden soll, der Text der angehängt werden soll (eingeschlossen in einfache Anführungszeichen, standardgemäß leere Zeichenfolge).
        /// </summary>
        TextPlainPreappend,
        /// <summary>
        /// Formatiert den Text als SQL mit Syntaxhervorhebung.
        /// </summary>
        TextPlainSql,
        /// <summary>
        /// Stellt nur einen Teil des Feldinhaltes dar. Die erste Option definiert die Position des Textes ab dem die Ausgabe startet (Standard: 0), die zweite Option gibt an wieviel Zeichen ab dort dargestellt werden sollen. Falls diese Option leer ist, wird der gesamte verbleibende Text dargestellt. Die dritte Option kann einen Text enthalten, der bei partieller Ausgabe des Textes angehängt wird, um eine Abschneidung kenntlich zu machen (Standard: "…").
        /// </summary>
        TextPlainSubstring,

    }
}
