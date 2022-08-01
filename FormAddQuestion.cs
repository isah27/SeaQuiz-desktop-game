using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LibraryApplication
{
    public partial class FormAddQuestion : Form
    {
        public FormAddQuestion()
        {
            InitializeComponent();

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveQuestion();
        }
        //clear the text field 
        void clearText()
        {
            qusetiontxt.Text = "";
            optionAtxt.Text = "";
            optionBtxt.Text = "";
            optionCtxt.Text = "";
            answerdropdown.Text = "";
        }

        void SaveQuestion()
        {
            
            if (optionAtxt.Text != "" && optionBtxt.Text != "" && optionCtxt.Text != "" && answerdropdown.Text != "")
            {
                LabelOutput.Visible = true;
                string question = qusetiontxt.Text;
                int cat = int.Parse(catdropdown.SelectedValue.ToString());
                int type = int.Parse(typedropdown.SelectedValue.ToString());

                string optionA = optionAtxt.Text;
                string optionB = optionBtxt.Text;
                string optionC = optionCtxt.Text;
                string answer = answerdropdown.Text.ToString();
                DBConnectivity.SaveQuestion(question, optionA, optionB, optionC, answer, cat, type);
                LabelOutput.Text = "Question has been saved";
                clearText();
            }
            else
            {
                LabelOutput.Text = "All field are required";
            }
        }
        private void FormAddQuestion_Load(object sender, EventArgs e)
        {
            //loading category drop down
            catdropdown.DataSource = DBConnectivity.LoadCategories();
            catdropdown.DisplayMember = "CatDesc";
            catdropdown.ValueMember = "CatId"; //the name of the property that returns the ID
            //loading Question types drop down
            typedropdown.DataSource = DBConnectivity.LoadType();
            typedropdown.DisplayMember = "typeName";
            typedropdown.ValueMember  = "QuestionId"; //the name of the property that returns the ID
        }

        private void answerdropdown_Click(object sender, EventArgs e)
        {
            // loading answer dropdown with optionA-optionC values
            List<string> answerValue = new List<string>() {
                optionAtxt.Text,
                optionBtxt.Text,
                optionCtxt.Text,
            };
            answerdropdown.DataSource = answerValue;
            answerdropdown.DisplayMember = answerValue.ToString();
        }

     
        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Close();
            f1.Show();
        }
    }
}
