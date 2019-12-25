using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Function_Point_Calculator.GUI
{
    public partial class FunctionPointForm : Form
    {
        Function_Point_Calculator_Class FPC;
        public FunctionPointForm()
        {
            InitializeComponent();
            FPC = new Function_Point_Calculator_Class();
            DefaultValues();
        }


        //This Function Called while Form Loading and it Sets Default Values to Comboxes : So, It is :
        //1 - Set FP Parameters' Comboboxes to Average 
        //2- Set TC Factors' Comboboxes to No Influence 
        //3- Set Programming Language Combobox to Assembly Language
        public void DefaultValues()
        {
            ExIn_ComboBox.SelectedIndex = 1;
            ExOut_ComboBox.SelectedIndex = 1;
            ExInq_ComboBox.SelectedIndex = 1;
            InLog_ComboBox.SelectedIndex = 1;
            ExInter_ComboBox.SelectedIndex = 1;

            Data_Com_ComboBox.SelectedIndex = 0;
            Distributed_DP_ComboBox.SelectedIndex = 0;
            Performance_ComboBox.SelectedIndex = 0;
            Heavily_UC_ComboBox.SelectedIndex = 0;
            Transaction_R_ComboBox.SelectedIndex = 0;
            Online_DE_ComboBox.SelectedIndex = 0;
            End_User_E_ComboBox.SelectedIndex = 0;
            Online_Update_ComboBox.SelectedIndex = 0;
            Complex_P_ComboBox.SelectedIndex = 0;
            Reusability_ComboBox.SelectedIndex = 0;
            Installation_E_comboBox.SelectedIndex = 0;
            Operational_E_ComboBox.SelectedIndex = 0;
            Multiple_S_ComboBox.SelectedIndex = 0;
            Facilitate_C_ComboBox.SelectedIndex = 0;

            R_Programming_Lang_ComboBox.SelectedIndex = 0;
        }


        //External Input Add Button Function in Function_Points_Panel
        private void Add_ExIn_Click(object sender, EventArgs e)
        {
            if (ExIn_TextBox.Text == "")
            {
                MessageBox.Show("Please, Enter number of elements!", "Empty Field!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            ListViewItem LVI = new ListViewItem("External Input");
            LVI.SubItems.Add(ExIn_ComboBox.SelectedItem.ToString());
            LVI.SubItems.Add(ExIn_TextBox.Text);

            Added_Data_ListView.Items.Add(LVI);

            switch (ExIn_ComboBox.SelectedIndex)
            {
                case 0:
                    FPC.Add_FP_Parameter(double.Parse(ExIn_TextBox.Text), 3);
                    break;

                case 1:
                    FPC.Add_FP_Parameter(double.Parse(ExIn_TextBox.Text), 4);
                    break;

                case 2:
                    FPC.Add_FP_Parameter(double.Parse(ExIn_TextBox.Text), 6);
                    break;
            }
        }


        //External Output Add Button Function in Function_Points_Panel
        private void Add_ExOut_Click(object sender, EventArgs e)
        {
            if (ExOut_TextBox.Text == "")
            {
                MessageBox.Show("Please, Enter number of elements!", "Empty Field!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            ListViewItem LVI = new ListViewItem("External Output");
            LVI.SubItems.Add(ExOut_ComboBox.SelectedItem.ToString());
            LVI.SubItems.Add(ExOut_TextBox.Text);

            Added_Data_ListView.Items.Add(LVI);

            switch (ExOut_ComboBox.SelectedIndex)
            {
                case 0:
                    FPC.Add_FP_Parameter(double.Parse(ExOut_TextBox.Text), 4);
                    break;

                case 1:
                    FPC.Add_FP_Parameter(double.Parse(ExOut_TextBox.Text), 5);
                    break;

                case 2:
                    FPC.Add_FP_Parameter(double.Parse(ExOut_TextBox.Text), 7);
                    break;
            }
        }


        //External Inquiry Add Button Function in Function_Points_Panel
        private void Add_ExInq_Click(object sender, EventArgs e)
        {
            if (ExInq_TextBox.Text == "")
            {
                MessageBox.Show("Please, Enter number of elements!", "Empty Field!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            ListViewItem LVI = new ListViewItem("External Inquiry");
            LVI.SubItems.Add(ExInq_ComboBox.SelectedItem.ToString());
            LVI.SubItems.Add(ExInq_TextBox.Text);

            Added_Data_ListView.Items.Add(LVI);

            switch (ExInq_ComboBox.SelectedIndex)
            {
                case 0:
                    FPC.Add_FP_Parameter(double.Parse(ExInq_TextBox.Text), 3);
                    break;

                case 1:
                    FPC.Add_FP_Parameter(double.Parse(ExInq_TextBox.Text), 4);
                    break;

                case 2:
                    FPC.Add_FP_Parameter(double.Parse(ExInq_TextBox.Text), 6);
                    break;
            }
        }


        //Internal Logical Files Add Button Function in Function_Points_Panel
        private void Add_InLog_Click(object sender, EventArgs e)
        {
            if (InLog_TextBox.Text == "")
            {
                MessageBox.Show("Please, Enter number of elements!", "Empty Field!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            ListViewItem LVI = new ListViewItem("Internal Logical Files");
            LVI.SubItems.Add(InLog_ComboBox.SelectedItem.ToString());
            LVI.SubItems.Add(InLog_TextBox.Text);

            Added_Data_ListView.Items.Add(LVI);

            switch (InLog_ComboBox.SelectedIndex)
            {
                case 0:
                    FPC.Add_FP_Parameter(double.Parse(InLog_TextBox.Text), 7);
                    break;

                case 1:
                    FPC.Add_FP_Parameter(double.Parse(InLog_TextBox.Text), 10);
                    break;

                case 2:
                    FPC.Add_FP_Parameter(double.Parse(InLog_TextBox.Text), 15);
                    break;
            }
        }


        //External Interface Files Add Button Function in Function_Points_Panel
        private void Add_ExInter_Click(object sender, EventArgs e)
        {
            if (ExInter_TextBox.Text == "")
            {
                MessageBox.Show("Please, Enter number of elements!", "Empty Field!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            ListViewItem LVI = new ListViewItem("External Interface Files");
            LVI.SubItems.Add(ExInter_ComboBox.SelectedItem.ToString());
            LVI.SubItems.Add(ExInter_TextBox.Text);

            Added_Data_ListView.Items.Add(LVI);

            switch (ExInter_ComboBox.SelectedIndex)
            {
                case 0:
                    FPC.Add_FP_Parameter(double.Parse(ExInter_TextBox.Text), 5);
                    break;

                case 1:
                    FPC.Add_FP_Parameter(double.Parse(ExInter_TextBox.Text), 7);
                    break;

                case 2:
                    FPC.Add_FP_Parameter(double.Parse(ExInter_TextBox.Text), 10);
                    break;
            }
        }


        //Calculte UFP Button Function in Function_Points_Panel
        private void CalculateUFP_Click(object sender, EventArgs e)
        {
            if (FPC.Check_FP_Parameters_Empty())
            {
                MessageBox.Show("Please, Add Function Piont Parameters!", "Empty Field!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            UFP_TextBox.Text = FPC.Calculate_UFP_Value().ToString();
        }


        //PictureBox Function in Function_Points_Panel
        private void Next_FP_Panel_Click(object sender, EventArgs e)
        {
            if (UFP_TextBox.Text == "0" && FPC.Check_FP_Parameters_Empty())
            {
                MessageBox.Show("Please, Add Function Piont Parameters!", "Empty Field!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else if (UFP_TextBox.Text == "0" && !FPC.Check_FP_Parameters_Empty())
            {
                MessageBox.Show("Press Calculate UFP!", "Empty Field!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            DI_Options_Panel.Visible = true;
            Function_Points_Panel.Visible = false;
        }


        //PictureBox Function in TC_Factors_Panel is to Add and Calculate DI (TC) Factors 
        private void Next_TC_Factors_Panel_Click(object sender, EventArgs e)
        {
            FPC.Add_DI_Attribute(Data_Com_ComboBox.SelectedIndex);
            FPC.Add_DI_Attribute(Distributed_DP_ComboBox.SelectedIndex);
            FPC.Add_DI_Attribute(Performance_ComboBox.SelectedIndex);
            FPC.Add_DI_Attribute(Heavily_UC_ComboBox.SelectedIndex);
            FPC.Add_DI_Attribute(Transaction_R_ComboBox.SelectedIndex);
            FPC.Add_DI_Attribute(Online_DE_ComboBox.SelectedIndex);
            FPC.Add_DI_Attribute(End_User_E_ComboBox.SelectedIndex);
            FPC.Add_DI_Attribute(Online_Update_ComboBox.SelectedIndex);
            FPC.Add_DI_Attribute(Complex_P_ComboBox.SelectedIndex);
            FPC.Add_DI_Attribute(Reusability_ComboBox.SelectedIndex);
            FPC.Add_DI_Attribute(Installation_E_comboBox.SelectedIndex);
            FPC.Add_DI_Attribute(Operational_E_ComboBox.SelectedIndex);
            FPC.Add_DI_Attribute(Multiple_S_ComboBox.SelectedIndex);
            FPC.Add_DI_Attribute(Facilitate_C_ComboBox.SelectedIndex);

            FPC.Calculate_DI_Value();
            Calculate_Results();

            Result_Panel.Visible = true;
            TC_Factors_Panel.Visible = false;
            DI_Options_Panel.Visible = false;
        }


        //PictureBox Function in Enter_DI_Panel is to Set DI Value 
        private void Next_Enter_DI_Panel_Click(object sender, EventArgs e)
        {
            if (DI_TextBox.Text == "")
            {
                MessageBox.Show("Please, Degree of Influence!", "Empty Field!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            FPC.DI = int.Parse(DI_TextBox.Text);
            Calculate_Results();
            Result_Panel.Visible = true;
            Enter_DI_Panel.Visible = false;
            DI_Options_Panel.Visible = false;
        }


        //Calcluate the final Results that will appear in Result_Panel
        private void Calculate_Results()
        {
            R_UFP_TextBox.Text = FPC.UFP.ToString();
            R_DI_TextBox.Text = FPC.DI.ToString();
            R_TCF_TextBox.Text = FPC.Calculate_TCF_Value().ToString();
            R_FP_TextBox.Text = FPC.Calculate_FP_Value().ToString();
            R_LOC_TextBox.Text = FPC.Calculate_LOC_Value(320).ToString();
        }


        //Programming Language ComboBox Function in Reslut_Panel when change the Programming Language
        private void R_Programming_Lang_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (R_Programming_Lang_ComboBox.SelectedIndex)
            {
                case 0:
                    AVC_Value.Text = "320";
                    R_LOC_TextBox.Text = FPC.Calculate_LOC_Value(320).ToString();
                    break;

                case 1:
                    AVC_Value.Text = "128";
                    R_LOC_TextBox.Text = FPC.Calculate_LOC_Value(128).ToString();
                    break;

                case 2:
                    AVC_Value.Text = "105";
                    R_LOC_TextBox.Text = FPC.Calculate_LOC_Value(105).ToString();
                    break;

                case 3:
                    AVC_Value.Text = "90";
                    R_LOC_TextBox.Text = FPC.Calculate_LOC_Value(90).ToString();
                    break;

                case 4:
                    AVC_Value.Text = "70";
                    R_LOC_TextBox.Text = FPC.Calculate_LOC_Value(70).ToString();
                    break;

                case 5:
                    AVC_Value.Text = "64";
                    R_LOC_TextBox.Text = FPC.Calculate_LOC_Value(64).ToString();
                    break;

                case 6:
                    AVC_Value.Text = "32";
                    R_LOC_TextBox.Text = FPC.Calculate_LOC_Value(32).ToString();
                    break;

                case 7:
                    AVC_Value.Text = "30";
                    R_LOC_TextBox.Text = FPC.Calculate_LOC_Value(30).ToString();
                    break;

                case 8:
                    AVC_Value.Text = "22";
                    R_LOC_TextBox.Text = FPC.Calculate_LOC_Value(22).ToString();
                    break;

                case 9:
                    AVC_Value.Text = "15";
                    R_LOC_TextBox.Text = FPC.Calculate_LOC_Value(15).ToString();
                    break;

                case 10:
                    AVC_Value.Text = "12";
                    R_LOC_TextBox.Text = FPC.Calculate_LOC_Value(12).ToString();
                    break;

                case 11:
                    AVC_Value.Text = "6";
                    R_LOC_TextBox.Text = FPC.Calculate_LOC_Value(6).ToString();
                    break;

                case 12:
                    AVC_Value.Text = "4";
                    R_LOC_TextBox.Text = FPC.Calculate_LOC_Value(4).ToString();
                    break;
            }

        }


        #region GUI Functions

        private void Start_Button_Click(object sender, EventArgs e)
        {
            Function_Points_Panel.Visible = true;
            label1.Visible = false;
            Start_Button.Visible = false;
        }


        private void ExIn_TextBox_Click(object sender, EventArgs e)
        {
            ExIn_TextBox.SelectAll();
        }


        private void ExOut_TextBox_Click(object sender, EventArgs e)
        {
            ExOut_TextBox.SelectAll();
        }


        private void ExInq_TextBox_Click(object sender, EventArgs e)
        {
            ExInq_TextBox.SelectAll();
        }


        private void InLog_TextBox_Click(object sender, EventArgs e)
        {
            InLog_TextBox.SelectAll();
        }


        private void ExInter_TextBox_Click(object sender, EventArgs e)
        {
            ExInter_TextBox.SelectAll();
        }


        private void Next_PictBox_FP_Panel_MouseMove(object sender, MouseEventArgs e)
        {
            Next_FP_Panel.Image = Properties.Resources.forward_2;
        }


        private void Next_PictBox_FP_Panel_MouseLeave(object sender, EventArgs e)
        {
            Next_FP_Panel.Image = Properties.Resources.forward;
        }


        private void Next_PictBox_FP_Panel_Click(object sender, EventArgs e)
        {
            DI_Options_Panel.Visible = true;
            Function_Points_Panel.Visible = false;
        }


        private void Enter_TC_Factors_Button_Click(object sender, EventArgs e)
        {
            TC_Factors_Panel.Visible = true;
            Enter_DI_Button.Visible = false;
            Enter_TC_Factors_Button.Visible = false;
        }


        private void Enter_DI_Button_Click(object sender, EventArgs e)
        {
            Enter_DI_Panel.Visible = true;
            Enter_DI_Button.Visible = false;
            Enter_TC_Factors_Button.Visible = false;
        }


        private void Next_TC_Factors_Panel_MouseMove(object sender, MouseEventArgs e)
        {
            Next_TC_Factors_Panel.Image = Properties.Resources.forward_2;
        }


        private void Next_TC_Factors_Panel_MouseLeave(object sender, EventArgs e)
        {
            Next_TC_Factors_Panel.Image = Properties.Resources.forward;
        }


        private void DI_TextBox_Click(object sender, EventArgs e)
        {
            DI_TextBox.SelectAll();
        }


        private void Next_Enter_DI_Panel_MouseMove(object sender, MouseEventArgs e)
        {
            Next_Enter_DI_Panel.Image = Properties.Resources.forward_2;
        }


        private void Next_Enter_DI_Panel_MouseLeave(object sender, EventArgs e)
        {
            Next_Enter_DI_Panel.Image = Properties.Resources.forward;
        }


        private void Again_MouseMove(object sender, MouseEventArgs e)
        {
            Again.Image= Properties.Resources.again_2;
        }

        private void Again_MouseLeave(object sender, EventArgs e)
        {
            Again.Image = Properties.Resources.again;
        }

        private void Again_Click(object sender, EventArgs e)
        {
            this.Hide();
            FunctionPointForm FPF = new FunctionPointForm();
            FPF.ShowDialog();
            this.Close();
        }

        #endregion GUI Function
    }

}
