using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovidProject.DataStructues
{
    class Illness
    {
        public string virustype;
        public string severity;
        public string symptoms;
        public int NoOfDays;
        public string AnyExistingillness;
        public int patientID;


        //Setter and Getter methods for PatientID as I try to retriev just Patient ID from Illness Class.
        public void SetpatientID(int patientID)
        {

            this.patientID = patientID;
        }

        public int GetpatientdataID()
        {


            return patientID;
        }

        public void Setvirustype(string virustype)
        {

            this.virustype = virustype;
        }
        public void Setseverity(string severity)
        {

            this.severity = severity;
        }


        public void Setsymptoms(string symptoms)
        {

            this.symptoms = symptoms;
        }
        public void SetNoOfDays(int NoOfDays)
        {

            this.NoOfDays = NoOfDays;
        }

        

        public void SetAnyExistingillness(string AnyExistingillness)
        {

            this.AnyExistingillness = AnyExistingillness;
        }


        public string Getvirustype()
        {

            return virustype;

        }

        public string Getseverity()
        {

            return severity;

        }
        public string Getsymptoms()
        {

            return symptoms;

        }
        public int GetNoOfDays()
        {

            return NoOfDays;

        }
        public string GetAnyExistingillness()
        {

            return AnyExistingillness;

        }

        //public static implicit operator string(Illness v)
        //{

        //}
    }
}
