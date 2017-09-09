using System;
namespace DBLib {
    [Flags]
    public enum PermissionTyp {
        /// <summary>
        /// allows them to create new tables or databases
        /// </summary>
        CREATE,
        /// <summary>
        /// allows them to them to delete tables or databases
        /// </summary>
        DROP,
        /// <summary>
        /// allows them to delete rows from tables
        /// </summary>
        DELETE,
        /// <summary>
        /// allows them to insert rows into tables
        /// </summary>
        INSERT,
        /// <summary>
        /// allows them to use the Select command to read through databases
        /// </summary>
        SELECT,
        /// <summary>
        /// allow them to update table rows
        /// </summary>
        UPDATE,
        /// <summary>
        /// allows them to grant or remove other users privileges
        /// </summary>
        GRANT_OPTION,
        /// <summary>
        /// allows then all terms
        /// </summary>
        ALL = CREATE | DROP | DELETE | INSERT | SELECT | UPDATE | GRANT_OPTION
    }
}
