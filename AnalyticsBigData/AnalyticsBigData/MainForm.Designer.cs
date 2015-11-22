namespace AnalyticsBigData
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBoxDataFilter = new System.Windows.Forms.GroupBox();
            this.buttonFilter = new System.Windows.Forms.Button();
            this.checkBoxEducation = new System.Windows.Forms.CheckBox();
            this.checkBoxPlace = new System.Windows.Forms.CheckBox();
            this.checkBoxMajor = new System.Windows.Forms.CheckBox();
            this.checkBoxJob = new System.Windows.Forms.CheckBox();
            this.checkBoxUniversity = new System.Windows.Forms.CheckBox();
            this.checkBoxTelephone = new System.Windows.Forms.CheckBox();
            this.checkBoxEmail = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxGender = new System.Windows.Forms.CheckBox();
            this.checkBoxBirthday = new System.Windows.Forms.CheckBox();
            this.checkBoxName = new System.Windows.Forms.CheckBox();
            this.labelSelectField = new System.Windows.Forms.Label();
            this.buttonSelect = new System.Windows.Forms.Button();
            this.textBoxPathFile = new System.Windows.Forms.TextBox();
            this.groupBoxDataAnalytics = new System.Windows.Forms.GroupBox();
            this.buttonAnalytics = new System.Windows.Forms.Button();
            this.checkedListBoxEducation = new System.Windows.Forms.CheckedListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.checkedListBoxJob = new System.Windows.Forms.CheckedListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.checkedListBoxGender = new System.Windows.Forms.CheckedListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.checkedListBoxPlace = new System.Windows.Forms.CheckedListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDownTo = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDownFrom = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonLoadData = new System.Windows.Forms.Button();
            this.textBoxDataFile = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBoxChartAnalytics = new System.Windows.Forms.GroupBox();
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.buttonRun = new System.Windows.Forms.Button();
            this.checkBoxPlaceChart = new System.Windows.Forms.CheckBox();
            this.checkBoxAgeChart = new System.Windows.Forms.CheckBox();
            this.checkBoxEduChart = new System.Windows.Forms.CheckBox();
            this.checkBoxMajorChart = new System.Windows.Forms.CheckBox();
            this.groupBoxDataFilter.SuspendLayout();
            this.groupBoxDataAnalytics.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFrom)).BeginInit();
            this.groupBoxChartAnalytics.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxDataFilter
            // 
            this.groupBoxDataFilter.Controls.Add(this.buttonFilter);
            this.groupBoxDataFilter.Controls.Add(this.checkBoxEducation);
            this.groupBoxDataFilter.Controls.Add(this.checkBoxPlace);
            this.groupBoxDataFilter.Controls.Add(this.checkBoxMajor);
            this.groupBoxDataFilter.Controls.Add(this.checkBoxJob);
            this.groupBoxDataFilter.Controls.Add(this.checkBoxUniversity);
            this.groupBoxDataFilter.Controls.Add(this.checkBoxTelephone);
            this.groupBoxDataFilter.Controls.Add(this.checkBoxEmail);
            this.groupBoxDataFilter.Controls.Add(this.label1);
            this.groupBoxDataFilter.Controls.Add(this.checkBoxGender);
            this.groupBoxDataFilter.Controls.Add(this.checkBoxBirthday);
            this.groupBoxDataFilter.Controls.Add(this.checkBoxName);
            this.groupBoxDataFilter.Controls.Add(this.labelSelectField);
            this.groupBoxDataFilter.Controls.Add(this.buttonSelect);
            this.groupBoxDataFilter.Controls.Add(this.textBoxPathFile);
            this.groupBoxDataFilter.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxDataFilter.Location = new System.Drawing.Point(18, 19);
            this.groupBoxDataFilter.Name = "groupBoxDataFilter";
            this.groupBoxDataFilter.Size = new System.Drawing.Size(586, 222);
            this.groupBoxDataFilter.TabIndex = 0;
            this.groupBoxDataFilter.TabStop = false;
            this.groupBoxDataFilter.Text = "Raw Data Filter";
            // 
            // buttonFilter
            // 
            this.buttonFilter.Location = new System.Drawing.Point(487, 170);
            this.buttonFilter.Name = "buttonFilter";
            this.buttonFilter.Size = new System.Drawing.Size(76, 33);
            this.buttonFilter.TabIndex = 14;
            this.buttonFilter.Text = "Filter";
            this.buttonFilter.UseVisualStyleBackColor = true;
            this.buttonFilter.Click += new System.EventHandler(this.buttonFilter_Click);
            // 
            // checkBoxEducation
            // 
            this.checkBoxEducation.AutoSize = true;
            this.checkBoxEducation.Location = new System.Drawing.Point(442, 131);
            this.checkBoxEducation.Name = "checkBoxEducation";
            this.checkBoxEducation.Size = new System.Drawing.Size(90, 20);
            this.checkBoxEducation.TabIndex = 13;
            this.checkBoxEducation.Text = "Education";
            this.checkBoxEducation.UseVisualStyleBackColor = true;
            // 
            // checkBoxPlace
            // 
            this.checkBoxPlace.AutoSize = true;
            this.checkBoxPlace.Location = new System.Drawing.Point(348, 131);
            this.checkBoxPlace.Name = "checkBoxPlace";
            this.checkBoxPlace.Size = new System.Drawing.Size(63, 20);
            this.checkBoxPlace.TabIndex = 12;
            this.checkBoxPlace.Text = "Place";
            this.checkBoxPlace.UseVisualStyleBackColor = true;
            // 
            // checkBoxMajor
            // 
            this.checkBoxMajor.AutoSize = true;
            this.checkBoxMajor.Location = new System.Drawing.Point(242, 131);
            this.checkBoxMajor.Name = "checkBoxMajor";
            this.checkBoxMajor.Size = new System.Drawing.Size(63, 20);
            this.checkBoxMajor.TabIndex = 11;
            this.checkBoxMajor.Text = "Major";
            this.checkBoxMajor.UseVisualStyleBackColor = true;
            // 
            // checkBoxJob
            // 
            this.checkBoxJob.AutoSize = true;
            this.checkBoxJob.Location = new System.Drawing.Point(143, 131);
            this.checkBoxJob.Name = "checkBoxJob";
            this.checkBoxJob.Size = new System.Drawing.Size(50, 20);
            this.checkBoxJob.TabIndex = 10;
            this.checkBoxJob.Text = "Job";
            this.checkBoxJob.UseVisualStyleBackColor = true;
            // 
            // checkBoxUniversity
            // 
            this.checkBoxUniversity.AutoSize = true;
            this.checkBoxUniversity.Location = new System.Drawing.Point(22, 131);
            this.checkBoxUniversity.Name = "checkBoxUniversity";
            this.checkBoxUniversity.Size = new System.Drawing.Size(89, 20);
            this.checkBoxUniversity.TabIndex = 9;
            this.checkBoxUniversity.Text = "University";
            this.checkBoxUniversity.UseVisualStyleBackColor = true;
            // 
            // checkBoxTelephone
            // 
            this.checkBoxTelephone.AutoSize = true;
            this.checkBoxTelephone.Location = new System.Drawing.Point(442, 96);
            this.checkBoxTelephone.Name = "checkBoxTelephone";
            this.checkBoxTelephone.Size = new System.Drawing.Size(94, 20);
            this.checkBoxTelephone.TabIndex = 8;
            this.checkBoxTelephone.Text = "Telephone";
            this.checkBoxTelephone.UseVisualStyleBackColor = true;
            // 
            // checkBoxEmail
            // 
            this.checkBoxEmail.AutoSize = true;
            this.checkBoxEmail.Location = new System.Drawing.Point(348, 96);
            this.checkBoxEmail.Name = "checkBoxEmail";
            this.checkBoxEmail.Size = new System.Drawing.Size(63, 20);
            this.checkBoxEmail.TabIndex = 7;
            this.checkBoxEmail.Text = "Email";
            this.checkBoxEmail.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "File Path";
            // 
            // checkBoxGender
            // 
            this.checkBoxGender.AutoSize = true;
            this.checkBoxGender.Location = new System.Drawing.Point(143, 96);
            this.checkBoxGender.Name = "checkBoxGender";
            this.checkBoxGender.Size = new System.Drawing.Size(74, 20);
            this.checkBoxGender.TabIndex = 5;
            this.checkBoxGender.Text = "Gender";
            this.checkBoxGender.UseVisualStyleBackColor = true;
            // 
            // checkBoxBirthday
            // 
            this.checkBoxBirthday.AutoSize = true;
            this.checkBoxBirthday.Location = new System.Drawing.Point(242, 96);
            this.checkBoxBirthday.Name = "checkBoxBirthday";
            this.checkBoxBirthday.Size = new System.Drawing.Size(80, 20);
            this.checkBoxBirthday.TabIndex = 4;
            this.checkBoxBirthday.Text = "Birthday";
            this.checkBoxBirthday.UseVisualStyleBackColor = true;
            // 
            // checkBoxName
            // 
            this.checkBoxName.AutoSize = true;
            this.checkBoxName.Location = new System.Drawing.Point(22, 96);
            this.checkBoxName.Name = "checkBoxName";
            this.checkBoxName.Size = new System.Drawing.Size(92, 20);
            this.checkBoxName.TabIndex = 3;
            this.checkBoxName.Text = "Full Name";
            this.checkBoxName.UseVisualStyleBackColor = true;
            // 
            // labelSelectField
            // 
            this.labelSelectField.AutoSize = true;
            this.labelSelectField.Location = new System.Drawing.Point(19, 67);
            this.labelSelectField.Name = "labelSelectField";
            this.labelSelectField.Size = new System.Drawing.Size(140, 16);
            this.labelSelectField.TabIndex = 2;
            this.labelSelectField.Text = "Select Field To Filter";
            // 
            // buttonSelect
            // 
            this.buttonSelect.Location = new System.Drawing.Point(442, 23);
            this.buttonSelect.Name = "buttonSelect";
            this.buttonSelect.Size = new System.Drawing.Size(121, 31);
            this.buttonSelect.TabIndex = 1;
            this.buttonSelect.Text = "Select Data File";
            this.buttonSelect.UseVisualStyleBackColor = true;
            this.buttonSelect.Click += new System.EventHandler(this.buttonSelect_Click);
            // 
            // textBoxPathFile
            // 
            this.textBoxPathFile.Location = new System.Drawing.Point(90, 27);
            this.textBoxPathFile.Name = "textBoxPathFile";
            this.textBoxPathFile.Size = new System.Drawing.Size(321, 22);
            this.textBoxPathFile.TabIndex = 0;
            // 
            // groupBoxDataAnalytics
            // 
            this.groupBoxDataAnalytics.Controls.Add(this.buttonAnalytics);
            this.groupBoxDataAnalytics.Controls.Add(this.checkedListBoxEducation);
            this.groupBoxDataAnalytics.Controls.Add(this.label9);
            this.groupBoxDataAnalytics.Controls.Add(this.checkedListBoxJob);
            this.groupBoxDataAnalytics.Controls.Add(this.label8);
            this.groupBoxDataAnalytics.Controls.Add(this.checkedListBoxGender);
            this.groupBoxDataAnalytics.Controls.Add(this.label7);
            this.groupBoxDataAnalytics.Controls.Add(this.checkedListBoxPlace);
            this.groupBoxDataAnalytics.Controls.Add(this.label6);
            this.groupBoxDataAnalytics.Controls.Add(this.numericUpDownTo);
            this.groupBoxDataAnalytics.Controls.Add(this.label5);
            this.groupBoxDataAnalytics.Controls.Add(this.numericUpDownFrom);
            this.groupBoxDataAnalytics.Controls.Add(this.label4);
            this.groupBoxDataAnalytics.Controls.Add(this.label3);
            this.groupBoxDataAnalytics.Controls.Add(this.buttonLoadData);
            this.groupBoxDataAnalytics.Controls.Add(this.textBoxDataFile);
            this.groupBoxDataAnalytics.Controls.Add(this.label2);
            this.groupBoxDataAnalytics.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxDataAnalytics.Location = new System.Drawing.Point(18, 261);
            this.groupBoxDataAnalytics.Name = "groupBoxDataAnalytics";
            this.groupBoxDataAnalytics.Size = new System.Drawing.Size(586, 197);
            this.groupBoxDataAnalytics.TabIndex = 1;
            this.groupBoxDataAnalytics.TabStop = false;
            this.groupBoxDataAnalytics.Text = "Data Analytics";
            // 
            // buttonAnalytics
            // 
            this.buttonAnalytics.Location = new System.Drawing.Point(491, 151);
            this.buttonAnalytics.Name = "buttonAnalytics";
            this.buttonAnalytics.Size = new System.Drawing.Size(76, 32);
            this.buttonAnalytics.TabIndex = 17;
            this.buttonAnalytics.Text = "Analytics";
            this.buttonAnalytics.UseVisualStyleBackColor = true;
            this.buttonAnalytics.Click += new System.EventHandler(this.buttonAnalytics_Click);
            // 
            // checkedListBoxEducation
            // 
            this.checkedListBoxEducation.FormattingEnabled = true;
            this.checkedListBoxEducation.Items.AddRange(new object[] {
            "All level",
            "highschool",
            "university",
            "after university"});
            this.checkedListBoxEducation.Location = new System.Drawing.Point(418, 109);
            this.checkedListBoxEducation.Name = "checkedListBoxEducation";
            this.checkedListBoxEducation.Size = new System.Drawing.Size(114, 21);
            this.checkedListBoxEducation.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(325, 114);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 16);
            this.label9.TabIndex = 15;
            this.label9.Text = "Education";
            // 
            // checkedListBoxJob
            // 
            this.checkedListBoxJob.FormattingEnabled = true;
            this.checkedListBoxJob.Items.AddRange(new object[] {
            "All Job",
            "software engineer",
            "Technical Support",
            "Technical Support",
            "Web Masters",
            "android developer",
            "iOS developer",
            "mobile developer",
            "Net developer",
            "Network Support"});
            this.checkedListBoxJob.Location = new System.Drawing.Point(79, 146);
            this.checkedListBoxJob.Name = "checkedListBoxJob";
            this.checkedListBoxJob.Size = new System.Drawing.Size(175, 21);
            this.checkedListBoxJob.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 151);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 16);
            this.label8.TabIndex = 13;
            this.label8.Text = "Job";
            // 
            // checkedListBoxGender
            // 
            this.checkedListBoxGender.AllowDrop = true;
            this.checkedListBoxGender.FormattingEnabled = true;
            this.checkedListBoxGender.Items.AddRange(new object[] {
            "All Gender",
            "Male",
            "Female"});
            this.checkedListBoxGender.Location = new System.Drawing.Point(418, 74);
            this.checkedListBoxGender.Name = "checkedListBoxGender";
            this.checkedListBoxGender.ScrollAlwaysVisible = true;
            this.checkedListBoxGender.Size = new System.Drawing.Size(114, 21);
            this.checkedListBoxGender.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(325, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "Gender";
            // 
            // checkedListBoxPlace
            // 
            this.checkedListBoxPlace.FormattingEnabled = true;
            this.checkedListBoxPlace.Items.AddRange(new object[] {
            "All Place",
            "An Giang",
            "Bà Rịa - Vũng Tàu",
            "Bắc Giang",
            "Bắc Kạn",
            "Bạc Liêu",
            "Bắc Ninh",
            "Bến Tre",
            "Bình Định",
            "Bình Dương",
            "Bình Phước",
            "Bình Thuận",
            "Cà Mau",
            "Cao Bằng",
            "Đắk Lắk",
            "Đắk Nông",
            "Điện Biên",
            "Đồng Nai",
            "Đồng Tháp",
            "Gia Lai",
            "Hà Giang",
            "Hà Nam",
            "Hà Tĩnh",
            "Hải Dương",
            "Hậu Giang",
            "Hòa Bình",
            "Hưng Yên",
            "Khánh Hòa",
            "Kiên Giang",
            "Kon Tum",
            "Lai Châu",
            "Lâm Đồng",
            "Lạng Sơn",
            "Lào Cai",
            "Long An",
            "Nam Định",
            "Nghệ An",
            "Ninh Bình",
            "Ninh Thuận",
            "Phú Thọ",
            "Quảng Bình",
            "Quảng Nam",
            "Quảng Ngãi",
            "Quảng Ninh",
            "Quảng Trị",
            "Sóc Trăng",
            "Sơn La",
            "Tây Ninh",
            "Thái Bình",
            "Thái Nguyên",
            "Thanh Hóa",
            "Thừa Thiên Huế",
            "Tiền Giang",
            "Trà Vinh",
            "Tuyên Quang",
            "Vĩnh Long",
            "Vĩnh Phúc",
            "Yên Bái",
            "Phú Yên",
            "Cần Thơ",
            "Đà Nẵng",
            "Hải Phòng",
            "Hà Nội",
            "TP HCM"});
            this.checkedListBoxPlace.Location = new System.Drawing.Point(79, 109);
            this.checkedListBoxPlace.Name = "checkedListBoxPlace";
            this.checkedListBoxPlace.Size = new System.Drawing.Size(175, 21);
            this.checkedListBoxPlace.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Place";
            // 
            // numericUpDownTo
            // 
            this.numericUpDownTo.Location = new System.Drawing.Point(211, 73);
            this.numericUpDownTo.Name = "numericUpDownTo";
            this.numericUpDownTo.Size = new System.Drawing.Size(43, 22);
            this.numericUpDownTo.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(182, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "To";
            // 
            // numericUpDownFrom
            // 
            this.numericUpDownFrom.Location = new System.Drawing.Point(117, 73);
            this.numericUpDownFrom.Name = "numericUpDownFrom";
            this.numericUpDownFrom.Size = new System.Drawing.Size(42, 22);
            this.numericUpDownFrom.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(76, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "From";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Age:";
            // 
            // buttonLoadData
            // 
            this.buttonLoadData.Location = new System.Drawing.Point(442, 25);
            this.buttonLoadData.Name = "buttonLoadData";
            this.buttonLoadData.Size = new System.Drawing.Size(121, 32);
            this.buttonLoadData.TabIndex = 2;
            this.buttonLoadData.Text = "Load Data File";
            this.buttonLoadData.UseVisualStyleBackColor = true;
            this.buttonLoadData.Click += new System.EventHandler(this.buttonLoadData_Click);
            // 
            // textBoxDataFile
            // 
            this.textBoxDataFile.Location = new System.Drawing.Point(90, 30);
            this.textBoxDataFile.Name = "textBoxDataFile";
            this.textBoxDataFile.Size = new System.Drawing.Size(321, 22);
            this.textBoxDataFile.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "File Path";
            // 
            // groupBoxChartAnalytics
            // 
            this.groupBoxChartAnalytics.Controls.Add(this.zedGraphControl1);
            this.groupBoxChartAnalytics.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxChartAnalytics.Location = new System.Drawing.Point(623, 19);
            this.groupBoxChartAnalytics.Name = "groupBoxChartAnalytics";
            this.groupBoxChartAnalytics.Size = new System.Drawing.Size(441, 439);
            this.groupBoxChartAnalytics.TabIndex = 2;
            this.groupBoxChartAnalytics.TabStop = false;
            this.groupBoxChartAnalytics.Text = "Chart Analytics";
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.Location = new System.Drawing.Point(7, 23);
            this.zedGraphControl1.Margin = new System.Windows.Forms.Padding(4);
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.ScrollGrace = 0D;
            this.zedGraphControl1.ScrollMaxX = 0D;
            this.zedGraphControl1.ScrollMaxY = 0D;
            this.zedGraphControl1.ScrollMaxY2 = 0D;
            this.zedGraphControl1.ScrollMinX = 0D;
            this.zedGraphControl1.ScrollMinY = 0D;
            this.zedGraphControl1.ScrollMinY2 = 0D;
            this.zedGraphControl1.Size = new System.Drawing.Size(427, 409);
            this.zedGraphControl1.TabIndex = 0;
            // 
            // buttonRun
            // 
            this.buttonRun.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRun.Location = new System.Drawing.Point(1091, 417);
            this.buttonRun.Name = "buttonRun";
            this.buttonRun.Size = new System.Drawing.Size(63, 34);
            this.buttonRun.TabIndex = 3;
            this.buttonRun.Text = "Run";
            this.buttonRun.UseVisualStyleBackColor = true;
            // 
            // checkBoxPlaceChart
            // 
            this.checkBoxPlaceChart.AutoSize = true;
            this.checkBoxPlaceChart.Location = new System.Drawing.Point(1074, 51);
            this.checkBoxPlaceChart.Name = "checkBoxPlaceChart";
            this.checkBoxPlaceChart.Size = new System.Drawing.Size(53, 17);
            this.checkBoxPlaceChart.TabIndex = 4;
            this.checkBoxPlaceChart.Text = "Place";
            this.checkBoxPlaceChart.UseVisualStyleBackColor = true;
            // 
            // checkBoxAgeChart
            // 
            this.checkBoxAgeChart.AutoSize = true;
            this.checkBoxAgeChart.Location = new System.Drawing.Point(1074, 87);
            this.checkBoxAgeChart.Name = "checkBoxAgeChart";
            this.checkBoxAgeChart.Size = new System.Drawing.Size(45, 17);
            this.checkBoxAgeChart.TabIndex = 5;
            this.checkBoxAgeChart.Text = "Age";
            this.checkBoxAgeChart.UseVisualStyleBackColor = true;
            // 
            // checkBoxEduChart
            // 
            this.checkBoxEduChart.AutoSize = true;
            this.checkBoxEduChart.Location = new System.Drawing.Point(1074, 118);
            this.checkBoxEduChart.Name = "checkBoxEduChart";
            this.checkBoxEduChart.Size = new System.Drawing.Size(74, 17);
            this.checkBoxEduChart.TabIndex = 6;
            this.checkBoxEduChart.Text = "Education";
            this.checkBoxEduChart.UseVisualStyleBackColor = true;
            // 
            // checkBoxMajorChart
            // 
            this.checkBoxMajorChart.AutoSize = true;
            this.checkBoxMajorChart.Location = new System.Drawing.Point(1074, 153);
            this.checkBoxMajorChart.Name = "checkBoxMajorChart";
            this.checkBoxMajorChart.Size = new System.Drawing.Size(52, 17);
            this.checkBoxMajorChart.TabIndex = 7;
            this.checkBoxMajorChart.Text = "Major";
            this.checkBoxMajorChart.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 470);
            this.Controls.Add(this.checkBoxMajorChart);
            this.Controls.Add(this.checkBoxEduChart);
            this.Controls.Add(this.checkBoxAgeChart);
            this.Controls.Add(this.checkBoxPlaceChart);
            this.Controls.Add(this.buttonRun);
            this.Controls.Add(this.groupBoxChartAnalytics);
            this.Controls.Add(this.groupBoxDataAnalytics);
            this.Controls.Add(this.groupBoxDataFilter);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ANALYTICS BIG DATA APLLICATION";
            this.groupBoxDataFilter.ResumeLayout(false);
            this.groupBoxDataFilter.PerformLayout();
            this.groupBoxDataAnalytics.ResumeLayout(false);
            this.groupBoxDataAnalytics.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFrom)).EndInit();
            this.groupBoxChartAnalytics.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxDataFilter;
        private System.Windows.Forms.Button buttonSelect;
        private System.Windows.Forms.TextBox textBoxPathFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxGender;
        private System.Windows.Forms.CheckBox checkBoxBirthday;
        private System.Windows.Forms.CheckBox checkBoxName;
        private System.Windows.Forms.Label labelSelectField;
        private System.Windows.Forms.Button buttonFilter;
        private System.Windows.Forms.CheckBox checkBoxEducation;
        private System.Windows.Forms.CheckBox checkBoxPlace;
        private System.Windows.Forms.CheckBox checkBoxMajor;
        private System.Windows.Forms.CheckBox checkBoxJob;
        private System.Windows.Forms.CheckBox checkBoxUniversity;
        private System.Windows.Forms.CheckBox checkBoxTelephone;
        private System.Windows.Forms.CheckBox checkBoxEmail;
        private System.Windows.Forms.GroupBox groupBoxDataAnalytics;
        private System.Windows.Forms.Button buttonLoadData;
        private System.Windows.Forms.TextBox textBoxDataFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDownTo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDownFrom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckedListBox checkedListBoxPlace;
        private System.Windows.Forms.CheckedListBox checkedListBoxJob;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckedListBox checkedListBoxGender;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonAnalytics;
        private System.Windows.Forms.CheckedListBox checkedListBoxEducation;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBoxChartAnalytics;
        private ZedGraph.ZedGraphControl zedGraphControl1;
        private System.Windows.Forms.Button buttonRun;
        private System.Windows.Forms.CheckBox checkBoxPlaceChart;
        private System.Windows.Forms.CheckBox checkBoxAgeChart;
        private System.Windows.Forms.CheckBox checkBoxEduChart;
        private System.Windows.Forms.CheckBox checkBoxMajorChart;
    }
}

