using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LibraryApplication
{
    public partial class FormSearchQuestion : Form
    {
        public FormSearchQuestion()
        {
            InitializeComponent();

        }

        private void FormSearchQuestion_Load(object sender, EventArgs e)
        {
            //loading question types dropdown field value from DB
            CBType.DataSource = DBConnectivity.LoadType();
            CBType.DisplayMember = "typeName";
            CBType.ValueMember = "questionId";
            //loading question category dropdown field value from DB
            CBCategory.DataSource = DBConnectivity.LoadCategories();
            CBCategory.DisplayMember = "catDesc";
            CBCategory.ValueMember = "catId";
        }
        
        public static List<Questions> questions;//list object that grab data from DB
        PlayPage PlayPage = new PlayPage();//play page navigation object

        private void buttonSearchByCategory_Click(object sender, EventArgs e)
        {
            questions = DBConnectivity.LoadQuestionByType(int.Parse(CBCategory.SelectedValue.ToString()));
            PlayPage.Show();
            this.Close();
            
        }
        private void buttonSearchByTypes_Click(object sender, EventArgs e)
        {
            this.Close();
            questions = DBConnectivity.LoadQuestionByType(int.Parse( CBType.SelectedValue.ToString()));
            PlayPage.Show();
        }
   
      
        private void genQuizBtn_Click_1(object sender, EventArgs e)
        {
            questions = DBConnectivity.FullQuestion();
            this.Close();
            PlayPage.Show();
        }

        private void backPageBtn_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Close();
            form1.Show();
           
        }
    }
}
