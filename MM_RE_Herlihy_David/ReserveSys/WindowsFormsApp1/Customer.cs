using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace WindowsFormsApp1
{
    class Customer
    {
        private int custID;
        private string fName;
        private string sName;
        private string street;
        private string town;
        private string county;
        private string tel_No;
        private int cardNo;
        private string cardName;

        public void setCustID(int CustID)
        {
            custID = CustID;
        }

        public void setFname(string FName)
        {
            fName = FName;
        }

        public void setSName(string SName)
        {
            sName = SName;
        }

        public void setStreet(string Street)
        {
            street = Street;
        }

        public void setTown(string Town)
        {
            town = Town;
        }

        public void setCounty( string County)
        {
            county = County;
        }

        public void setTel_No(string Tel_No)
        {
            tel_No = Tel_No;
        }

        public void setCardNo(int CardNo)
        {
            cardNo = CardNo;
        }

        public void setCardName(string CardName)
        {
            cardName = CardName;
        }

        public int getCustID()
        {
            return custID;
        }

        public string getFName()
        {
            return fName;
        }

        public string getSName()
        {
            return sName;
        }

        public string getStreet()
        {
            return street;
        }

        public string getTown()
        {
            return town;
        }

        public string getCounty()
        {
            return county;
        }

        public string getTel_No()
        {
            return tel_No;
        }

        public int getCardNo()
        {
            return cardNo;
        }

        public string getCardName()
        {
            return cardName;
        }

        public Customer(int custID, string fName, string sName, string street, string town, string county, string tel_No, int cardNo, string cardName)
        {
            this.custID = custID;
            this.fName = fName;
            this.sName = sName;
            this.street = street;
            this.town = town;
            this.county = county;
            this.tel_No = tel_No;
            this.cardNo = cardNo;
            this.cardName = cardName;
        }

        public Customer()
        {
            custID = 0;
            fName = "";
            sName = "";
            street = "";
            town = "";
            tel_No = "";
            cardNo = 0;
            cardName = "";
        }
        //Generates next Customer ID
        public static int nextCustomer()
        {
            int nextCust;

            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            String strSQL = "SELECT MAX(CustID) FROM Customers";

            OracleCommand cmd = new OracleCommand(strSQL, conn);

            OracleDataReader dr = cmd.ExecuteReader();

            dr.Read();

            if (dr.IsDBNull(0))
                nextCust = 1001;
            else
                nextCust = Convert.ToInt16(dr.GetValue(0)) + 1;

            conn.Close();
            return nextCust;

        }

        //Saves a customer to the Customer File
        public void addCustomer()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            conn.Open();

            String strSQL = "INSERT INTO Customers VALUES(" + this.custID + ",'" + this.fName.ToUpper() + "','" + this.sName.ToUpper()
                + "','" + this.street.ToUpper() + "','" + this.town.ToUpper() + "','" + this.county.ToUpper() + "','" + this.tel_No.ToUpper() +
                "'," + this.cardNo + ",'" + this.cardName.ToUpper() + "')";

            OracleCommand cmd = new OracleCommand(strSQL, conn);
            cmd.ExecuteNonQuery();

            conn.Close();
        }
    }
}
