using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovidProject.DataStructues
{
    class Patient_Data //Singleton Class
    {
        //datamember
        // p_data_illness is a collection of type dictionary having patirnt id as key and patient object as value.

        private Dictionary<int, Patient> p_data_illness = new Dictionary<int, Patient>();

        private static Patient_Data p1;

        private Patient_Data()
        {

        }
        //Creating Objects (Singleton) in this method
        public static Patient_Data Pdetails()
        {
            if (p1 == null)
            { p1 = new Patient_Data(); }
            
            //Singleton Object
                return p1;

        }


        //Setpatientdata-> Set patient data
        public void Setpatientdata(Dictionary<int, Patient> p_data_illness)
         {
            this.p_data_illness = p_data_illness;


        }



        public Dictionary<int, Patient> Getpatientdata()
        {
            return p_data_illness;
        }
    }
}
