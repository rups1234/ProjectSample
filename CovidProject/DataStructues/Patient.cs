using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovidProject.DataStructues
{
    class Patient
    {
        //Values will be passed using Excel . How can we modify the code for dynamically changing data.
        public int patient_ID;
        public string patient_Name;
        public int patient_phone;
        public int patient_age;
        public int patient_address; // This will have both alphabets / numbers should be integer?
        public string patient_bloodgroup;
        public string patient_City;



        //store Object of Illness class

        public Illness objectillness;



        public void Setpatient_illness(Illness objectillness)
        {

            this.objectillness = objectillness;
        }

        public Illness Getpatient_illness()
        {

            return objectillness;
        }






        public void Setpatient_ID(int patient_ID)
        {

            this.patient_ID = patient_ID;
        }

        public void Setpatient_Name(string patient_Name)
        {

            this.patient_Name = patient_Name;
        }
        public void Setpatient_phone(int patient_phone)
        {

            this.patient_phone = patient_phone;
        }
        public void Setpatient_age(int patient_age)
        {

            this.patient_age = patient_age;
        }
        public void Setpatient_address(int patient_address)
        {

            this.patient_address = patient_address;
        }
        public void Setpatient_bloodgroup(string patient_bloodgroup)
        {

            this.patient_bloodgroup = patient_bloodgroup;
        }
        public void Setpatient_City(string patient_City)
        {

            this.patient_City = patient_City;
        }
        public int Getpatient_ID()
        {

            return patient_ID;

        }

        internal void Setpatient_illness(string v)
        {
            throw new NotImplementedException();
        }

        public string Getpatient_Name()
        {

            return patient_Name;

        }
        public int Getpatient_phone()
        {

            return patient_phone;

        }
        public int Getpatient_age()
        {

            return patient_age;

        }
        public int Getpatient_address()
        {

            return patient_address;

        }
        public string Getpatient_bloodgroup()
        {

            return patient_bloodgroup;

        }
        public string Getpatient_City()
        {

            return patient_City;

        }

    }
}
