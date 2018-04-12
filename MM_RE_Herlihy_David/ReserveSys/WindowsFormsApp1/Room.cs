using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace WindowsFormsApp1
{
    class Room
    {

        private int roomNo;
        private string description;
        private string type;
        private string status;

        //setters
        public void setRoomNo(int RoomNo)
        {
            this.roomNo = RoomNo;
        }

        public void setDescription(string Description)
        {
            this.description = Description;
        }

        public void setType(string Type)
        {
            this.type = Type;
        }

        public void setStatus(string Status)
        {
            this.status = Status;
        }

        //getters
        public int getRoomNo()
        {
            return roomNo;
        }

        public string getDescription()
        {
            return description;
        }

        public string getType()
        {
            return type;
        }

        public string getStatus()
        {
            return status;
        }

        //no args constructor
        public Room()
        {
            roomNo = 0;
            description = "";
            type = "";
            status = "U";
        }

        //Arg Constructor
        public Room(int RoomNo, string Description, string Type, string Status)
        {
            setRoomNo(RoomNo);
            setDescription(Description);
            setType(Type);
            setStatus(Status);
        }

        //Get all room for display
        public static DataSet getAllRooms(DataSet DS)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String strSQL = "SELECT * FROM Rooms ORDER BY RoomNo";

            OracleCommand cmd = new OracleCommand(strSQL, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.Fill(DS, "ss");

            conn.Close();

            return DS;
        }

        //Gets next room number
        public static int nextRoomNo()
        {
            int nextRoomNo;

            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            String strSQL = "SELECT MAX(roomNo) FROM Rooms";

            OracleCommand cmd = new OracleCommand(strSQL, conn);

            OracleDataReader dr = cmd.ExecuteReader();

            dr.Read();

            if (dr.IsDBNull(0))
                nextRoomNo = 101;
            else
                nextRoomNo = Convert.ToInt16(dr.GetValue(0)) + 1;

            conn.Close();
            return nextRoomNo;

        }

        //validation that a room's status is availible to be updated
        public static Boolean checkRoomStatus(String RoomNo)
        {
            Boolean ans = false;

            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            conn.Open();

            String strSQL = "SELECT Status FROM Rooms WHERE RoomNo = '" + RoomNo + "'";

            OracleCommand cmd = new OracleCommand(strSQL, conn);

            OracleDataReader dr = cmd.ExecuteReader();

            if (dr.Read().Equals("U"))
                ans = true;

            conn.Close();

            return ans;

        }

        public static Boolean checkFreeRooms(String RoomNo)
        {
            Boolean ans = false;

            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            conn.Open();

            String strSQL = "SELECT * FROM Reservations WHERE RoomNo = " + RoomNo + "AND Arrival_Date >= SYSDATE";

            OracleCommand cmd = new OracleCommand(strSQL, conn);

            OracleDataReader dr = cmd.ExecuteReader();

            if (!dr.Read())
                ans = true;

            conn.Close();

            return ans;

        }

        //Insert a new rate
        public void addRoom()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            conn.Open();

            String strSQL = "INSERT INTO Rooms VALUES(" + this.roomNo + ",'" + this.description.ToUpper() + "','" + this.type.ToUpper()
                + "','" + this.status + "')";

            OracleCommand cmd = new OracleCommand(strSQL, conn);
            cmd.ExecuteNonQuery();

            conn.Close();
        }

        //retriving a specified room for updating
        public void loadRoom(string RoomNo)
        {
            DataSet DS = new DataSet();
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            conn.Open();

            String strSQL = "SELECT * FROM Rooms WHERE RoomNo = '" + RoomNo + "'";
            //Add join/nested select to check reservations active with room no

            OracleCommand cmd = new OracleCommand(strSQL, conn);

            OracleDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                setRoomNo(dr.GetInt16(0));
                setDescription(dr.GetString(1));
                setType(dr.GetString(2));
                setStatus(dr.GetString(3));
            }
            conn.Close();
        }

        public void updateRoom()
        {
            //connect to database
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            //Define SQL query to INSERT stock record
            String strSQL = "UPDATE Rooms SET Room_Description = '" + this.description.ToUpper() + "', Room_Type = '" + this.type +
           "', Room_Status ='" + this.status + "' WHERE RoomNo = " + this.roomNo;

            //Execute the command
            OracleCommand cmd = new OracleCommand(strSQL, conn);
            cmd.ExecuteNonQuery();

            //close DB connection
            conn.Close();
        }

        public static void closeRoom(int RoomNo)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            //Define SQL query to INSERT stock record
            String strSQL = "UPDATE Rooms SET Room_Status = 'C' WHERE RoomNo = " + RoomNo;

            //Execute the command
            OracleCommand cmd = new OracleCommand(strSQL, conn);
            cmd.ExecuteNonQuery();

            //close DB connection
            conn.Close();
        }
    }
}
