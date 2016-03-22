using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IntakeQuestionnaire.Models
{
    public class Questionnaire
    {
        /// <Details Of principle applicant> 
        /// All details of the application
        [Required]
        
        [Display(Name="APPLICATION REF #")]
        public String ApplicationRefNumber { get; set; }

        [Required]
        [Display(Name="FAMILY CODE")]
        public String familyCode { get; set; }

        [Required]
        [DataType("MM/YYYY")]
        [Display(Name="FILE OPENED")]
        public String DateFileOpened { get; set; }

        [Required]
        [Display(Name="NO.")]

        //Next FieldSet
            public int No { get; set; }
            [Required]
            [RegularExpression("^[a-zA-Z ]*$")]
            [Display(Name="Interpreter")]
            public String Interpreter { get; set; }
            [Required]
            [RegularExpression("^[a-zA-Z ]*$")]
            [Display(Name="Surname")]
            public String Surname { get; set; }
            [Required]
            [RegularExpression("^[a-zA-Z ]*$")]
            [Display(Name="FirstName(s)")]
            public String FirstName { get; set; }
            [Required]
            [RegularExpression("^[a-zA-Z ]*$")]
            [Display(Name="Initials")]
            public String Initials { get; set; }
            [Required]
            [RegularExpression("^[a-zA-Z ]*$")]
            [Display(Name="CommunityName")]
            public String CommunityName { get; set; }
            [Required]
            [Display(Name="Known to the client")]
            public String YorN { get; set; }

        //Next FieldSet
                [Required]
                [RegularExpression("[^a-zA-Z ]*$")]
                [Display(Name="Contact No.")]
                public String ContactNumber { get; set; }
                [RegularExpression("^[a-zA-Z ]*$")]
                [Display(Name="Contact Name")]
                public String ContactName { get; set; }
                [Required]
                [Display(Name = "Current Address")]
                public String Address { get; set; }
                public bool Flag { get; set; }
                public String WhosContactNum { get; set; }
                [Required]
                [Display(Name="How long has the client been at this address:")]
                public String HowLongClientBeenAtAdressFor { get; set; }
        //Next FieldSet
                    [Required]
                    [Display(Name="Date of Birth")]
                    public String DOB { get; set; }
                    [Required]
                    [RegularExpression("^[a-zA-Z ]*$")]
                    [Display(Name="Country of Origin")]
                    public String Country { get; set; }
                    [Required]
                    public String Gender { get; set; }
                    [Required]
                    [Display(Name="Marital Status")]
                    public String MaritalStatus { get; set; }
                    [Required]
                    [Display(Name="Ethnic Group/Tribe")]
                    public String EthnicGroup { get; set; }
                    [Required]
                    public String Religion { get; set; }
                    [Required]
                    [Display(Name="Home Language")]
                    public String HomeLang { get; set; }
                    [Display(Name="Date")]
                    public String date { get; set; }
    [Required]
    [Display(Name = "Arrival Date in RSA")]
    public String ArrivalDate { get; set; }
    [Required]
    [Display(Name="Type OF Applicatn")]
    public String typeOfApplicatn { get; set; }
    [Required]
    [Display(Name = "DHA Ref No.")]
    public String DHAref { get; set; }
    [Required]
    [Display(Name = "Had First Interview")]
    public String firstInterview { get; set; }


    [Required]
    [Display(Name = "ID on refugee status")]
    public String refugeeSTAT { get; set; }
    [Required]
    [Display(Name = "Having a UNCTD")]
    public String UNCTD { get; set; }
    [Required]
    [Display(Name = "Arrival Date in Durban")]
    public String ArrivalDateDurban { get; set; }
    [Required]
    [Display(Name = "Date R/S Granted")]
    public String dateGranted { get; set; }
    [Required]
    [Display(Name = "When Status Expire")]
    public String whenStatusExpire { get; set; }

    [Display(Name = "First Interview Date")]

    public String firstInterviewDate { get; set; }

    [Display(Name = "SecondInterviewDate")]
    public String secondInterviewDate { get; set; }
                [Required]
                [Display(Name = "English Ability")]
                public String englishAbility { get; set; }
                [Required]
                [Display(Name = "Attending English Classes")]
                public String attendingEnglishClasses { get; set; }
                [Required]
                [RegularExpression("^[a-zA-Z ]*$")]
                [Display(Name = "Where and How Often")]
                public String whereAndHow { get; set; }

                [Required]
                [Display(Name = "Sharing Accomodation")]
                public String sharingAccomodation { get; set; }
                [Required]
                [RegularExpression("^[a-zA-Z ]*$")]
                [Display(Name = "Fullnames of Sharers")]
                public String fullNamesOfSharers { get; set; }  

    }
    public class QuestionnairePageTwo
    {
      [RegularExpression("^[a-zA-Z ]*$")]
      public String Surname { get; set; }

      [RegularExpression("^[a-zA-Z ]*$")]
      [Display(Name="Firstname(s)")]
      public String Firstname { get; set; }
      
      [Display(Name="Current Address")]
      public String address { get; set; }
       [RegularExpression("[^a-zA-Z ]*$")]
      [Display(Name="DHA Ref No.")]
      public String refN { get; set; }
      
      [Display(Name="Date of Birth")]
      public String dateOfBirth { get; set; }
      public String Gender { get; set; }
      [Display(Name="When did the client last see their spouse:")]
      [RegularExpression("^[a-zA-Z ]*$")]
      public String whenDidTheClientSee { get; set; }
      [RegularExpression("^[a-zA-Z ]*$")]
      [Display(Name="Where seen")]
      public String whereSeen { get; set; }
    }  
    public class QuestionnairePageThree{
/*--------------------------------------------------------------------------------*/
        [RegularExpression("^[a-zA-Z ]*$")]
        public string otherRelatives { get; set; }

        [Display(Name="Social Assistance")]
        
        public bool SocialAssistance { get; set; }

        public bool Medical { get; set; }

        public bool Education { get; set; }

        [Display(Name = "Vocational Training")]
        public bool vocationalTraining { get; set; }
 
        [Display(Name = "Funeral Assistance")]
        public bool FuneralAssistance { get; set; }

        [Display(Name = "Other (Specify)")]
        public bool Other { get; set; }

        [RegularExpression("^[a-zA-Z ]*$")]
        public String other1 { get; set; }
 /*--------------------------------------------------------------------------------*/

        [Display(Name = "Single Parent")]
        public bool singleParent { get; set; }

        public bool Youth { get; set; }

        [Display(Name="Vulnerable Child/UAM")]
        public bool VulnerableChild { get; set; }

        public bool Abused { get; set; }

        public bool HIV { get; set; }

        public bool Neglected { get; set; }

        public bool Orphan { get; set; }

        [Display(Name = "Vulnerable Family")]
        public bool vulnerableFamily { get; set; }
        
        [Display(Name = "Chronically Ill")]
        public bool ill { get; set; }
        public bool Cancer { get; set; }

        [Display(Name="HIV")]
        public bool HIV2 { get; set; }
        public bool Diabetes { get; set; }
        public bool TB { get; set; }

        [Display(Name="Mental illness")]
        public bool MentalIllness { get; set; }
        public bool Aged { get; set; }

        [Display(Name = "Vulnerable Women")]
        public bool vulnerableWomner { get; set; }

        [Display(Name="Single Male")]
        public bool singleMale { get; set; }

        [Display(Name="Sibling Headed")]
        public bool siblingHeaded { get; set; }

        [Display(Name="Other")]
        public bool Other2 { get; set; }

        [RegularExpression("^[a-zA-Z ]*$")]
        public String other_2 { get; set; }
 /*--------------------------------------------------------------------------------*/
        [Display(Name="Who is formally Employed and where:")]
        [RegularExpression("^[a-zA-Z ]*$")]
        public String whoIsFormally { get; set; }

        [Display(Name="Average Monthly Income")]
        [RegularExpression("[^a-zA-Z ]*$")]
        public String averageIncome { get; set; }

        [Display(Name="If totally unemployed, how have you been surviving")]
        [RegularExpression("^[a-zA-Z ]*$")]
        public String ifTotallyUnemployed { get; set; }

        [Display(Name="Who is self-employed and what is the nature of the activity")]
        [RegularExpression("^[a-zA-Z ]*$")]
        public String whoIsSelfEmployed { get; set; }

        [RegularExpression("[^a-zA-Z ]*$")]
        [Display(Name="Average monthly income")]
        public String averageMonthlyIncome { get; set; }
        /***************************/
        [RegularExpression("[^a-zA-Z ]*$")]
        [Display(Name="Rental Amount")]
        public String  RentalAmount { get; set; }

        [RegularExpression("[^a-zA-Z ]*$")]
        [Display(Name="Lights and Water")]
        public String lightsAndWater { get; set; }

        [RegularExpression("[^a-zA-Z ]*$")]
        public String  Food { get; set; }

        [RegularExpression("[^a-zA-Z ]*$")]
        public String Transport { get; set; }

        [RegularExpression("[^a-zA-Z ]*$")]
        [Display(Name="School Fees")]
        public String SchoolFees { get; set; }

        [Display(Name="Other")]
        public String OtherExpenditure { get; set; }
/*--------------------------------------------------------------------------------------*/
        public String YesorNo { get; set; }
        [Display(Name="Education")]
        public bool EducationAssistance { get; set; }
        public String EducationTextBox { get; set; }
        public bool Social { get; set; }
        public String SocialTextBox { get; set; }

        [Display(Name="Vocational Training")]
        public bool vocationalAssistance { get; set; }
        public String vocationalTextBox { get; set; }

        [Display(Name="Micro Loan")]
        public bool microLoan { get; set; }
        public String microLoanTextBox { get; set; }
        public bool Referral { get; set; }
        public String referralTextBox { get; set; }
/*--------------------------------------------------------------------------------------*/
        public bool NoorYes { get; set; }

        [Display(Name="Organisation Name/s")]
        [RegularExpression("^[a-zA-Z ]*$")]
        public String organisationName { get; set; }

        [Display(Name="When last assisted")]
        [RegularExpression("^[a-zA-Z ]*$")]
        public String whenLastAssisted { get; set; }

        [Display(Name="What is being provided:")]
        [RegularExpression("^[a-zA-Z ]*$")]
        public String whatIsBeingProvided { get; set; }
}
    public class questionnairePageFour
    {

        [RegularExpression("^[a-zA-Z ]*$")]
        [Required]
        [Display(Name="Fled from where")]
        public String FledFrom { get; set; }
        [Required]
        [Display(Name="Last address at Country of Origin")]
        public String lastAddress { get; set; }
        [Required]
        [Display(Name="Transit Route and Reasons for Leaving")]
        public String transitRoute { get; set; }
        [Required]
        [Display(Name = "Date of leaving")]
        public String DateofLeaving { get; set; }
        /*------------------------------------------------------------*/
        [Required]
        [Display(Name="Travel Paid by Whom")]
        public String TravelPaid { get; set; }
        [Display(Name="Stay at any Camp/s")]
        public String  stayAtAnyCamps { get; set; }
        [Display(Name="Camps Name/s")]
        public String CampsName { get; set; }
        [Display(Name="Dates at Camp/s")]
        public String DatesAtCamps { get; set; }
        [Display(Name="UNHCR Known")]
        public String UNHCR { get; set; }
        [Display(Name="Left with whom")]
        public String LeftWithWhom { get; set; }
        /*---------------------------------------------------------*/
        [Display(Name="Available Contact, Details of Family etc")]
        public String AvailableContact { get; set; }
        [Display(Name="Relationship to them")]
        public String RelationshipToThem { get; set; }
        /*--------------------------------------------------------*/
        [Display(Name="Tracing Required")]
        public String  TracingRequired { get; set; }
        [Display(Name="Where ICRC/UNHCR")]
        public String whereIcrc { get; set; }
        public String Other { get; set; }
        /*--------------------------------------------------------*/
        [Display(Name="Referred by whom")]
        public String referredBy { get; set; }
        [Display(Name="Date of Request")]
        public String DateOfRequest { get; set; }
        [Display(Name="What does the client want the office to assist with and for how long:")]
        public String whatDoesTheClient { get; set; }
        public String WorkersImpression { get; set; }
    }
    public class QuestionnairePageFive
    {
        [Display(Name="Current medical/health problems")]
        public String CurrentMedical { get; set; }
        [Display(Name="If Yes, list the problems(diagnosis) and treatment")]
        public String ifYesList { get; set; }    

        [Display(Name="Are You Pregnant? (female)")]
        public String areYouPregnant { get; set; }

        [Display(Name = "Spouse/wife pregnant (male)")]
        public String spousePregnant { get; set; }
        [Display(Name="If Yes, details re stage of pregnancy etc.")]
        public String ifYesDetailsOfPreg { get; set; }
        [Display(Name="Do you have chronic terminal illness")]
        public String doYouHaveChronic { get; set; }
        [Display(Name="If Yes,When diagnosed and treatment started")]
        public String  ifYesWhenDiagnosed { get; set; }
        [Display(Name="Are you or family on medication")]
        public String areyouorfamily { get; set; }
        [Display(Name="If Yes,who and what medication")]
        public String ifYesWhoAndwhat { get; set; }
        [Display(Name="Where treated and what treatment")]
        public String whereTreatedandWhat { get; set; }
        /*--------------------------------------------------------------*/
        [Required]
        [Display(Name="Level of schooling")]
        public String  levelofschooling { get; set; }
        [Required]
        [Display(Name="schoolingdetails")]
        public String schoolingdetails { get; set; }
        [Required]
        [Display(Name="Tertiary Education")]
        public String tertiaryeducation { get; set; }
        [Required]
        [Display(Name="Tertiary Education level")]
        public String tertiaryeducationlevel { get; set; }
        [Required]
        public String originalcertificates { get; set; }
        [Required]
        [Display(Name="If yes, specift")]
        public String ifyesspecify { get; set; }
        [Required]
        public String last3jobsprior { get; set; }
        [Required]
        [Display(Name="List of skills of your family")]
        public String ListofSkillsOfyourfamily { get; set; }
        /**/


        public String levelofschoolingSpouse { get; set; }

        public String schoolingdetailsSpouse { get; set; }

        public String tertiaryeducationSpouse { get; set; }

        public String tertiaryeducationlevelSpouse { get; set; }

        public String originalcertificatesSpouse { get; set; }

        public String ifyesspecifySpouse { get; set; }

        public String last3jobspriorSpouse { get; set; }
    }
}