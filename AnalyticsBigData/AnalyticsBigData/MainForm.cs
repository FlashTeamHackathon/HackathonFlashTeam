using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using ZedGraph;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms;

namespace AnalyticsBigData
{
    public partial class MainForm : Form
    {
        
        public MainForm()
        {
            InitializeComponent();            
        }
/*---------------------------------------------------------------------------------*/
/*                     Function 1st                                                */
/*---------------------------------------------------------------------------------*/
        private void buttonSelect_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Data File(*.txt;*.xlx;*.sql)|*.txt;*.xlx;*.xlxs;*.sql|All File(*.*)|*.*";
            ofd.FilterIndex = 1;
            ofd.Title = "Please select data file to filter.";

            if (ofd.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            textBoxPathFile.Text = ofd.FileName;            
        }
        

        private void buttonFilter_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDlg = new SaveFileDialog();

            saveFileDlg.FileName = "DataFilter.txt";
            saveFileDlg.InitialDirectory = @"C:\";
            saveFileDlg.Filter = "Data File(*.txt;*.csv)|*.txt;*.csv|All File(*.*)|*.*";
            saveFileDlg.Title = "Please choice place where save data file.";

            if (saveFileDlg.ShowDialog() == DialogResult.OK)
            {               
                //Write offical file
                StreamWriter swrite = new StreamWriter(saveFileDlg.FileName, false, Encoding.UTF8);

                string dataFileName = saveFileDlg.FileName;

                FileStream fs = new FileStream(textBoxPathFile.Text, FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);

                StreamWriter sws = new StreamWriter("DataFilter.csv", false, Encoding.UTF8);

                if (checkBoxName.Checked)
                {
                    sws.Write("Name");
                    sws.Write(",");
                }
                if (checkBoxGender.Checked)
                {
                    sws.Write("Gender");
                    sws.Write(",");
                }
                if (checkBoxBirthday.Checked)
                {
                    sws.Write("Birthday");
                    sws.Write(",");
                }
                if (checkBoxEmail.Checked)
                {
                    sws.Write("Email");
                    sws.Write(",");
                }
                if (checkBoxTelephone.Checked)
                {
                    sws.Write("Telephone");
                    sws.Write(",");
                }
                if (checkBoxUniversity.Checked)
                {
                    sws.Write("University");
                    sws.Write(",");
                }
                if (checkBoxJob.Checked)
                {
                    sws.Write("Job");
                    sws.Write(",");
                }
                if (checkBoxMajor.Checked)
                {
                    sws.Write("Major");
                    sws.Write(",");
                }
                if (checkBoxPlace.Checked)
                {
                    sws.Write("Place");
                    sws.Write(",");
                }
                if (checkBoxEducation.Checked)
                {
                    sws.Write("Education");
                    sws.Write(",");
                }
                sws.WriteLine("\n");
                string lineInfo;
                while ((lineInfo = sr.ReadLine()) != null)
                {                    
                    string[] persionInfo = lineInfo.Split(',');
                    foreach (string temp in persionInfo)
                    {
                        if (temp.Contains("Name") && checkBoxName.Checked)
                        {
                            swrite.Write(temp);
                            swrite.Write(",");
                            string[] tempSpit = temp.Split(':');
                            sws.Write(tempSpit[1].Trim());
                            sws.Write(",");
                        }
                        if (temp.Contains("Gender") && checkBoxGender.Checked)
                        {
                            swrite.Write(temp);
                            swrite.Write(",");
                            string[] tempSpit = temp.Split(':');
                            sws.Write(tempSpit[1].Trim());
                            sws.Write(",");
                        }
                        if (temp.Contains("Birthday") && checkBoxBirthday.Checked)
                        {
                            swrite.Write(temp);
                            swrite.Write(",");
                            string[] tempSpit = temp.Split(':');
                            sws.Write(tempSpit[1].Trim());
                            sws.Write(",");
                        }
                        if (temp.Contains("Email") && checkBoxEmail.Checked)
                        {
                            swrite.Write(temp);
                            swrite.Write(",");
                            string[] tempSpit = temp.Split(':');
                            sws.Write(tempSpit[1].Trim());
                            sws.Write(",");
                        }
                        if (temp.Contains("Tel") && checkBoxTelephone.Checked)
                        {
                            swrite.Write(temp);
                            swrite.Write(",");
                            string[] tempSpit = temp.Split(':');
                            sws.Write(tempSpit[1].Trim());
                            sws.Write(",");
                        }
                        if (temp.Contains("University") && checkBoxUniversity.Checked)
                        {
                            swrite.Write(temp);
                            swrite.Write(",");
                            string[] tempSpit = temp.Split(':');
                            sws.Write(tempSpit[1].Trim());
                            sws.Write(",");
                        }
                        if (temp.Contains("Job") && checkBoxJob.Checked)
                        {
                            swrite.Write(temp);
                            swrite.Write(",");
                            string[] tempSpit = temp.Split(':');
                            sws.Write(tempSpit[1].Trim());
                            sws.Write(",");
                        }
                        if (temp.Contains("Major") && checkBoxMajor.Checked)
                        {
                            swrite.Write(temp);
                            swrite.Write(",");
                            string[] tempSpit = temp.Split(':');
                            sws.Write(tempSpit[1].Trim());
                            sws.Write(",");
                        }
                        
                        if (temp.Contains("Place") && checkBoxPlace.Checked)
                        {
                            swrite.Write(temp);
                            swrite.Write(",");
                            string[] tempSpit = temp.Split(':');
                            sws.Write(tempSpit[1].Trim());
                            sws.Write(",");
                        }
                        if (temp.Contains("Education") && checkBoxEducation.Checked)
                        {
                            swrite.Write(temp);
                            swrite.Write(",");
                            string[] tempSpit = temp.Split(':');
                            sws.Write(tempSpit[1].Trim());
                            sws.Write(",");
                        }

                    }
                    swrite.WriteLine("\n");
                    sws.WriteLine("");
                }

                swrite.Flush();
                swrite.Close();
                sws.Flush();
                sws.Close();
                fs.Close();
                               
            }                
            Process.Start("DataFilter.csv");
        }

       
       
/*--------------------------------------------------------------------------------------------------------*/
/*       Function 2nd                                                                                     */
/*--------------------------------------------------------------------------------------------------------*/
        private void buttonLoadData_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Data File(*.txt;*.xlx;*.sql)|*.txt;*.xlx;*.xlxs;*.sql|All File(*.*)|*.*";
            ofd.FilterIndex = 1;
            ofd.Title = "Please select data file to filter.";

            if (ofd.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            textBoxDataFile.Text = ofd.FileName;
        }

        /* Check Age Using */
        bool AgeChecked()
        {
            return ((numericUpDownFrom.Value == 0) && (numericUpDownTo.Value == 0)) ? false : true;
        }
        /* Check Gender Using */
        bool GenderChecked()
        {
            bool gender = false;
            if (checkedListBoxGender.CheckedItems.Count > 1)
            {
                gender = true;
            }
            else
            {
                if (checkedListBoxGender.CheckedItems.Count == 1)
                {
                    foreach (object selectItems in checkedListBoxGender.CheckedItems)
                    {
                        if (checkedListBoxGender.Items.IndexOf(selectItems) == 0)
                            gender = false;
                        else
                            gender = true;
                    }
                }
            }

            return gender;
        }
        /* Check Place Using */
        bool PlaceChecked()
        {
            bool place = false;
            if (checkedListBoxPlace.CheckedItems.Count > 1)
            {
                place = true;
            }
            else
            {
                if (checkedListBoxPlace.CheckedItems.Count == 1)
                {
                    foreach (object selectItems in checkedListBoxPlace.CheckedItems)
                    {
                        if (checkedListBoxPlace.Items.IndexOf(selectItems) == 0)
                            place = false;
                        else
                            place = true;
                    }
                }
            }

            return place;
        }
        /* Check Job Using */
        bool JobChecked()
        {
            bool job = false;
            if (checkedListBoxJob.CheckedItems.Count > 1)
            {
                job = true;
            }
            else
            {
                if (checkedListBoxJob.CheckedItems.Count == 1)
                {
                    foreach (object selectItems in checkedListBoxJob.CheckedItems)
                    {
                        if (checkedListBoxJob.Items.IndexOf(selectItems) == 0)
                            job = false;
                        else
                            job = true;
                    }
                }
            }

            return job;
        }
        /* Check Education Using */
        bool EducationChecked()
        {
            bool education = false;
            if (checkedListBoxEducation.CheckedItems.Count > 1)
            {
                education = true;
            }
            else
            {
                if (checkedListBoxEducation.CheckedItems.Count == 1)
                {
                    foreach (object selectItems in checkedListBoxEducation.CheckedItems)
                    {
                        if (checkedListBoxEducation.Items.IndexOf(selectItems) == 0)
                            education = false;
                        else
                            education = true;
                    }
                }
            }
            return education;
        }
        private void buttonAnalytics_Click(object sender, EventArgs e)
        {           
            /* Analytics Data from fields which you choised */
            DataAnalytics(AgeChecked(), GenderChecked(), PlaceChecked(), JobChecked(), EducationChecked());
        }

        public void DataAnalytics(bool age, bool gender, bool place, bool job, bool education)
        {
            SaveFileDialog saveFileDlg = new SaveFileDialog();

            saveFileDlg.FileName = "DataFilter_Condition.txt";
            saveFileDlg.InitialDirectory = @"C:\";
            saveFileDlg.Filter = "Data File(*.txt;*.csv)|*.txt;*.csv|All File(*.*)|*.*";
            saveFileDlg.Title = "Please choice place where save data file.";

            if (saveFileDlg.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(saveFileDlg.FileName, false, Encoding.UTF8);

                FileStream fs = new FileStream(textBoxDataFile.Text, FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                StreamReader srcsv = new StreamReader(fs);
                StreamWriter sws = new StreamWriter("DataFilter_Condition.csv", false, Encoding.UTF8);
                /*-------------------------------------------*/
                /*      Ghi tieu de file CSV                 */
                string tieudeCSV = srcsv.ReadLine();
                string[] tieudeCSVSpit = tieudeCSV.Split(',');
                foreach (string tempCSV in tieudeCSVSpit)
                {
                    string[] tempCSVSpit = tempCSV.Split(':');
                    sws.Write(tempCSVSpit[0]);
                    sws.Write(",");
                }
                sws.WriteLine("\n");
                /*-------------------------------------------*/
                string lineInfo;
                while ((lineInfo = sr.ReadLine()) != null)
                {
                    string[] personInfo = lineInfo.Split(',');
                    bool testBirday = false;
                    bool testGender = false;
                    bool testPlace = false;
                    bool testJob = false;
                    bool testEducation = false;
                    foreach (string temp in personInfo)
                    {
                        //Set defaut
                        if (AgeChecked() == false)
                            testBirday = true;
                        if (GenderChecked() == false)
                            testGender = true;
                        if (PlaceChecked() == false)
                            testPlace = true;
                        if (JobChecked() == false)
                            testJob = true;
                        if (EducationChecked() == false)
                            testEducation = true;
                        //Process Age
                        if (temp.Contains("Birthday") && AgeChecked())
                        {
                            temp.Trim();
                            string YearOfBirth = temp.Substring(temp.Length - 5);
                            int age_main = DateTime.Now.Year - Int32.Parse(YearOfBirth);
                            if (age_main < numericUpDownFrom.Value && age_main > numericUpDownTo.Value)
                            {
                                break;
                            }
                            else
                            {
                                testBirday = true;
                            }
                        }
                        
                        //Process Gender
                        if (temp.Contains("Gender") && GenderChecked())
                        {
                            temp.Trim();
                            string tempGenderSub = temp.Substring(7);
                            bool isHasGender = false;
                            foreach (string genderTemp in checkedListBoxGender.CheckedItems)
                            {
                                if (genderTemp == tempGenderSub)
                                    isHasGender = true;
                            }
                            if (isHasGender)
                                testGender = true;
                            else
                                break;
                        }
                        
                        //Process Place
                        if (temp.Contains("Place") && PlaceChecked())
                        {
                            temp.Trim();
                            string tempPlaceSub = temp.Substring(6);
                            bool isHasPlace = false;
                            foreach (string placeTemp in checkedListBoxPlace.CheckedItems)
                            {
                                if (placeTemp == tempPlaceSub)
                                    isHasPlace = true;
                            }
                            if (isHasPlace)
                                testPlace = true;
                            else
                                break;
                        }
                        else
                        {
                            if (temp.Contains("Place") && (PlaceChecked() != false)) testPlace = true;
                        }
                        //Process Job
                        if (temp.Contains("Job") && JobChecked())
                        {
                            temp.Trim();
                            string tempJobSub = temp.Substring(4);
                            bool isHasJob = false;
                            foreach (string jobTemp in checkedListBoxJob.CheckedItems)
                            {
                                if (jobTemp == tempJobSub)
                                    isHasJob = true;
                            }
                            if (isHasJob)
                                testJob = true;
                            else
                                break;
                        }
                        
                        //Process Education
                        if (temp.Contains("Education") && EducationChecked())
                        {
                            temp.Trim();
                            string tempEduSub = temp.Substring(10);
                            bool isHasEdu = false;
                            foreach (string eduTemp in checkedListBoxEducation.CheckedItems)
                            {
                                if (eduTemp == tempEduSub)
                                    isHasEdu = true;
                            }
                            if (isHasEdu)
                                testEducation = true;
                            else
                                break;
                        }
                        
                    }
                    if (testBirday && testGender && testPlace && testJob && testEducation)
                    {
                        sw.WriteLine(lineInfo);
                        //Write to CSV File
                        string lineInfoForCSV = "";
                        string[] personInfoCSVFile = lineInfo.Split(',');
                        foreach (string temp in personInfoCSVFile)
                        {
                            if (temp != "")
                            {
                                string[] tempSpit = temp.Split(':');
                                lineInfoForCSV = lineInfoForCSV + tempSpit[1] + ",";                                
                            }
                        }
                        sws.WriteLine(lineInfoForCSV);
                    }
                }

                sw.Flush();
                sw.Close();
                sr.Close();
                fs.Close();
                sws.Flush();
                sws.Close();
            }

            Process.Start("DataFilter_Condition.csv");
        }
        /*------------------------------------------------------*/
        /*           Function 3rd                               */
        /*------------------------------------------------------*/

    }
}

