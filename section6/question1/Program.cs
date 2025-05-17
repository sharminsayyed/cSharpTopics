/*
 You should create two classes - MedicalBot and Patient - to implement this functionality.


Part 1: MedicalBot class
The MedicalBot class should have a constant string variable named BotName with the value "Bob" that represents the name of the medical bot.



It should have a static method called GetBotName() that returns value of "BotName" constant.



The MedicalBot class should also have a method named PrescribeMedication() that takes a Patient object as an argument. The PrescribeMedication() method should determine the medication to prescribe based on the symptoms of the patient.



void PrescribeMedication(Patient patient)



If the patient's symptoms are a headache, prescribe ibuprofen.

If the patient's symptoms are skin rashes, prescribe diphenhydramine.

If the patient's symptoms are dizziness, check if the patient has a medical history of diabetes. If they do, prescribe metformin. Otherwise, prescribe dimenhydrinate.



The PrescribeMedication() method should invoke another local function called GetDosage() to specify dosage of the specified medicine.



string GetDosage(string medicineName)

The GetDosage() method receives he medicine name prescribed by the PrescribeMedication() method and returns corresponding dosage as follows:



If the medicine name is ibuprofen:

If the patient's age is less than 18, then the dosage is 400 mg. Otherwise, the dosage is 800 mg.



If the medicine name is diphenhydramine:

If the patient's age is less than 18, then the dosage is 50 mg. Otherwise, the dosage is 300 mg.



If the medicine name is dimenhydrinate:

If the patient's age is less than 18, then the dosage is 50 mg. Otherwise, the dosage is 400 mg.



If the medicine name is metformin, then the dosage is 500 mg for all patients.







Part 2: Patient class
The Patient class should have the following fields:



name: A string representing the name of the patient.

age: An integer representing the age of the patient.

gender: A string representing the gender of the patient.

medicalHistory: A string representing the medical history of the patient.

symptomCode: A string representing the code for the symptoms of the patient.

prescription: A string representing the medication prescribed to the patient.



The Patient class should also have essential set / get methods for all the above fields. The Get methods returns the value of corresponding field. The Set methods should perform appropriate validation and assign the value into the field only if a valid value is supplied as argument. The Set methods should return a boolean value indicating whether the value is valid or not. If the value is valid, it should return true; otherwise false. In case of invalid value, an error message should be returned as "out" parameter. In case of valid value, an empty string should be returned as error message as "out" parameter.





GetName(): Returns the name of the patient.

SetName(string name, out string errorMessage): Sets the name of the patient and validates it. Returns a bool indicating whether the name is valid or not, and an error message if it's invalid. The name should not be null or empty. Patient name should contain at least two or more characters.

GetAge(): Returns the age of the patient.

SetAge(int age, out string errorMessage): Sets the age of the patient and validates it. Returns a bool indicating whether the age is valid or not, and an error message if it's invalid. Patient age can't be negative. Patient age can't be greater than 100.

GetGender(): Returns the gender of the patient.

SetGender(string gender, out string errorMessage): Sets the gender of the patient and validates it. Returns a bool indicating whether the gender is valid or not, and an error message if it's invalid. Patient gender should be either Male, Female or Other

GetMedicalHistory(): Returns the medical history of the patient.

SetMedicalHistory(string medicalHistory): Sets the medical history of the patient. No specific validations need to be checked for this value.

SetSymptomCode(string symptomCode, out string errorMessage): Sets the symptom code of the patient. Symptom Code should either be S1, S2, or S3.

GetSymptoms(): Returns the symptom description based on the current value of 'symptomCode' field.

S1 / s1: Headache

S2 / s2: Skin rashes

S3 / s3: Dizziness

Any other value: Unknown



GetPrescription(): Returns the medication prescribed to the patient.

SetPrescription(string prescription): Sets the medication prescribed to the patient. No specific validations need to be checked for this value.





Part 3: Main() method
This application will be used by patient users. The Main() method (entry point) should read all inputs (patient name, age, gender, medical history, symptoms etc.) from the patient and call "PrescribeMedication()" method of MedicalBot class and display the result prescription that was returned by the PrescribeMedication() method.*/

using System;

class MedicalBot
{
    private const string BotName = "Bob";

    public static string GetBotName()
    {
        return BotName;
    }

    public void PrescribeMedication(Patient p)
    {
        Console.WriteLine("Your prescription based on your age, symptoms and medical history:");
        string prescription =null;
        if (p.GetSymptoms() == "S1")
        {
            prescription = "ibuprofen";
            string dosage = GetDosage(prescription);
            string finalPrescription = prescription + "  "+dosage;
            p.SetPrescription(finalPrescription);
        }
        else if (p.GetSymptoms() == "S2")
        {
            prescription = "diphenhydramine";
            string dosage = GetDosage(prescription);
            string finalPrescription = prescription + "  " + dosage;
            p.SetPrescription(finalPrescription);
        }
        else
        { //p.GetSymptoms() == "S3"

            if(p.GetMedicalHistory() == "Diabetes") 
            {
                prescription = "metformin";
                string dosage = GetDosage(prescription);
                string finalPrescription = prescription + "  " + dosage;
                p.SetPrescription(finalPrescription);
            }
            else
            {
                prescription = "diphenhydramine";
                string dosage = GetDosage(prescription);
                string finalPrescription = prescription + "  " + dosage;
                p.SetPrescription(finalPrescription);
            }
        }

        string GetDosage(string medicineName)
        {
            string dosage = null;
            if(medicineName == "ibuprofen")
            {
                if(p.GetAge() < 18)
                {
                    return dosage = "400mg";
                }
                else
                {
                    return dosage = "800mg";
                }
            }
            else if(medicineName == "metformin")
            {
                return dosage = "500mg";
            }
            else
            { //medicineName == "diphenhydramine"
                if (p.GetAge() < 18)
                {
                    return dosage = "50mg";
                }
                else
                {
                    return dosage = "400mg";
                }
            }
        }


    }
}

class Patient
{
    private string name;
    private int age;
    private string gender;
    private string medicalHistory;
    private string symptomCode;
    private string prescription;

    public string GetName()
    {
        return name;
    }

    public bool SetName(string name, out string errorMessage)
    {
        if (name == null)
        {
            errorMessage = "invalid name - name field is null ";
            return false;
        }
        else if (name.Length < 2)
        {
            errorMessage = "invalid name - name should have atleast 2 characters ";
            return false;
        }
        else
        {
            this.name = name;
            errorMessage = "";
            return true;
        }
    }

    public int GetAge()
    {
        return age;
    }

    public bool SetAge(int age, out string errorMessage)
    {
        if(age < 0)
        {
            errorMessage = "invalid age - age should not negative";
            return false;
        } 
        else if (age > 100)
        {
            errorMessage = "invalid age - age should not be above 100";
            return false;
        }
        else
        {
            this.age = age;
            errorMessage = "";
            return true;
        }
    }

    public string GetGender()
    {
        return gender;
    }

    public bool setGender (string gender , out string errorMessage) 
    {
        if(gender == "Male" || gender == "Female" || gender == "Other")
        {
            this.gender = gender;
            errorMessage = "";
            return true;
        }
        else
        {
            errorMessage = "invalid gender";
            return false;
        }
    }
    public string GetMedicalHistory()
    {
        return medicalHistory;
    }

    public void SetMedicalHistory(string medicalHistory)
    {
        this.medicalHistory = medicalHistory;
    }
    public string GetSymptoms()
    {
        return symptomCode;
    }

    public bool SetSymptomCode(string symptomCode, out string errorMessage)
    {
        if (symptomCode == "S1" || symptomCode == "S2" || symptomCode == "S3")
        {
            this.symptomCode = symptomCode;
            errorMessage = "";
            return true;
        }
        else
        {
            errorMessage = "invalid symptom - enter S1,S2,S3 these are valid ";
            return false;
        }
    }

    public string GetPrescription()
    {
        return prescription;
    }

    public void SetPrescription(string prescription)
    {
        this.prescription = prescription;
    }


}

class Program
{
    static void Main()
    {
        Patient p = new Patient();
        MedicalBot b = new MedicalBot();

        Console.WriteLine("Hi, I'm "+ MedicalBot.GetBotName() + ". I'm here to help you in your medication.");

        Console.WriteLine("Enter your (patient) details:");

        Console.Write("Enter Patient Name:");
        string nm = Console.ReadLine() ;
        while(!p.SetName(nm, out string errorMessage))
        {
            Console.WriteLine(errorMessage);
            Console.Write("Enter Patient Name:");
            nm = Console.ReadLine();
        }

        Console.Write("Enter Patient Age: ");
        int age =int.Parse(Console.ReadLine()) ;
        while(!p.SetAge(age , out string errorMessage))
        {
            Console.WriteLine(errorMessage);
            Console.Write("Enter Patient Age: ");
            age = int.Parse(Console.ReadLine());

        }

        Console.Write("Enter Patient Gender: ");
        string gender = Console.ReadLine();
        while(!p.setGender(gender , out string errorMessage))
        {
            Console.WriteLine(errorMessage);
            Console.Write("Enter Patient Age: ");
            gender = Console.ReadLine();
        }


        Console.Write("Enter Medical History. Eg: Diabetes. Press Enter for None:");
        string medicalHistory = Console.ReadLine();
        p.SetMedicalHistory(medicalHistory);


        Console.WriteLine("\n\nWelcome,"+p.GetName() +", "+p.GetAge());
        Console.WriteLine("Which of the following symptoms do you have: \nS1. Headache \nS2. Skin rashes \nS3. Dizziness");
        Console.Write("Enter the symptom code from above list (S1, S2 or S3): ");
        string symptonCode = Console.ReadLine();
        while(!p.SetSymptomCode(symptonCode ,out string errorMessage))
        {
            Console.WriteLine(errorMessage);
            Console.Write("Enter the symptom code from above list (S1, S2 or S3): ");
            symptonCode = Console.ReadLine();
        }

        Console.WriteLine("\n");
        b.PrescribeMedication(p);
        string finalprescription = p.GetPrescription();
        Console.WriteLine(finalprescription);

        Console.WriteLine("Thank you for coming.");
        Console.ReadKey();


    }
}