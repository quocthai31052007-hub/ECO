// Parent directory hierarchy is QLNongSan/Database
namespace QLNongSan.Databases
{
    using Microsoft.Data.SqlClient;

    // Database factory - manages connection pooling and is responsible for creating connnection in stateless repositories/DALs
    public class SQLServerFactory
    {

        private readonly string connectionString;

        public SQLServerFactory(string serverName, string databaseName, string userName, string password)
        {
            connectionString = new SqlConnectionStringBuilder()
            {
                DataSource = serverName,
                InitialCatalog = databaseName,
                UserID = userName,
                Password = password,

                // SỬA TẠI ĐÂY: Tắt mã hóa kết nối bắt buộc để chạy nội bộ mượt mà
                Encrypt = false,

                // Hoặc nếu để Encrypt = true, bạn bắt buộc phải có dòng dưới:
                TrustServerCertificate = true
            }.ConnectionString;
        }

        public SqlConnection GetConnection()
        {
            return new SqlConnection(this.connectionString);
        }
    }
}