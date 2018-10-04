using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace IntelligentTrafficDemo
{
    public class Database
    {
        public void insert(EventInfo info)
        {
            string connectionString = @"server=localhost;userid=root;password=;database=mydata";

            MySqlConnection connection = null;

            try
            {
                connection = new MySqlConnection(connectionString);
                connection.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;

                cmd = this.prepareQuery(cmd, info);

                int result = cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }

        }


        private MySqlCommand prepareQuery(MySqlCommand cmd, EventInfo info)
        {
            try
            {

                string query = String.Format("INSERT INTO vehicle_info(record_id, `time`, `type`, groupid, `index`, `count`, platenumber, platetype, platecolor, vehicletype, vehiclecolor, vehiclesize, lanenumber, address, filelenth, `offset`, buffer) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}', '{13}', '{14}', '{15}', '{16}')", info.ID, info.Time, info.Type, info.GroupID, info.Index, info.Count, info.PlateNumber, info.PlateType, info.PlateColor, info.VehicleType, info.VehicleColor, info.VehicleSize, info.LaneNumber, info.Address, info.FileLenth, info.OffSet, info.Buffer);


                cmd.CommandText = query;
                cmd.Prepare();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


            return cmd;
        }


        public void testInsert()
        {
            EventInfo info = new EventInfo();
            info.ID = this.random().ToString();
            info.Time = DateTime.Now.ToString();
            info.Type = "Event Type";
            info.GroupID = this.random().ToString();
            info.Index = this.random().ToString();
            info.Count = this.random().ToString();

            info.PlateNumber = "ABC 123";
            info.PlateType = "Plate Type";
            info.PlateColor = "White";
            info.VehicleColor = "Silver";
            info.VehicleSize = "Vehicle Size";
            info.VehicleType = "Vehicle Type";
            info.LaneNumber = "2";
            info.Address = "Address";
            info.FileLenth = (uint)this.random();
            info.OffSet = (uint)this.random();
            info.Buffer = BitConverter.GetBytes(4);

            this.insert(info);
        }


        public int random()
        {
            Random r = new Random();
            return r.Next(1, 1000);
        }
    }
}
