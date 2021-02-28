using System;
using System.Collections.Generic;
using Microsoft.Extensions.Configuration;
using System.Configuration;
using System.Data.SqlClient;
using DeliveryManagement.DataAccess.Core;
using DeliveryManagement.DataAccess.Entities.SQLEntities;
using DeliveryManagement.DataAccess.Interfaces;
using DeliveryManagement.DataAccess.Interfaces.SQLInterfaces.ISQLRepositories;
using SkillManagement.DataAccess.Core;

namespace DeliveryManagement.DataAccess.Repositories
{
    public class SqlDeliveryMenRepository : GenericRepository<SqlDeliveryMen, long>, ISqlDeliveryMenRepository
    {
        private string connectionString;
        public SqlDeliveryMenRepository(IConnectionFactory connectionFactory, IConfiguration config) : base(connectionFactory, "deliverymen", false)
        {
            this.connectionString = config.GetConnectionString("DefaultConnection");
            connectionFactory.SetConnection(this.connectionString);
        }
        
        
        public List<SqlDeliveryMen> getOlderFifty()
        {
            string queryString =
                "SELECT * from dbo.deliverymen "
                + "WHERE age > 50 "
                + "ORDER BY age DESC"
                + "LIMIT 5;";

            List<SqlDeliveryMen> sqlDeliveryMenList = new List<SqlDeliveryMen>();
            using (SqlConnection connection =
                new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        SqlDeliveryMen deliveryMen = new SqlDeliveryMen();
                        deliveryMen.Id = (long) reader[0];
                        deliveryMen.Age = (long) reader[1];
                        deliveryMen.Name = (string) reader[2];
                        deliveryMen.Surname = (string) reader[3];
                        deliveryMen.Wages = (long) reader[4];
                        sqlDeliveryMenList.Add(deliveryMen);
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                Console.ReadLine();
            }

            return sqlDeliveryMenList;
        }
    }
}
