using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace WindowsFormsApp1
{
    class Reservation
    {
        private int resNo;
        private string arrivalDate;
        private string deptDate;
        private string resStatus;
        private double cost;
        private int custID;
        private int roomNo;

        public void setResNo(int ResNo)
        {
            resNo = ResNo;
        }

        public void setArrivalDate(string ArrivalDate)
        {
            arrivalDate = ArrivalDate;
        }

        public void setDeptDate(string DeptDate)
        {
            deptDate = DeptDate;
        }

        public void setResStatus(string ResStatus)
        {
            resStatus = ResStatus;
        }

        public void setCost(double Cost)
        {
            cost = Cost;
        }

        public void setCustID(int CustID)
        {
            custID = CustID;
        }

        public void setRoomNO(int RoomNo)
        {
            roomNo = RoomNo;
        }

        public int getResNo()
        {
            return resNo;
        } 

        public string getArrivalDate()
        {
            return arrivalDate;
        }

        public string getDeptDate()
        {
            return deptDate;
        }

        public string getResStatus()
        {
            return resStatus;
        }

        public double getCost()
        {
            return cost;
        }

        public int getCustID()
        {
            return custID;
        }

        public int getRoomNo()
        {
            return roomNo;
        }

        public Reservation(int resNo, string arrivalDate, string deptDate, string resStatus, int custID, int roomNo)
        {
            this.resNo = resNo;
            this.arrivalDate = arrivalDate;
            this.deptDate = deptDate;
            this.resStatus = resStatus;
            this.custID = custID;
            this.roomNo = roomNo;
        }

        public Reservation()
        {
            resNo = 0;
            arrivalDate = "";
            deptDate = "";
            resStatus = "B";
            custID = 0;
            roomNo = 0;
        }

        //Generates next ResNo
        public static int nextRes()
        {
            int nextRes;

            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            String strSQL = "SELECT MAX(ResNo) FROM Reservations";

            OracleCommand cmd = new OracleCommand(strSQL, conn);

            OracleDataReader dr = cmd.ExecuteReader();

            dr.Read();

            if (dr.IsDBNull(0))
                nextRes = 1001;
            else
                nextRes = Convert.ToInt16(dr.GetValue(0)) + 1;

            conn.Close();

            return nextRes;

        }

        //Gets all rooms of the selected type that do not have any bookings during the selected dates and are not closed
        public static DataSet getUnoccupiedRooms(DataSet DS, string ArrivalDate, string DeptDate, string Type)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String strSQL = "SELECT * FROM Rooms rm WHERE rm.RoomNo NOT IN (SELECT DISTINCT RoomNo FROM Reservations rs WHERE(rs.Arrival_Date BETWEEN DATE '"
                + ArrivalDate + "' AND DATE '" + DeptDate + "') OR (rs.Dept_Date BETWEEN DATE '" + ArrivalDate + "' AND DATE '" + DeptDate +
                "') OR (rs.Arrival_Date < DATE '" + ArrivalDate + "' AND rs.Dept_Date > DATE '" + DeptDate +"')) AND rm.Room_Type = '" + Type +
                "' AND NOT rm.Room_Status = 'C'";

            OracleCommand cmd = new OracleCommand(strSQL, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.Fill(DS, "ss");

            conn.Close();

            return DS;
        }

        //Saves a Reservations Details to the Reservations File
        public void addReservation()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            conn.Open();

            String strSQL = "INSERT INTO Reservations VALUES(" +this.resNo + ",DATE '" +this.arrivalDate + "',DATE '" + this.deptDate + "','" + this.resStatus + "',"
                + this.cost + "," + this.custID + "," + this.roomNo +")";

            OracleCommand cmd = new OracleCommand(strSQL, conn);
            cmd.ExecuteNonQuery();

            conn.Close();
        }

        //Returns a rate amount based on the selected Room Number
        public static double findRate(int RoomNo)
        {
            double roomRate;

            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            String strSQL = "SELECT Room_Rate FROM Rates WHERE Room_Type = (Select Room_Type FROM Rooms WHERE RoomNo = " + RoomNo+")";

            OracleCommand cmd = new OracleCommand(strSQL, conn);

            OracleDataReader dr = cmd.ExecuteReader();

            dr.Read();

            roomRate = Convert.ToDouble(dr.GetValue(0));

            conn.Close();

            return roomRate;
        }

        //Returns the Room Number of the selected Reservation
        public static int findRoom(int ResNo)
        {
            int roomNo;

            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            String strSQL = "SELECT RoomNo FROM Reservations WHERE ResNo = " + ResNo;

            OracleCommand cmd = new OracleCommand(strSQL, conn);

            OracleDataReader dr = cmd.ExecuteReader();

            dr.Read();

            roomNo = Convert.ToInt16(dr.GetValue(0));

            conn.Close();

            return roomNo;
        }

        //Gets all Reservations based on the Forename and Surname of the Customer
        public static DataSet getReservations(DataSet DS, string FName, string SName)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String strSQL = "SELECT * FROM Reservations rs WHERE rs.CustID IN (SELECT cs.CustID FROM Customers cs WHERE SName LIKE '%" + SName.ToUpper() + "%' AND FName LIKE '%" + FName.ToUpper()
                + "%')";

            OracleCommand cmd = new OracleCommand(strSQL, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.Fill(DS, "ss");

            conn.Close();

            return DS;
        }

        //Changes a Reservations Status
        public static void changeResStatus(int ResNo, string status)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            String strSQL = "UPDATE Reservations SET Res_Status = '" + status + "' WHERE ResNo = " + ResNo;
  
            OracleCommand cmd = new OracleCommand(strSQL, conn);
            cmd.ExecuteNonQuery();

            conn.Close();
        }

        //Gets all Reservations available to be Checked-In
        public static DataSet getCheckIns(DataSet DS, String Date)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String strSQL = "SELECT * from Reservations WHERE Res_Status = 'B' AND Arrival_Date = DATE '" + Date +"'";

            OracleCommand cmd = new OracleCommand(strSQL, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.Fill(DS, "ss");

            conn.Close();

            return DS;
        }

        //Gets all Reservations available to be Checked-Out
        public static DataSet getCheckOuts(DataSet DS, String Date)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String strSQL = "SELECT * from Reservations WHERE Res_Status = 'CI' AND Dept_Date = DATE '" + Date + "'";

            OracleCommand cmd = new OracleCommand(strSQL, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.Fill(DS, "ss");

            conn.Close();

            return DS;
        }

        //Gets all Reservations that are No-Shows
        public static DataSet getNoShows(DataSet DS)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String strSQL = "SELECT * from Reservations WHERE Res_Status = 'B' AND Arrival_Date < SYSDATE-1";

            OracleCommand cmd = new OracleCommand(strSQL, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.Fill(DS, "ss");

            conn.Close();

            return DS;
        }

        //Gets the Monthly Revenue of the Hotel for the specified year
        public static DataSet getMonthlyData(DataSet DS, String Year)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String strSQL = "SELECT TO_CHAR(Pay_Date,'MM'), SUM(Amount_Paid) FROM Payments WHERE Pay_Date LIKE '%" + Year + "' GROUP BY TO_CHAR(Pay_Date, 'MM') " +
                            "ORDER BY TO_CHAR(Pay_Date, 'MM')";
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.Fill(DS, "ss");

            conn.Close();

            return DS;
        }

        //Gets the amount of bookings for the specified year based on the Room Type
        public static DataSet getTypeData(DataSet DS, String Year, String Type)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String strSQL = "SELECT TO_CHAR(Dept_Date,'MM'), COUNT(ResNo) FROM Reservations rs JOIN Rooms rm ON rm.RoomNo = rs.RoomNo WHERE Dept_Date LIKE '%" + Year + "' AND rm.Room_Type" +
                "= '" + Type + "' GROUP BY TO_CHAR(Dept_Date, 'MM') ORDER BY TO_CHAR(Dept_Date, 'MM')";
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.Fill(DS, "ss");

            conn.Close();

            return DS;
        }
    }
}
