using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace WindowsFormsApp1
{
    class Rates
    {
        //instance variables
        private string room_Type;
        private string description;
        private decimal rate;

        //Setters
        public void setRoom_Type(string Room_Type)
        {
            this.room_Type = Room_Type;
        }

        public void setDescription(string Description)
        {
            this.description = Description;
        }

        public void setRate(decimal Rate)
        {
            this.rate = Rate;
        }

        //Getters
        public string getRoom_Type()
        {
            return room_Type;
        }

        public string getDescription()
        {
            return description;
        }

        public decimal getRate()
        {
            return rate;
        }

        //no args constructor

        public Rates()
        {
            room_Type = "";
            description = "";
            rate = 0;
        }

        //Arg Constructor
        public Rates(string Room_Rate, string Description, decimal Rate)
        {
            setRoom_Type(Room_Rate);
            setDescription(Description);
            setRate(Rate);
        }

        //Get all rates for display
        public static DataSet getAllRates(DataSet DS)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String strSQL = "SELECT * FROM Rates ORDER BY Room_Type";

            OracleCommand cmd = new OracleCommand(strSQL, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.Fill(DS, "ss");

            conn.Close();

            return DS;
        }

        //Insert a new rate
        public void addRate()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            conn.Open();

            String strSQL = "INSERT INTO Rates VALUES('" + this.room_Type.ToUpper() + "','" + this.description.ToUpper()
                + "'," + this.rate + ")";

            OracleCommand cmd = new OracleCommand(strSQL, conn);
            cmd.ExecuteNonQuery();

            conn.Close();
        }

        //validation that a rate does not  already exist
        public static Boolean rateExists(String Room_Type)
        {
            Boolean ans = false;

            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            conn.Open();

            String strSQL = "SELECT * FROM Rates WHERE Room_Type = '" + Room_Type + "'";

            OracleCommand cmd = new OracleCommand(strSQL, conn);

            OracleDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
                ans = true;

            conn.Close();

            return ans;

        }

        //retriving a specified rate for updating
        public void loadRate(string Room_Type)
        {
            //Rates updRate = new Rates();

            //DataSet DS = new DataSet();
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            conn.Open();

            String strSQL = "SELECT * FROM Rates WHERE Room_Type = '" + Room_Type + "'";

            OracleCommand cmd = new OracleCommand(strSQL, conn);

            OracleDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                setRoom_Type(dr.GetString(0));
                setDescription(dr.GetString(1));
                setRate(dr.GetDecimal(2));
            }
            conn.Close();
        }

        public void updRate()
        {
            //connect to database
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            //Define SQL query to INSERT stock record
            String strSQL = "UPDATE Rates SET Rate_Description = '" + this.description.ToUpper() + "', Room_Rate = " + this.rate +
           " WHERE Room_Type = '" + this.room_Type + "'";

            //Execute the command
            OracleCommand cmd = new OracleCommand(strSQL, conn);
            cmd.ExecuteNonQuery();

            //close DB connection
            conn.Close();
        }
    }
}
