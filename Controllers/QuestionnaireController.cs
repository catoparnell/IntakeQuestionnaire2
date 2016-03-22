using IntakeQuestionnaire.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;

namespace IntakeQuestionnaire.Controllers
{ 
    public class QuestionnaireController : Controller
    {
       
        //
        // GET: /Questionnaire/
        public ActionResult Index()
        {
            return View();
   
        }
        [HttpGet]
        public ActionResult Questionnaire()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Questionnaire(Models.Questionnaire q)
        {
            if (ModelState.IsValid)
            {
                    System.Data.SqlClient.SqlConnection sqlConnection1 =
                    new System.Data.SqlClient.SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename" +
                    @"='C:\Users\sue\Documents\Visual Studio 2013\Projects\IntakeQuestionnaire\IntakeQuestionnaire\App_Data\Questionnaire.mdf';Integrated Security=True");

                    System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = "INSERT INTO [dbo].[QuestionnairePage1] ([ApplicationRefNumber] , [familyCode] ,  [DateFileOpened] ,  [No] , [Interpreter] ,  [Surname] ,  [FirstName] ,  [Initials] ,  [CommunityName] ,  [YorN] , [ContactNumber] ,  [ContactName],  [Address] , [Flag] ,  [WhosContactNum], [HowLongClientBeenAtAdressFor] ,   [DOB] , [Country] ,   [Gender] ,  [MaritalStatus] ,  [EthnicGroup] ,   [Religion] ,  [HomeLang] ,  [ArrivalDate] ,  [typeOfApplicatn] ,  [DHAref] , [firstInterview] ,  [refugeeSTAT] , [UNCTD] , [ArrivalDateDurban] , [dateGranted] ,  [whenStatusExpire] , [firstInterviewDate] , [secondInterviewDate] ,  [englishAbility],  [attendingEnglishClasses],[whereAndHow] , [sharingAccomodation], [fullNamesOfSharers])VALUES ('" + q.ApplicationRefNumber + "','" + q.familyCode + "','" + q.DateFileOpened + "','"+ q.No + "','"+ q.Interpreter + "','"+ q.Surname + "','"+ q.FirstName + "','"+ q.Initials + "','"+ q.CommunityName + "','"+ q.YorN + "','"+ q.ContactNumber + "','"+ q.ContactName + "','"+ q.Address + "','"+ q.Flag + "','"+ q.WhosContactNum + "','"+ q.HowLongClientBeenAtAdressFor + "','"+ q.DOB + "','"+ q.Country + "','"+ q.Gender + "','"+ q.MaritalStatus + "','"+ q.EthnicGroup + "','"+ q.Religion + "','"+ q.HomeLang  + "','"+ q.ArrivalDate + "','"+ q.typeOfApplicatn + "','"+ q.DHAref + "','"+ q.firstInterview + "','"+ q.refugeeSTAT + "','"+ q.UNCTD + "','"+ q.ArrivalDateDurban + "','"+ q.dateGranted + "','"+ q.whenStatusExpire + "','"+ q.firstInterviewDate + "','"+ q.secondInterviewDate + "','"+ q.englishAbility + "','"+ q.attendingEnglishClasses + "','"+ q.whereAndHow + "','"+ q.sharingAccomodation + "','"+ q.fullNamesOfSharers + "')";
                    cmd.Connection = sqlConnection1;
                    sqlConnection1.Open();
                    cmd.ExecuteNonQuery();
                    sqlConnection1.Close();
                    return RedirectToAction("QuestionnairePageTwo");
            }
                else
                {
                    ModelState.AddModelError("", "Something didnt go right with adding the information to our databases");
                } 
            return View(q);
      }
           
        
        [HttpGet]
        public ActionResult QuestionnairePageTwo()
        {

            return View();
        }
        [HttpPost]
        public ActionResult QuestionnairePageTwo(Models.QuestionnairePageTwo q)
        {

            if (ModelState.IsValid)
            {
              int count = 3;
                try
                {
                    
                    System.Data.SqlClient.SqlConnection sqlConnection1 =
                    new System.Data.SqlClient.SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename" +
                    @"='C:\Users\sue\Documents\Visual Studio 2013\Projects\IntakeQuestionnaire\IntakeQuestionnaire\App_Data\Questionnaire.mdf';Integrated Security=True");
                    
                    System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = "INSERT INTO [dbo].[QuestionnairePageTwo] ([Surname] ,[First Name] ,[Current_Address] ,  [DHA Ref No],  [Date of Birth] , [Gender] , [When did the client last see their spouse:] , [Where seem], [DependentID] )VALUES ('" + q.Surname + "','" + q.Firstname + "','" + q.address + "','" + q.refN + "','" + q.dateOfBirth + "','" + q.Gender + "','" + q.whenDidTheClientSee + "','" + q.whereSeen +"','" + count +"')";
                    cmd.Connection = sqlConnection1;
                    sqlConnection1.Open();
                    cmd.ExecuteNonQuery();
                    sqlConnection1.Close();
                }
                catch
                {
                    //
                }
                try
                {
                    String[] list = new String[8];
                    String[] list2 = new String[8];
                    String ig1 = Request.Form["inputGrid1"];
                    if (ig1 != "")
                    {
                        list = new String[] {
                        Request.Form["inputGrid1"],
                        Request.Form["inputGrid2"],
                        Request.Form["inputGrid3"],
                        Request.Form["inputGrid4"],
                        Request.Form["inputGrid5"],
                        Request.Form["inputGrid6"],
                        Request.Form["inputGrid7"],
                        Request.Form["inputGrid8"]};
                        insertDateList1(list);
 
                    }
                    String ig1a = Request.Form["inputGrid1a"];
                    if (ig1a != "")
                    {
                        list = new String[] {
                        Request.Form["inputGrid1a"],
                        Request.Form["inputGrid2a"],
                        Request.Form["inputGrid3a"],
                        Request.Form["inputGrid4a"],
                        Request.Form["inputGrid5a"],
                        Request.Form["inputGrid6a"],
                        Request.Form["inputGrid7a"],
                        Request.Form["inputGrid8a"]};
                        insertDateList1(list);
                    }
                    String ig1b = Request.Form["inputGrid1b"];
                    if (ig1b != "")
                    {
                         list = new String[] {
                        Request.Form["inputGrid1b"],
                        Request.Form["inputGrid2b"],
                        Request.Form["inputGrid3b"],
                        Request.Form["inputGrid4b"],
                        Request.Form["inputGrid5b"],
                        Request.Form["inputGrid6b"],
                        Request.Form["inputGrid7b"],
                        Request.Form["inputGrid8b"]};
                         insertDateList1(list);
                    }
                    String ig1c = Request.Form["inputGrid1c"];
                    if (ig1c != "")
                    {
                        list = new String[] {
                        Request.Form["inputGrid1c"],
                        Request.Form["inputGrid2c"],
                        Request.Form["inputGrid3c"],
                        Request.Form["inputGrid4c"],
                        Request.Form["inputGrid5c"],
                        Request.Form["inputGrid6c"],
                        Request.Form["inputGrid7c"],
                        Request.Form["inputGrid8c"]};
                        insertDateList1(list);
                    }

                    /*******SECOND TABLE*******/
                    String iga = Request.Form["inputGrida1"];
                    if (iga != "")
                    {
                        list2 = new String[] {
                        Request.Form["inputGrida1"],
                        Request.Form["inputGridb1"],
                        Request.Form["inputGridc1"],
                        Request.Form["inputGridd1"],
                        Request.Form["inputGride1"],
                        Request.Form["inputGridf1"],
                        Request.Form["inputGridg1"],
                        Request.Form["inputGridh1"]};
                        insertDateList2(list2);
                    }
                    String iga2 = Request.Form["inputGrida2"];
                    if (iga2 != "")
                    {
                        list2 = new String[] {
                        Request.Form["inputGrida2"],
                        Request.Form["inputGridb2"],
                        Request.Form["inputGridc2"],
                        Request.Form["inputGridd2"],
                        Request.Form["inputGride2"],
                        Request.Form["inputGridf2"],
                        Request.Form["inputGridg2"],
                        Request.Form["inputGridh2"]};
                        insertDateList2(list2);
                    }
                    String iga3 = Request.Form["inputGrida3"];
                    if (iga3 != "")
                    {
                        list2 = new String[] {
                        Request.Form["inputGrida3"],
                        Request.Form["inputGridb3"],
                        Request.Form["inputGridc3"],
                        Request.Form["inputGridd3"],
                        Request.Form["inputGride3"],
                        Request.Form["inputGridf3"],
                        Request.Form["inputGridg3"],
                        Request.Form["inputGridh3"]};
                        insertDateList2(list2);
                    }
                    String iga4 = Request.Form["inputGrida4"];
                    if (iga4 != "")
                    {
                        list2 = new String[] {
                        Request.Form["inputGrida4"],
                        Request.Form["inputGridb4"],
                        Request.Form["inputGridc4"],
                        Request.Form["inputGridd4"],
                        Request.Form["inputGride4"],
                        Request.Form["inputGridf4"],
                        Request.Form["inputGridg4"],
                        Request.Form["inputGridh4"]};
                        insertDateList2(list2);
                    }
                    return RedirectToAction("QuestionnairePageThree");

                }
                catch
                {
                    //
                }

                 
            }
            else
            {
                ModelState.AddModelError("", "Something didnt go right with adding the information to our databases");
            }
            return View(q);
        }


        [HttpGet]
        public ActionResult QuestionnairePageThree()
        {
            return View();
        }
        [HttpPost]
        public ActionResult QuestionnairePageThree(Models.QuestionnairePageThree q)
        {

                System.Data.SqlClient.SqlConnection sqlConnection1 =
                new System.Data.SqlClient.SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename" +
                @"='C:\Users\sue\Documents\Visual Studio 2013\Projects\IntakeQuestionnaire\IntakeQuestionnaire\App_Data\Questionnaire.mdf';Integrated Security=True");

                System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "INSERT INTO [dbo].[QuestionnairePageThreeInfo] ([otherRelatives], [SocialAssistance], [Medical] , [Education] , [vocationalTraining]  , [FuneralAssistance],[Other] ,[Other Problem] ,[singleParent]  ,[Youth]  , [VulnerableChild], [Abused],  [HIV] , [Neglected]  ,[Orphan],[vulnerableFamily] , [ill], [Cancer] , [HIV2] , [Diabetes],[TB] ,[MentalIllness],[Aged] ,[vulnerableWomner]  , [singleMale]  , [siblingHeaded] ,[Other2], [Other Category of Client] )VALUES ('" + q.otherRelatives + "','" + q.SocialAssistance + "','" + q.Medical + "','" + q.Education + "','" + q.vocationalTraining + "','" + q.FuneralAssistance + "','" + q.Other + "','" + q.other1 + "','" + q.singleParent + "','" + q.Youth + "','" + q.VulnerableChild + "','" + q.Abused + "','" + q.HIV + "','" + q.Neglected + "','" + q.Orphan + "','" + q.vulnerableFamily + "','" + q.ill + "','" + q.Cancer + "','" + q.HIV2 + "','" + q.Diabetes + "','" + q.TB + "','" + q.MentalIllness + "','" + q.Aged + "','" + q.vulnerableWomner + "','" + q.singleMale + "','" + q.siblingHeaded + "','" + q.Other2 + "','" + q.other_2 + "')";
                cmd.Connection = sqlConnection1;
                sqlConnection1.Open();
                cmd.ExecuteNonQuery();
                sqlConnection1.Close();

                try
                {
                    System.Data.SqlClient.SqlConnection sqlConnection2 =
                    new System.Data.SqlClient.SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename" +
                    @"='C:\Users\sue\Documents\Visual Studio 2013\Projects\IntakeQuestionnaire\IntakeQuestionnaire\App_Data\Questionnaire.mdf';Integrated Security=True");
                    System.Data.SqlClient.SqlCommand cmd2 = new System.Data.SqlClient.SqlCommand();
                    cmd2.CommandType = System.Data.CommandType.Text;
                    cmd2.CommandText = "INSERT INTO [dbo].[QuestionnairePageThreeMoreInfo] ([whoIsFormally] , [averageIncome]  ,  [ifTotallyUnemployed]  ,  [whoIsSelfEmployed]  ,  [averageMonthlyIncome]  ,   [RentalAmount]  ,   [lightsAndWater]  ,   [Food]  ,   [Transport]  ,  [SchoolFees]  ,  [OtherExpenditure]  ,   [YesorNo]  ,   [EducationAssistance]  ,  [EducationTextBox]  ,  [Social]  ,   [SocialTextBox]  ,   [vocationalAssistance]  , [vocationalTextBox]  , [microLoan]  ,  [microLoanTextBox]  ,  [Referral]  ,  [referralTextBox]  , [NoorYes]  ,  [organisationName]  ,  [whenLastAssisted]  , [whatIsBeingProvided]  )VALUES ('" + q.whoIsFormally + "','" + q.averageIncome + "','" + q.ifTotallyUnemployed + "','" + q.whoIsSelfEmployed + "','" + q.averageMonthlyIncome + "','" + q.RentalAmount + "','" + q.lightsAndWater + "','" + q.Food + "','" + q.Transport + "','" + q.SchoolFees + "','" + q.OtherExpenditure + "','" + q.YesorNo + "','" + q.EducationAssistance + "','" + q.EducationTextBox + "','" + q.Social + "','" + q.SocialTextBox + "','" + q.vocationalAssistance + "','" + q.vocationalTextBox + "','" + q.microLoan + "','" + q.microLoanTextBox + "','" + q.Referral + "','" + q.referralTextBox + "','" + q.NoorYes + "','" + q.organisationName + "','" + q.whenLastAssisted + "','" + q.whatIsBeingProvided + "')";
                    cmd2.Connection = sqlConnection2;
                    sqlConnection2.Open();
                    cmd2.ExecuteNonQuery();
                    sqlConnection2.Close();
                    return RedirectToAction("QuestionnairePageFour");
                }
                catch
                {

                }
            
            return View(q);
        }
        [HttpGet]
        public ActionResult QuestionnairePageFour()
        {

            return View();
        }
        [HttpPost]
        public ActionResult QuestionnairePagefour(Models.questionnairePageFour q)
        {
            if (ModelState.IsValid) {
                try
                {
                    System.Data.SqlClient.SqlConnection sqlConnection2 =
                    new System.Data.SqlClient.SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename" +
                    @"='C:\Users\sue\Documents\Visual Studio 2013\Projects\IntakeQuestionnaire\IntakeQuestionnaire\App_Data\Questionnaire.mdf';Integrated Security=True");
                    System.Data.SqlClient.SqlCommand cmd2 = new System.Data.SqlClient.SqlCommand();
                    cmd2.CommandType = System.Data.CommandType.Text;
                    cmd2.CommandText = "INSERT INTO [dbo].[QuestionnairPageFour] (  [FledFrom], [lastAddress], [transitRoute]  ,  [DateofLeaving]  ,  [TravelPaid],  [stayAtAnyCamps]  , [CampsName]  , [DatesAtCamps] ,[UNHCR]  , [LeftWithWhom]  ,  [AvailableContact] , [RelationshipToThem]    , [TracingRequired]  , [whereIcrc]  ,[Other] , [referredBy]  ,  [DateOfRequest] , [whatDoesTheClient] , [WorkersImpression])VALUES ('" + q.FledFrom + "','" + q.lastAddress + "','" + q.transitRoute + "','" + q.DateofLeaving + "','" + q.TravelPaid + "','" + q.stayAtAnyCamps + "','" + q.CampsName + "','" + q.DatesAtCamps + "','" + q.UNHCR + "','" + q.LeftWithWhom + "','" + q.AvailableContact + "','" + q.RelationshipToThem + "','" + q.TracingRequired + "','" + q.whereIcrc + "','" + q.Other + "','" + q.referredBy + "','" + q.DateOfRequest + "','" + q.whatDoesTheClient + "','" + q.WorkersImpression +"')";
                    cmd2.Connection = sqlConnection2;
                    sqlConnection2.Open();
                    cmd2.ExecuteNonQuery();
                    sqlConnection2.Close();
                    return RedirectToAction("QuestionnairePageFive");
                }
                catch
                {

                }
            }
            return View();
        }
        [HttpGet]
        public ActionResult QuestionnairePageFive()
        {
            return View();
        }
        [HttpPost]
        public ActionResult QuestionnairePageFive(Models.QuestionnairePageFive q)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    System.Data.SqlClient.SqlConnection sqlConnection2 =
                    new System.Data.SqlClient.SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename" +
                    @"='C:\Users\sue\Documents\Visual Studio 2013\Projects\IntakeQuestionnaire\IntakeQuestionnaire\App_Data\Questionnaire.mdf';Integrated Security=True");
                    System.Data.SqlClient.SqlCommand cmd2 = new System.Data.SqlClient.SqlCommand();
                    cmd2.CommandType = System.Data.CommandType.Text;
                    cmd2.CommandText = "INSERT INTO [dbo].[QuestionnairePageFive] ([CurrentMedical]  ,  [ifYesList]  ,   [areYouPregnant]  ,  [spousePregnant]  ,  [ifYesDetailsOfPreg]  ,  [doYouHaveChronic]  ,  [ifYesWhenDiagnosed]  ,  [areyouorfamily]  ,  [ifYesWhoAndwhat]  , [whereTreatedandWhat]  ,  [levelofschooling]   ,  [schoolingdetails]   ,  [tertiaryeducation]   ,  [tertiaryeducationlevel]   ,   [originalcertificates]   ,  [ifyesspecify]   ,  [last3jobsprior]   ,  [ListofSkillsOfyourfamily]   ,  [levelofschoolingSpouse]  ,  [schoolingdetailsSpouse]  ,   [tertiaryeducationSpouse]  ,  [tertiaryeducationlevelSpouse]  ,   [originalcertificatesSpouse]  ,  [ifyesspecifySpouse]  ,  [last3jobspriorSpouse]  )VALUES ('" + q.CurrentMedical + "','" + q.ifYesList + "','" + q.areYouPregnant + "','" + q.spousePregnant + "','" + q.ifYesDetailsOfPreg + "','" + q.doYouHaveChronic + "','" + q.ifYesWhenDiagnosed + "','" + q.areyouorfamily + "','" + q.ifYesWhoAndwhat + "','" + q.whereTreatedandWhat + "','" + q.levelofschooling + "','" + q.schoolingdetails + "','" + q.tertiaryeducation + "','" + q.tertiaryeducationlevel + "','" + q.originalcertificates + "','" + q.ifyesspecify + "','" + q.last3jobsprior + "','" + q.ListofSkillsOfyourfamily + "','" + q.levelofschoolingSpouse + "','" + q.schoolingdetailsSpouse + "','" + q.tertiaryeducationSpouse + "','" + q.tertiaryeducationlevelSpouse + "','" + q.originalcertificatesSpouse + "','" + q.ifyesspecifySpouse + "','" + q.last3jobspriorSpouse + "')";
                    cmd2.Connection = sqlConnection2;
                    sqlConnection2.Open();
                    cmd2.ExecuteNonQuery();
                    sqlConnection2.Close();
                    return RedirectToAction("QuestionnairePageSix");
                }
                catch
                {

                }
            }
            return View();
        }
        [HttpGet]
        public ActionResult QuestionnairePageSix()
        {
            return View();
        }
        [HttpPost]
        public ActionResult QuestionnairePageSix(Models.Questionnaire q)
        {
            String[] list = new String[8];
            String ig1 = Request.Form["inputGrid1"];
            if (ig1 != "")
            {
                list = new String[] {
                        Request.Form["inputGrid1"],
                        Request.Form["inputGrid2"],
                        Request.Form["inputGrid3"],
                        Request.Form["inputGrid4"],
                        Request.Form["inputGrid5"],
                        Request.Form["inputGrid6"]};
                insertDataPage6(list);

            }
            String ig1a = Request.Form["inputGrid1a"];
            if (ig1a != "")
            {
                list = new String[] {
                        Request.Form["inputGrid1a"],
                        Request.Form["inputGrid2a"],
                        Request.Form["inputGrid3a"],
                        Request.Form["inputGrid4a"],
                        Request.Form["inputGrid5a"],
                        Request.Form["inputGrid6a"]};
                insertDataPage6(list);
            }
            String ig1b = Request.Form["inputGrid1b"];
            if (ig1b != "")
            {
                list = new String[] {
                        Request.Form["inputGrid1b"],
                        Request.Form["inputGrid2b"],
                        Request.Form["inputGrid3b"],
                        Request.Form["inputGrid4b"],
                        Request.Form["inputGrid5b"],
                        Request.Form["inputGrid6b"]};
                insertDataPage6(list);
            }
            String ig1c = Request.Form["inputGrid1c"];
            if (ig1c != "")
            {
                list = new String[] {
                        Request.Form["inputGrid1c"],
                        Request.Form["inputGrid2c"],
                        Request.Form["inputGrid3c"],
                        Request.Form["inputGrid4c"],
                        Request.Form["inputGrid5c"],
                        Request.Form["inputGrid6c"]};
                insertDataPage6(list);
            }
            String ig1d = Request.Form["inputGrid1d"];
            if (ig1d != "")
            {
                list = new String[] {
                        Request.Form["inputGrid1d"],
                        Request.Form["inputGrid2d"],
                        Request.Form["inputGrid3d"],
                        Request.Form["inputGrid4d"],
                        Request.Form["inputGrid5d"],
                        Request.Form["inputGrid6d"]};
                insertDataPage6(list);
            }

            String ig1e = Request.Form["inputGrid1e"];
            if (ig1e != "")
            {
                list = new String[] {
                        Request.Form["inputGrid1e"],
                        Request.Form["inputGrid2e"],
                        Request.Form["inputGrid3e"],
                        Request.Form["inputGrid4e"],
                        Request.Form["inputGrid5e"],
                        Request.Form["inputGrid6e"]};
                insertDataPage6(list);
            }
            
            String[] newLineArray = new String[8];
            String newLine = Request.Form["links7"];
            if (newLine != "")
            {
                newLineArray = new String[] {
                        Request.Form["links7"],
                        Request.Form["keywords7"],
                        Request.Form["violationtype7"],
                        Request.Form["endD7"],
                        Request.Form["details7"],
                        Request.Form["amounts7"]};
                insertDataPage6(newLineArray);
            }
            String newLine2 = Request.Form["links8"];
            if (newLine2 != "")
            {
                newLineArray = new String[] {
                        Request.Form["links8"],
                        Request.Form["keywords8"],
                        Request.Form["violationtype8"],
                        Request.Form["endD8"],
                        Request.Form["details8"],
                        Request.Form["amounts8"]};
                insertDataPage6(newLineArray);
            }
            String newLine3 = Request.Form["links9"];
            if (newLine3 != "")
            {
                newLineArray = new String[] {
                        Request.Form["links9"],
                        Request.Form["keywords9"],
                        Request.Form["violationtype9"],
                        Request.Form["endD9"],
                        Request.Form["details9"],
                        Request.Form["amounts9"]};
                insertDataPage6(newLineArray);
            }
            return RedirectToAction("QuestionnaireFinish");    
        }
        [HttpGet]
        public ActionResult QuestionnaireFinish()
        {
            return View();
        }
        public void insertDataPage6(String[] f1)
        {

            System.Data.SqlClient.SqlConnection sqlConnection1 =
            new System.Data.SqlClient.SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename" +
            @"='C:\Users\sue\Documents\Visual Studio 2013\Projects\IntakeQuestionnaire\IntakeQuestionnaire\App_Data\Questionnaire.mdf';Integrated Security=True");

            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "INSERT INTO [dbo].[SummaryOfServicesRendered] ([Service] ,[Type] ,[Start Date] ,  [End Date],  [Details] , [Amount R] )VALUES ('" + f1[0] + "','" + f1[1] + "','" + f1[2] + "','" + f1[3] + "','" + f1[4] + "','" + f1[5] + "')";
            cmd.Connection = sqlConnection1;
            sqlConnection1.Open();
            cmd.ExecuteNonQuery();
            sqlConnection1.Close();
        }
        public  void insertDateList1(String [] f1)
        {

            System.Data.SqlClient.SqlConnection sqlConnection1 =
            new System.Data.SqlClient.SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename" +
            @"='C:\Users\sue\Documents\Visual Studio 2013\Projects\IntakeQuestionnaire\IntakeQuestionnaire\App_Data\Questionnaire.mdf';Integrated Security=True");

            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "INSERT INTO [dbo].[DetailsOfDependents] ([First Name] ,[Last Name] ,[Date of Birth] ,  [Gender],  [Relationship] , [DHA Ref No] , [Education Details] , [Whereabouts/address])VALUES ('" + f1[0] + "','" + f1[1] + "','" + f1[2] + "','" + f1[3] + "','" + f1[4] + "','" + f1[5] + "','" + f1[6] + "','" + f1[7] +  "')";
            cmd.Connection = sqlConnection1;
            sqlConnection1.Open();
            cmd.ExecuteNonQuery();
            sqlConnection1.Close();
        }
        public void insertDateList2(String[] f1)
        {

            System.Data.SqlClient.SqlConnection sqlConnection1 =
            new System.Data.SqlClient.SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename" +
            @"='C:\Users\sue\Documents\Visual Studio 2013\Projects\IntakeQuestionnaire\IntakeQuestionnaire\App_Data\Questionnaire.mdf';Integrated Security=True");

            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "INSERT INTO [dbo].[DetailsOfSpouse] ([First Name] ,[Last Name] ,[Date of Birth] ,  [Gender],  [Relationship] , [DHA Ref No] , [Education Details] , [Whereabouts/address])VALUES ('" + f1[0] + "','" + f1[1] + "','" + f1[2] + "','" + f1[3] + "','" + f1[4] + "','" + f1[5] + "','" + f1[6] + "','" + f1[7] + "')";
            cmd.Connection = sqlConnection1;
            sqlConnection1.Open();
            cmd.ExecuteNonQuery();
            sqlConnection1.Close();
        }
    }

}
