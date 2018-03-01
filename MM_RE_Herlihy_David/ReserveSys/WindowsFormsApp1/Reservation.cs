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
                nextRes = 101;
            else
                nextRes = Convert.ToInt16(dr.GetValue(0)) + 1;

            conn.Close();
            return nextRes;

        }

        public static DataSet getUnoccupiedRooms(DataSet DS, string ArrivalDate, string DeptDate, string Type)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String strSQL = "SELECT * FROM Rooms rm WHERE rm.RoomNo NOT IN (SELECT DISTINCT RoomNo FROM Reservations rs WHERE(rs.Arrival_Date BETWEEN '"+ ArrivalDate +
                            "' AND '" + DeptDate + "') OR(rs.Dept_Date BETWEEN '" + ArrivalDate + "' AND '" +DeptDate +"') OR (rs.Arrival_Date < '" + ArrivalDate + 
                            "' AND rs.Dept_Date > '" + DeptDate +"')) AND rm.Room_Type = '" + Type +  "'";

            OracleCommand cmd = new OracleCommand(strSQL, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.Fill(DS, "ss");

            conn.Close();

            return DS;
        }

        public void addReservation()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            conn.Open();

            String strSQL = "INSERT INTO Reservations VALUES(" +this.resNo + ",DATE '" +this.arrivalDate + "',DATE '" + this.deptDate + "','" + this.resStatus + "'," +
                + this.custID + "," + this.roomNo +")";

            OracleCommand cmd = new OracleCommand(strSQL, conn);
            cmd.ExecuteNonQuery();

            conn.Close();
        }


    }
}
