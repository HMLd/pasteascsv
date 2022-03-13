namespace CSV.Services
{
    /// <summary>
    /// Interface IWpfService
    /// </summary>
    public interface ISqlService
    {
        /// <summary>
        /// Forms the SQL.
        /// </summary>
        /// <param name="sql">The SQL.</param>
        /// <returns>System.String.</returns>
        string FormSql(string sql);
    }
}
