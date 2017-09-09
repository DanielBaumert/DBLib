using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBLib {
    public enum KollationTyp {
        /// <summary>
        /// Armenisch, Binär
        /// </summary>
        armscii8_bin,
        /// <summary>
        /// Armenisch, Beachtet nicht Groß- und Kleinschreibung
        /// </summary>
        armscii8_general_ci,
        /// <summary>
        /// Westeuropäisch (mehrsprachig), Binär
        /// </summary>
        ascii_bin,
        /// <summary>
        /// Westeuropäisch (mehrsprachig), Beachtet nicht Groß- und Kleinschreibung
        /// </summary>
        ascii_general_ci,
        /// <summary>
        /// Traditionelles Chinesisch, Binär
        /// </summary>
        big5_bin,
        /// <summary>
        /// Traditionelles Chinesisch, Beachtet nicht Groß- und Kleinschreibung
        /// </summary>
        big5_chinese_ci,
        /// <summary>
        /// Binär
        /// </summary>
        binary,
        /// <summary>
        /// Mitteleuropäisch (mehrsprachig), Binär
        /// </summary>
        cp1250_bin,
        /// <summary>
        /// Kroatisch, Beachtet nicht Groß- und Kleinschreibung
        /// </summary>
        cp1250_croatian_ci,
        /// <summary>
        /// Tschechisch, Beachtet Groß- und Kleinschreibung
        /// </summary>
        cp1250_czech_cs,
        /// <summary>
        /// Mitteleuropäisch (mehrsprachig), Beachtet nicht Groß- und Kleinschreibung
        /// </summary>
        cp1250_general_ci,
        /// <summary>
        /// Polnisch, Beachtet nicht Groß- und Kleinschreibung
        /// </summary>
        cp1250_polish_ci,
        /// <summary>
        /// Kyrillisch (mehrsprachig), Binär
        /// </summary>
        cp1251_bin,
        /// <summary>
        /// Bulgarisch, Beachtet nicht Groß- und Kleinschreibung
        /// </summary>
        cp1251_bulgarian_ci,
        /// <summary>
        /// Kyrillisch (mehrsprachig), Beachtet nicht Groß- und Kleinschreibung
        /// </summary>
        cp1251_general_ci,
        /// <summary>
        /// Kyrillisch (mehrsprachig), Beachtet Groß- und Kleinschreibung
        /// </summary>
        cp1251_general_cs,
        /// <summary>
        /// Ukrainisch, Beachtet nicht Groß- und Kleinschreibung
        /// </summary>
        cp1251_ukrainian_ci,
        /// <summary>
        /// Arabisch, Binär
        /// </summary>
        cp1256_bin,
        /// <summary>
        /// Arabisch, Beachtet nicht Groß- und Kleinschreibung
        /// </summary>
        cp1256_general_ci,
        /// <summary>
        /// Baltisch (mehrsprachig), Binär
        /// </summary>
        cp1257_bin,
        /// <summary>
        /// Baltisch (mehrsprachig), Beachtet nicht Groß- und Kleinschreibung
        /// </summary>
        cp1257_general_ci,
        /// <summary>
        /// Litauisch, Beachtet nicht Groß- und Kleinschreibung
        /// </summary>
        cp1257_lithuanian_ci,
        /// <summary>
        /// Westeuropäisch (mehrsprachig), Binär
        /// </summary>
        cp850_bin,
        /// <summary>
        /// Westeuropäisch (mehrsprachig), Beachtet nicht Groß- und Kleinschreibung
        /// </summary>
        cp850_general_ci,
        /// <summary>
        /// Mitteleuropäisch (mehrsprachig), Binär
        /// </summary>
        cp852_bin,
        /// <summary>
        /// Mitteleuropäisch (mehrsprachig), Beachtet nicht Groß- und Kleinschreibung
        /// </summary>
        cp852_general_ci,
        /// <summary>
        /// Russisch, Binär
        /// </summary>
        cp866_bin,
        /// <summary>
        /// Russisch, Beachtet nicht Groß- und Kleinschreibung
        /// </summary>
        cp866_general_ci,
        /// <summary>
        /// Japanisch, Binär
        /// </summary>
        cp932_bin,
        /// <summary>
        /// Japanisch, Beachtet nicht Groß- und Kleinschreibung
        /// </summary>
        cp932_japanese_ci,
        /// <summary>
        /// Westeuropäisch (mehrsprachig), Binär
        /// </summary>
        dec8_bin,
        /// <summary>
        /// Schwedisch, Beachtet nicht Groß- und Kleinschreibung
        /// </summary>
        dec8_swedish_ci,
        /// <summary>
        /// Japanisch, Binär
        /// </summary>
        eucjpms_bin,
        /// <summary>
        /// Japanisch, Beachtet nicht Groß- und Kleinschreibung
        /// </summary>
        eucjpms_japanese_ci,
        /// <summary>
        /// Koreanisch, Binär
        /// </summary>
        euckr_bin,
        /// <summary>
        /// Koreanisch, Beachtet nicht Groß- und Kleinschreibung
        /// </summary>
        euckr_korean_ci,
        /// <summary>
        /// Vereinfachtes Chinesisch, Binär
        /// </summary>
        gb2312_bin,
        /// <summary>
        /// Vereinfachtes Chinesisch, Beachtet nicht Groß- und Kleinschreibung
        /// </summary>
        gb2312_chinese_ci,
        /// <summary>
        /// Vereinfachtes Chinesisch, Binär
        /// </summary>
        gbk_bin,
        /// <summary>
        /// Vereinfachtes Chinesisch, Beachtet nicht Groß- und Kleinschreibung
        /// </summary>
        gbk_chinese_ci,
        /// <summary>
        /// Georgisch, Binär
        /// </summary>
        geostd8_bin,
        /// <summary>
        /// Georgisch, Beachtet nicht Groß- und Kleinschreibung
        /// </summary>
        geostd8_general_ci,
        /// <summary>
        /// Griechisch, Binär
        /// </summary>
        greek_bin,
        /// <summary>
        /// Griechisch, Beachtet nicht Groß- und Kleinschreibung
        /// </summary>
        greek_general_ci,
        /// <summary>
        /// Hebräisch, Binär
        /// </summary>
        hebrew_bin,
        /// <summary>
        /// Hebräisch, Beachtet nicht Groß- und Kleinschreibung
        /// </summary>
        hebrew_general_ci,
        /// <summary>
        /// Westeuropäisch (mehrsprachig), Binär
        /// </summary>
        hp8_bin,
        /// <summary>
        /// Englisch, Beachtet nicht Groß- und Kleinschreibung
        /// </summary>
        hp8_english_ci,
        /// <summary>
        /// Tschechoslowakisch, Binär
        /// </summary>
        keybcs2_bin,
        /// <summary>
        /// Tschechoslowakisch, Beachtet nicht Groß- und Kleinschreibung
        /// </summary>
        keybcs2_general_ci,
        /// <summary>
        /// Russisch, Binär
        /// </summary>
        koi8r_bin,
        /// <summary>
        /// Russisch, Beachtet nicht Groß- und Kleinschreibung
        /// </summary>
        koi8r_general_ci,
        /// <summary>
        /// Ukrainisch, Binär
        /// </summary>
        koi8u_bin,
        /// <summary>
        /// Ukrainisch, Beachtet nicht Groß- und Kleinschreibung
        /// </summary>
        koi8u_general_ci,
        /// <summary>
        /// Westeuropäisch (mehrsprachig), Binär
        /// </summary>
        latin1_bin,
        /// <summary>
        /// Dänisch, Beachtet nicht Groß- und Kleinschreibung
        /// </summary>
        latin1_danish_ci,
        /// <summary>
        /// Westeuropäisch (mehrsprachig), Beachtet nicht Groß- und Kleinschreibung
        /// </summary>
        latin1_general_ci,
        /// <summary>
        /// Westeuropäisch (mehrsprachig), Beachtet Groß- und Kleinschreibung
        /// </summary>
        latin1_general_cs,
        /// <summary>
        /// Deutsch (Wörterbuch), Beachtet nicht Groß- und Kleinschreibung
        /// </summary>
        latin1_german1_ci,
        /// <summary>
        /// Deutsch (Telefonbuch), Beachtet nicht Groß- und Kleinschreibung
        /// </summary>
        latin1_german2_ci,
        /// <summary>
        /// Spanisch, Beachtet nicht Groß- und Kleinschreibung
        /// </summary>
        latin1_spanish_ci,
        /// <summary>
        /// Schwedisch, Beachtet nicht Groß- und Kleinschreibung
        /// </summary>
        latin1_swedish_ci,
        /// <summary>
        /// Mitteleuropäisch (mehrsprachig), Binär
        /// </summary>
        latin2_bin,
        /// <summary>
        /// Kroatisch, Beachtet nicht Groß- und Kleinschreibung
        /// </summary>
        latin2_croatian_ci,
        /// <summary>
        /// Tschechisch, Beachtet Groß- und Kleinschreibung
        /// </summary>
        latin2_czech_cs,
        /// <summary>
        /// Mitteleuropäisch (mehrsprachig), Beachtet nicht Groß- und Kleinschreibung
        /// </summary>
        latin2_general_ci,
        /// <summary>
        /// Ungarisch, Beachtet nicht Groß- und Kleinschreibung
        /// </summary>
        latin2_hungarian_ci,
        /// <summary>
        /// Türkisch, Binär
        /// </summary>
        latin5_bin,
        /// <summary>
        /// Türkisch, Beachtet nicht Groß- und Kleinschreibung
        /// </summary>
        latin5_turkish_ci,
        /// <summary>
        /// Baltisch (mehrsprachig), Binär
        /// </summary>
        latin7_bin,
        /// <summary>
        /// Estnisch, Beachtet Groß- und Kleinschreibung
        /// </summary>
        latin7_estonian_cs,
        /// <summary>
        /// Baltisch (mehrsprachig), Beachtet nicht Groß- und Kleinschreibung
        /// </summary>
        latin7_general_ci,
        /// <summary>
        /// Baltisch (mehrsprachig), Beachtet Groß- und Kleinschreibung
        /// </summary>
        latin7_general_cs,
        /// <summary>
        /// Mitteleuropäisch (mehrsprachig), Binär
        /// </summary>
        macce_bin,
        /// <summary>
        /// Mitteleuropäisch (mehrsprachig), Beachtet nicht Groß- und Kleinschreibung
        /// </summary>
        macce_general_ci,
        /// <summary>
        /// Westeuropäisch (mehrsprachig), Binär
        /// </summary>
        macroman_bin,
        /// <summary>
        /// Westeuropäisch (mehrsprachig), Beachtet nicht Groß- und Kleinschreibung
        /// </summary>
        macroman_general_ci,
        /// <summary>
        /// Japanisch, Binär
        /// </summary>
        sjis_bin,
        /// <summary>
        /// Japanisch, Beachtet nicht Groß- und Kleinschreibung
        /// </summary>
        sjis_japanese_ci,
        /// <summary>
        /// Schwedisch, Binär
        /// </summary>
        swe7_bin,
        /// <summary>
        /// Schwedisch, Beachtet nicht Groß- und Kleinschreibung
        /// </summary>
        swe7_swedish_ci,
        /// <summary>
        /// Thai, Binär
        /// </summary>
        tis620_bin,
        /// <summary>
        /// Thai, Beachtet nicht Groß- und Kleinschreibung
        /// </summary>
        tis620_thai_ci,
        /// <summary>
        /// Unicode (mehrsprachig), Binär
        /// </summary>
        ucs2_bin,
        /// <summary>
        /// Tschechisch, Beachtet nicht Groß- und Kleinschreibung
        /// </summary>
        ucs2_czech_ci,
        /// <summary>
        /// Dänisch, Beachtet nicht Groß- und Kleinschreibung
        /// </summary>
        ucs2_danish_ci,
        /// <summary>
        /// Esperanto, Beachtet nicht Groß- und Kleinschreibung
        /// </summary>
        ucs2_esperanto_ci,
        /// <summary>
        /// Estnisch, Beachtet nicht Groß- und Kleinschreibung
        /// </summary>
        ucs2_estonian_ci,
        /// <summary>
        /// Unicode (mehrsprachig), Beachtet nicht Groß- und Kleinschreibung
        /// </summary>
        ucs2_general_ci,
        /// <summary>
        /// Unicode (mehrsprachig)
        /// </summary>
        ucs2_general_mysql500_ci,
        /// <summary>
        /// Ungarisch, Beachtet nicht Groß- und Kleinschreibung
        /// </summary>
        ucs2_hungarian_ci,
        /// <summary>
        /// Isländisch, Beachtet nicht Groß- und Kleinschreibung
        /// </summary>
        ucs2_icelandic_ci,
        /// <summary>
        /// Lettisch, Beachtet nicht Groß- und Kleinschreibung
        /// </summary>
        ucs2_latvian_ci,
        /// <summary>
        /// Litauisch, Beachtet nicht Groß- und Kleinschreibung
        /// </summary>
        ucs2_lithuanian_ci,
        /// <summary>
        /// Persisch, Beachtet nicht Groß- und Kleinschreibung
        /// </summary>
        ucs2_persian_ci,
        /// <summary>
        /// Polnisch, Beachtet nicht Groß- und Kleinschreibung
        /// </summary>
        ucs2_polish_ci,
        /// <summary>
        /// Westeuropäisch, Beachtet nicht Groß- und Kleinschreibung
        /// </summary>
        ucs2_roman_ci,
        /// <summary>
        /// Rumänisch, Beachtet nicht Groß- und Kleinschreibung
        /// </summary>
        ucs2_romanian_ci,
        /// <summary>
        /// unbekannt, Beachtet nicht Groß- und Kleinschreibung
        /// </summary>
        ucs2_sinhala_ci,
        /// <summary>
        /// Slovakisch, Beachtet nicht Groß- und Kleinschreibung
        /// </summary>
        ucs2_slovak_ci,
        /// <summary>
        /// Slovenisch, Beachtet nicht Groß- und Kleinschreibung
        /// </summary>
        ucs2_slovenian_ci,
        /// <summary>
        /// Traditionelles Spanisch, Beachtet nicht Groß- und Kleinschreibung
        /// </summary>
        ucs2_spanish2_ci,
        /// <summary>
        /// Spanisch, Beachtet nicht Groß- und Kleinschreibung
        /// </summary>
        ucs2_spanish_ci,
        /// <summary>
        /// Schwedisch, Beachtet nicht Groß- und Kleinschreibung
        /// </summary>
        ucs2_swedish_ci,
        /// <summary>
        /// Türkisch, Beachtet nicht Groß- und Kleinschreibung
        /// </summary>
        ucs2_turkish_ci,
        /// <summary>
        /// Unicode (mehrsprachig), Beachtet nicht Groß- und Kleinschreibung
        /// </summary>
        ucs2_unicode_ci,
        /// <summary>
        /// Japanisch, Binär
        /// </summary>
        ujis_bin,
        /// <summary>
        /// Japanisch, Beachtet nicht Groß- und Kleinschreibung
        /// </summary>
        ujis_japanese_ci,
        /// <summary>
        /// unbekannt, Binär
        /// </summary>
        utf16_bin,
        /// <summary>
        /// Tschechisch, Beachtet nicht Groß- und Kleinschreibung
        /// </summary>
        utf16_czech_ci,
        /// <summary>
        /// Dänisch, Beachtet nicht Groß- und Kleinschreibung
        /// </summary>
        utf16_danish_ci,
        /// <summary>
        /// Esperanto, Beachtet nicht Groß- und Kleinschreibung
        /// </summary>
        utf16_esperanto_ci,
        /// <summary>
        /// Estnisch, Beachtet nicht Groß- und Kleinschreibung
        /// </summary>
        utf16_estonian_ci,
        /// <summary>
        /// unbekannt, Beachtet nicht Groß- und Kleinschreibung
        /// </summary>
        utf16_general_ci,
        /// <summary>
        /// Ungarisch, Beachtet nicht Groß- und Kleinschreibung
        /// </summary>
        utf16_hungarian_ci,
        /// <summary>
        /// Isländisch, Beachtet nicht Groß- und Kleinschreibung
        /// </summary>
        utf16_icelandic_ci,
        /// <summary>
        /// Lettisch, Beachtet nicht Groß- und Kleinschreibung
        /// </summary>
        utf16_latvian_ci,
        /// <summary>
        /// Litauisch, Beachtet nicht Groß- und Kleinschreibung
        /// </summary>
        utf16_lithuanian_ci,
        /// <summary>
        /// Persisch, Beachtet nicht Groß- und Kleinschreibung
        /// </summary>
        utf16_persian_ci,
        /// <summary>
        /// Polnisch, Beachtet nicht Groß- und Kleinschreibung
        /// </summary>
        utf16_polish_ci,
        /// <summary>
        /// Westeuropäisch, Beachtet nicht Groß- und Kleinschreibung
        /// </summary>
        utf16_roman_ci,
        /// <summary>
        /// Rumänisch, Beachtet nicht Groß- und Kleinschreibung
        /// </summary>
        utf16_romanian_ci,
        /// <summary>
        /// unbekannt, Beachtet nicht Groß- und Kleinschreibung
        /// </summary>
        utf16_sinhala_ci,
        /// <summary>
        /// Slovakisch, Beachtet nicht Groß- und Kleinschreibung
        /// </summary>
        utf16_slovak_ci,
        /// <summary>
        /// Slovenisch, Beachtet nicht Groß- und Kleinschreibung
        /// </summary>
        utf16_slovenian_ci,
        /// <summary>
        /// Traditionelles Spanisch, Beachtet nicht Groß- und Kleinschreibung
        /// </summary>
        utf16_spanish2_ci,
        /// <summary>
        /// Spanisch, Beachtet nicht Groß- und Kleinschreibung
        /// </summary>
        utf16_spanish_ci,
        /// <summary>
        /// Schwedisch, Beachtet nicht Groß- und Kleinschreibung
        /// </summary>
        utf16_swedish_ci,
        /// <summary>
        /// Türkisch, Beachtet nicht Groß- und Kleinschreibung
        /// </summary>
        utf16_turkish_ci,
        /// <summary>
        /// Unicode (mehrsprachig), Beachtet nicht Groß- und Kleinschreibung
        /// </summary>
        utf16_unicode_ci,
        /// <summary>
        /// unbekannt, Binär
        /// </summary>
        utf32_bin,
        /// <summary>
        /// Tschechisch, Beachtet nicht Groß- und Kleinschreibung
        /// </summary>
        utf32_czech_ci,
        /// <summary>
        /// Dänisch, Beachtet nicht Groß- und Kleinschreibung
        /// </summary>
        utf32_danish_ci,
        /// <summary>
        /// Esperanto, Beachtet nicht Groß- und Kleinschreibung
        /// </summary>
        utf32_esperanto_ci,
        /// <summary>
        /// Estnisch, Beachtet nicht Groß- und Kleinschreibung
        /// </summary>
        utf32_estonian_ci,
        /// <summary>
        /// unbekannt, Beachtet nicht Groß- und Kleinschreibung
        /// </summary>
        utf32_general_ci,
        /// <summary>
        /// Ungarisch, Beachtet nicht Groß- und Kleinschreibung
        /// </summary>
        utf32_hungarian_ci,
        /// <summary>
        /// Isländisch, Beachtet nicht Groß- und Kleinschreibung
        /// </summary>
        utf32_icelandic_ci,
        /// <summary>
        /// Lettisch, Beachtet nicht Groß- und Kleinschreibung
        /// </summary>
        utf32_latvian_ci,
        /// <summary>
        /// Litauisch, Beachtet nicht Groß- und Kleinschreibung
        /// </summary>
        utf32_lithuanian_ci,
        /// <summary>
        /// Persisch, Beachtet nicht Groß- und Kleinschreibung
        /// </summary>
        utf32_persian_ci,
        /// <summary>
        /// Polnisch, Beachtet nicht Groß- und Kleinschreibung
        /// </summary>
        utf32_polish_ci,
        /// <summary>
        /// Westeuropäisch, Beachtet nicht Groß- und Kleinschreibung
        /// </summary>
        utf32_roman_ci,
        /// <summary>
        /// Rumänisch, Beachtet nicht Groß- und Kleinschreibung
        /// </summary>
        utf32_romanian_ci,
        /// <summary>
        /// unbekannt, Beachtet nicht Groß- und Kleinschreibung
        /// </summary>
        utf32_sinhala_ci,
        /// <summary>
        /// Slovakisch, Beachtet nicht Groß- und Kleinschreibung
        /// </summary>
        utf32_slovak_ci,
        /// <summary>
        /// Slovenisch, Beachtet nicht Groß- und Kleinschreibung
        /// </summary>
        utf32_slovenian_ci,
        /// <summary>
        /// Traditionelles Spanisch, Beachtet nicht Groß- und Kleinschreibung
        /// </summary>
        utf32_spanish2_ci,
        /// <summary>
        /// Spanisch, Beachtet nicht Groß- und Kleinschreibung
        /// </summary>
        utf32_spanish_ci,
        /// <summary>
        /// Schwedisch, Beachtet nicht Groß- und Kleinschreibung
        /// </summary>
        utf32_swedish_ci,
        /// <summary>
        /// Türkisch, Beachtet nicht Groß- und Kleinschreibung
        /// </summary>
        utf32_turkish_ci,
        /// <summary>
        /// Unicode (mehrsprachig), Beachtet nicht Groß- und Kleinschreibung
        /// </summary>
        utf32_unicode_ci,
        /// <summary>
        /// Unicode (mehrsprachig), Binär
        /// </summary>
        utf8_bin,
        /// <summary>
        /// Tschechisch, Beachtet nicht Groß- und Kleinschreibung
        /// </summary>
        utf8_czech_ci,
        /// <summary>
        /// Dänisch, Beachtet nicht Groß- und Kleinschreibung
        /// </summary>
        utf8_danish_ci,
        /// <summary>
        /// Esperanto, Beachtet nicht Groß- und Kleinschreibung
        /// </summary>
        utf8_esperanto_ci,
        /// <summary>
        /// Estnisch, Beachtet nicht Groß- und Kleinschreibung
        /// </summary>
        utf8_estonian_ci,
        /// <summary>
        /// Unicode (mehrsprachig), Beachtet nicht Groß- und Kleinschreibung
        /// </summary>
        utf8_general_ci,
        /// <summary>
        /// Unicode (mehrsprachig)
        /// </summary>
        utf8_general_mysql500_ci,
        /// <summary>
        /// Ungarisch, Beachtet nicht Groß- und Kleinschreibung
        /// </summary>
        utf8_hungarian_ci,
        /// <summary>
        /// Isländisch, Beachtet nicht Groß- und Kleinschreibung
        /// </summary>
        utf8_icelandic_ci,
        /// <summary>
        /// Lettisch, Beachtet nicht Groß- und Kleinschreibung
        /// </summary>
        utf8_latvian_ci,
        /// <summary>
        /// Litauisch, Beachtet nicht Groß- und Kleinschreibung
        /// </summary>
        utf8_lithuanian_ci,
        /// <summary>
        /// Persisch, Beachtet nicht Groß- und Kleinschreibung
        /// </summary>
        utf8_persian_ci,
        /// <summary>
        /// Polnisch, Beachtet nicht Groß- und Kleinschreibung
        /// </summary>
        utf8_polish_ci,
        /// <summary>
        /// Westeuropäisch, Beachtet nicht Groß- und Kleinschreibung
        /// </summary>
        utf8_roman_ci,
        /// <summary>
        /// Rumänisch, Beachtet nicht Groß- und Kleinschreibung
        /// </summary>
        utf8_romanian_ci,
        /// <summary>
        /// unbekannt, Beachtet nicht Groß- und Kleinschreibung
        /// </summary>
        utf8_sinhala_ci,
        /// <summary>
        /// Slovakisch, Beachtet nicht Groß- und Kleinschreibung
        /// </summary>
        utf8_slovak_ci,
        /// <summary>
        /// Slovenisch, Beachtet nicht Groß- und Kleinschreibung
        /// </summary>
        utf8_slovenian_ci,
        /// <summary>
        /// Traditionelles Spanisch, Beachtet nicht Groß- und Kleinschreibung
        /// </summary>
        utf8_spanish2_ci,
        /// <summary>
        /// Spanisch, Beachtet nicht Groß- und Kleinschreibung
        /// </summary>
        utf8_spanish_ci,
        /// <summary>
        /// Schwedisch, Beachtet nicht Groß- und Kleinschreibung
        /// </summary>
        utf8_swedish_ci,
        /// <summary>
        /// Türkisch, Beachtet nicht Groß- und Kleinschreibung
        /// </summary>
        utf8_turkish_ci,
        /// <summary>
        /// Unicode (mehrsprachig), Beachtet nicht Groß- und Kleinschreibung
        /// </summary>
        utf8_unicode_ci,
        /// <summary>
        /// Unicode (mehrsprachig), Binär
        /// </summary>
        utf8mb4_bin,
        /// <summary>
        /// Tschechisch, Beachtet nicht Groß- und Kleinschreibung
        /// </summary>
        utf8mb4_czech_ci,
        /// <summary>
        /// Dänisch, Beachtet nicht Groß- und Kleinschreibung
        /// </summary>
        utf8mb4_danish_ci,
        /// <summary>
        /// Esperanto, Beachtet nicht Groß- und Kleinschreibung
        /// </summary>
        utf8mb4_esperanto_ci,
        /// <summary>
        /// Estnisch, Beachtet nicht Groß- und Kleinschreibung
        /// </summary>
        utf8mb4_estonian_ci,
        /// <summary>
        /// Unicode (mehrsprachig), Beachtet nicht Groß- und Kleinschreibung
        /// </summary>
        utf8mb4_general_ci,
        /// <summary>
        /// Ungarisch, Beachtet nicht Groß- und Kleinschreibung
        /// </summary>
        utf8mb4_hungarian_ci,
        /// <summary>
        /// Isländisch, Beachtet nicht Groß- und Kleinschreibung
        /// </summary>
        utf8mb4_icelandic_ci,
        /// <summary>
        /// Lettisch, Beachtet nicht Groß- und Kleinschreibung
        /// </summary>
        utf8mb4_latvian_ci,
        /// <summary>
        /// Litauisch, Beachtet nicht Groß- und Kleinschreibung
        /// </summary>
        utf8mb4_lithuanian_ci,
        /// <summary>
        /// Persisch, Beachtet nicht Groß- und Kleinschreibung
        /// </summary>
        utf8mb4_persian_ci,
        /// <summary>
        /// Polnisch, Beachtet nicht Groß- und Kleinschreibung
        /// </summary>
        utf8mb4_polish_ci,
        /// <summary>
        /// Westeuropäisch, Beachtet nicht Groß- und Kleinschreibung
        /// </summary>
        utf8mb4_roman_ci,
        /// <summary>
        /// Rumänisch, Beachtet nicht Groß- und Kleinschreibung
        /// </summary>
        utf8mb4_romanian_ci,
        /// <summary>
        /// unbekannt, Beachtet nicht Groß- und Kleinschreibung
        /// </summary>
        utf8mb4_sinhala_ci,
        /// <summary>
        /// Slovakisch, Beachtet nicht Groß- und Kleinschreibung
        /// </summary>
        utf8mb4_slovak_ci,
        /// <summary>
        /// Slovenisch, Beachtet nicht Groß- und Kleinschreibung
        /// </summary>
        utf8mb4_slovenian_ci,
        /// <summary>
        /// Traditionelles Spanisch, Beachtet nicht Groß- und Kleinschreibung
        /// </summary>
        utf8mb4_spanish2_ci,
        /// <summary>
        /// Spanisch, Beachtet nicht Groß- und Kleinschreibung
        /// </summary>
        utf8mb4_spanish_ci,
        /// <summary>
        /// Schwedisch, Beachtet nicht Groß- und Kleinschreibung
        /// </summary>
        utf8mb4_swedish_ci,
        /// <summary>
        /// Türkisch, Beachtet nicht Groß- und Kleinschreibung
        /// </summary>
        utf8mb4_turkish_ci,
        /// <summary>
        /// Unicode (mehrsprachig), Beachtet nicht Groß- und Kleinschreibung
        /// </summary>
        utf8mb4_unicode_ci
    }
}
