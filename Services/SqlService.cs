using System;
using System.Text;

namespace CSV.Services
{
    /// <summary>
    /// Class SqlService.
    /// Implements the <see cref="CSV.Services.ISqlService" />
    /// </summary>
    /// <seealso cref="CSV.Services.ISqlService" />
    public class SqlService : ISqlService
    {
        /// <summary>
        /// Forms the SQL.
        /// </summary>
        /// <param name="sql">The SQL.</param>
        /// <returns>System.String.</returns>
        public string FormSql(string sql)
        {
            if (string.IsNullOrWhiteSpace(sql))
                return sql;

            var result = new StringBuilder();
            var words = sql.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);

            for (var i = 0; i < words.Length; i++)
            {
                var word = words[i].Replace("'", "''");
                result.Append($"'{word}'");
                if (i != words.Length - 1)
                    result.Append($",{Environment.NewLine}");
            }

            return result.ToString();
        }
    }
}
