using CovidProject.DataStructues; //Proj is in COvid Folder but Class is in Data STructures folder so use this namespace.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CovidProject
{
    class Program
    {


        static void Main(string[] args)
        {

            Patient_Data pd = Patient_Data.Pdetails();   //Create Singleton Object in Main

            //to add values to a dictionary always use a GETTER method store in Dictionary later use a Setter method.

            Dictionary<int, Patient> s = pd.Getpatientdata();

            // Passing arguments
            // General(101, "Rahul", 33, 10, 2, "AB", "Bglr", "Viral", "Med", "Cold", 5, "NO");

            //Creating obj and assigning to Patient
            Patient p1= General(101, "Rahul", 33, 65, 2, "AB", "Bglr", "Viral", "Med", "Cold", 5, "NO");


           


            //pd.Setpatientdata


            Patient p2 =General(102, "Jon", 22, 77, 2, "B+", "Goa", "Viral", "Med", "Cough", 7, "Yes");

            Patient p3 =General(103, "Jim", 245, 10, 2, "Z+", "Bglr", "WaterBorne", "Covid", "Fever", 2, "Yes");

            Patient p4 = General(104, "Tim", 222, 70, 2, "+A", "Goa", "Viral", "Med", "Cold", 1, "NO");

            Patient p5 = General(105, "Kim", 222, 69, 2, "S+", "Jaipur", "Viral", "Med", "Cold", 5, "NO");

            //Add a new variiable : pt_covid : Add in Patinet Class and Main 

            //Updating Dictionary with values. Fetch data using getter method
            s.Add(p1.Getpatient_ID(),p1);
            s.Add(p2.Getpatient_ID(), p2);
            s.Add(p3.Getpatient_ID(), p3);
            s.Add(p4.Getpatient_ID(), p4);
            s.Add(p5.Getpatient_ID(), p5);
            int count = 0;
            
            foreach (var fetch in s)
            {

                Patient p= fetch.Value;
              string a =  p.Getpatient_illness().Getsymptoms();
                int agefactor = p.Getpatient_age();
                string pt_name = p.Getpatient_Name();
                string pt_illness = p.Getpatient_illness().GetAnyExistingillness();
                string pt_severity = p.Getpatient_illness().Getseverity(); //Check which Pt has Covid using severity parameter.


                //Check how many Pt have Cold (Count)
                if (a.Equals("Cold"))
                    {

                    Console.WriteLine(s);
                    count++;
                    }
                    Console.WriteLine(count);

                //Check how many Pt are above 60 age
                if(agefactor > 60)
                {
                    Console.WriteLine("Patient Name" + pt_name  ,  "Age" + agefactor,"Existing Illness" + pt_illness);
                    //count++;
                   
                }

                //Pt details of those having Covid
                if (pt_severity.Equals("Covid"))
                {

                    Console.WriteLine("Patient Name" + pt_name, "Age" + agefactor, "Is Diagnosied with " + pt_severity);
                    
                }
               

            }


            

            //Set Dictionary  back to Patient Data Class

            pd.Setpatientdata(s);


         
            //Patient p1 = new Patient(); //Create 5 Patient Objects 
            //Patient p2 = new Patient();
            //Patient p3 = new Patient();
            //Patient p4 = new Patient();
            //Patient p5 = new Patient();

            //no method name exists.
            // public static Patient_Data

            //Illness i1 = new Illness();
            //Illness i2 = new Illness();
            //Illness i3 = new Illness();
            //Illness i4 = new Illness();
            //Illness i5 = new Illness();



            //i1.Setvirustype("Viral");
            //i1.Setsymptoms("cold");
            //i1.Setseverity("Med");
            //i1.SetNoOfDays(10);
            //i1.SetAnyExistingillness("Yes");

            //i2.Setvirustype("Viral");
            //i2.Setsymptoms("coough");
            //i2.Setseverity("Low");
            //i2.SetNoOfDays(10);
            //i2.SetAnyExistingillness("No");


            //i3.Setvirustype("Waterborne");
            //i3.Setsymptoms("fever");
            //i3.Setseverity("Low");
            //i3.SetNoOfDays(10);
            //i3.SetAnyExistingillness("No");


            //i4.Setvirustype("From Food");
            //i4.Setsymptoms("cold");
            //i4.Setseverity("Low");
            //i4.SetNoOfDays(4);
            //i4.SetAnyExistingillness("No");


            //i5.Setvirustype("Viral");
            //i5.Setsymptoms("cough");
            //i5.Setseverity("High");
            //i5.SetNoOfDays(12);
            //i5.SetAnyExistingillness("No");




            //// First Approach : Setting Illness Object(i1) with Patient Object(p1) : ilness class data.
            ////(Along with illness data Patient data also appears in this approach.

            //p1.Setpatient_illness(i1);
            //p2.Setpatient_illness(i2);
            //p3.Setpatient_illness(i3);
            //p4.Setpatient_illness(i4);
            //p5.Setpatient_illness(i5);





            ////Add data to Dictionary





            //p1.Setpatient_ID(100);

            ////WIll return illness object : Setting patientid dynamically to illness class. 
            ////Fetching just the Patient ID from Patient Class as all other parameterts are set explicitly.line 113 ,119 etc
            ////Getpatient_illness() -> will link both Patient Class and Illnesss class.

            //p1.Getpatient_illness().SetpatientID(p1.Getpatient_ID());

            //p2.Setpatient_ID(101);
            //p2.Getpatient_illness().SetpatientID(p2.Getpatient_ID());
            //p3.Setpatient_ID(102);
            //p3.Getpatient_illness().SetpatientID(p3.Getpatient_ID());
            //p4.Setpatient_ID(103);
            //p4.Getpatient_illness().SetpatientID(p4.Getpatient_ID());
            //p5.Setpatient_ID(104);
            //p5.Getpatient_illness().SetpatientID(p5.Getpatient_ID());


            //p1.Setpatient_age(10);
            //p2.Setpatient_age(40);
            //p3.Setpatient_age(22);
            //p4.Setpatient_age(55);
            //p5.Setpatient_age(33);

            //p1.Setpatient_address(17);
            //p2.Setpatient_address(15);
            //p3.Setpatient_address(8);
            //p4.Setpatient_address(9);
            //p5.Setpatient_address(2);

            //p1.Setpatient_bloodgroup("O");
            //p2.Setpatient_bloodgroup("B");
            //p3.Setpatient_bloodgroup("A");
            //p4.Setpatient_bloodgroup("A+");
            //p5.Setpatient_bloodgroup("AB");

            //p1.Setpatient_City("Bglr");
            //p2.Setpatient_City("Goa");
            //p3.Setpatient_City("Mysore");
            //p4.Setpatient_City("Delhi");
            //p5.Setpatient_City("Bglr");

            //p1.Setpatient_Name("Rahul");
            //p2.Setpatient_Name("John");
            //p3.Setpatient_Name("Raj");
            //p4.Setpatient_Name("Minuu");
            //p5.Setpatient_Name("Radha");

            //p1.Setpatient_phone(767828678);
            //p2.Setpatient_phone(767838678);
            //p3.Setpatient_phone(767828678);
            //p4.Setpatient_phone(767818678);
            //p5.Setpatient_phone(767848678);

            // Just One record need to created.
            //p.Setpatient_illness("Cold");


        }

        //Creating a method of type Patient , since now data is for 5 patients it may increase to 50 2moro.
        //Helper Method : Generic method that perform some Operation

        static Patient General(int patient_ID, string patient_Name, int patient_phone, int patient_age, int patient_address,
            string patient_bloodgroup, string patient_City, string virustype, string severity, string symptoms, int NoOfDays, string AnyExistingillness)
        {
            //create objec of patient and set values of illness /patient to Patient object.

            //Create Patient Object to store PT data
            Patient pt = new Patient();

            //Create Patient Object to store Illness data
            Illness ill = new Illness();

            ill.SetpatientID(patient_ID);
            ill.Setvirustype(virustype);
            ill.Setseverity(severity);
            ill.Setsymptoms(symptoms);
            ill.SetNoOfDays(NoOfDays);
            ill.SetAnyExistingillness(AnyExistingillness);



            //Assigning the Pt(pt) object to Illness object(ill)
            pt.Setpatient_illness(ill);

            //Here values are not hardcoded its just parameters in future any changes just make changes to this code.
            pt.Setpatient_ID(patient_ID);
            pt.Setpatient_Name(patient_Name);
            pt.Setpatient_phone(patient_phone);
            pt.Setpatient_age(patient_age);
            pt.Setpatient_address(patient_address);

            //Adding a Regular Expression
            MatchCollection m = Regex.Matches(patient_bloodgroup, "A|B|O", RegexOptions.IgnoreCase);

            if (m.Count > 0)
            {
                pt.Setpatient_bloodgroup(patient_bloodgroup); //Invoke bloodgp setter method if  pattern has been matched for bloodgroup;
            }

            else
            {
                //else setting blood Gp to NA
                pt.Setpatient_bloodgroup("NA");
                
            }
           // pt.Setpatient_bloodgroup(patient_bloodgroup);

            pt.Setpatient_City(patient_City);


        

            return pt;

            //string bgroup = "AB+"; //Upper case

           // string bloodgroup = "ab+";  //Lower case


            //regexoptions: ignorecase -it considers upper & lower case.
          





            //foreach (var s in bloodgroup)
            //    {

            //    Console.WriteLine(s);
            
            //     }







        }
        }
    }



//Other Programs***********************************************************************

        // enum Week { Monday,Tuesday,Wed,}
        // static void Main(string[] args)
       // {
            ////Enum*******************************************************


            //int count = (int)Week.Monday;

            //Console.WriteLine(count);
            //var values = Enum.GetValues(typeof(Week));
            //foreach(var individual in values)
            //{
            //    Console.WriteLine(individual); //Print only values
            //}
            
            
            
            
            
            //********************************************************

            //Nullable Types :

            //bool? covidresults = null; //if u know there could be null i/p than use this ie person has not tested .

            //if(covidresults==true)
            //{
            //    Console.WriteLine("Positive");

            //}
            //else if(covidresults==false)
            //{
            //    Console.WriteLine("Negative");
            //}
            //else
            //{
            //    Console.WriteLine("Not tested");
            //}

//*******************************************************************************
            ////Here u have multiple string OBjects
            //// string a = "A";
            //string a = " World is beautiful";
            //string b = "B";

            //a = a + b;
            //Console.WriteLine(a);

            ////Use StringBuilder

            //StringBuilder s = new StringBuilder(a);

            //s.Append("C");
            //s.Remove(0, 2);
            //s.Replace("How", "Is");
            //s.Insert(0, "Test **");

            //Console.WriteLine(s);



