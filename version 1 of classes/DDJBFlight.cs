//========================================================== 

// Student Number	:

// Student Name	: 

// Partner Name	: Valerie Soh Jia Qi

//========================================================== 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG_2_Assignment
{
    class DDJBFlight : Flight
    {
        public double RequestFee { get; set; }
        public string SpecialRequestCode { get; set; }
        public double CalculateFees()
        {
            double fee = 0;

            if (SpecialRequestCode == "DDJB")
            {
                fee += 300;
            }
            return fee;
        }
        public DDJBFlight(string fn, string ori, string dest, DateTime et, string stat) : base(fn, ori, dest, et, stat) { }
        public override string ToString()
        {
            return $"Flight Number: {FlightNumber}, Origin: {Origin}, Destination: {Destination}, Expected Time: {ExpectedTime}, Status: {Status}";
        }
    }
}
