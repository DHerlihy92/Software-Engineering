using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace WindowsFormsApp1
{
    class Payment
    {
        private int payID;
        private string payDate;
        private double amountPaid;
        private int custID;
        private int resNo;

        public void setPayID(int PayID)
        {
            payID = PayID;
        }

        public void setPayDate(string PayDate)
        {
            payDate = PayDate;
        }

        public void setAmountPaid(double AmountPaid)
        {
            amountPaid = AmountPaid;
        }

        public void setCustID(int CustID)
        {
            custID = CustID;
        }

        public void setResNo(int ResNo)
        {
            resNo = ResNo;
        }

        public int getPayID()
        {
            return payID;
        }

        public string getPayDate()
        {
            return payDate;
        }

        public double getAmountPaid()
        {
            return amountPaid;
        }

        public int getCustID()
        {
            return custID;
        }

        public int getResNo()
        {
            return resNo;
        }

        public Payment()
        {
            payID = 0;
            payDate = "";
            amountPaid = 0;
            custID = 0;
            resNo = 0;
        }

        public static int nextPayID()
        {
            int nextID;

            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            String strSQL = "SELECT MAX(PayID) FROM Payments";

            OracleCommand cmd = new OracleCommand(strSQL, conn);

            OracleDataReader dr = cmd.ExecuteReader();

            dr.Read();

            if (dr.IsDBNull(0))
                nextID = 1001;
            else
                nextID = Convert.ToInt16(dr.GetValue(0)) + 1;

            conn.Close();
            return nextID;
        }

        public void addPayment()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            conn.Open();

            String strSQL1 = "INSERT INTO Payments VALUES (" + this.payID + ", DATE '" + this.payDate + "',0,1001," + this.resNo + ")";
            //"INSERT INTO Payments VALUES(" + this.payID + ",DATE '" + this.payDate + "') SELECT Cost, CustID, ResNo FROM Reservations WHERE ResNo = " + this.resNo;
            // + this.amountPaid + ","+ this.custID + "," + this.resNo + ")";
            //String strSQL2 = "Update Payments(Amount_Paid, CustID) SELECT Res_Cost, CustID FROM Reservations WHERE ResNo = " + this.resNo;

            //String strSQL2 = "UPDATE Payments SET pay.Amount_Paid = res.Cost, pay.CustID = res.CustID FROM Payments pay INNER JOIN Reservations res ON pay.ResNo = res.ResNo WHERE pay.ResNo = " + this.resNo; 

            String strSQL2 = "UPDATE (SELECT pay.Amount_Paid cost1, pay.CustID id1, res.Res_Cost cost2, res.CustID id2 FROM Payments pay, Reservations res WHERE pay.ResNo = res.ResNo) SET " +
                "cost1 = cost2, id1 = id2 ";

            OracleCommand cmd1 = new OracleCommand(strSQL1, conn);
            cmd1.ExecuteNonQuery();

            OracleCommand cmd2 = new OracleCommand(strSQL2, conn);
            cmd2.ExecuteNonQuery();

            conn.Close();
        }
    }
}
