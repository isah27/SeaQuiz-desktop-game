using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace LibraryApplication
{
    public partial class PlayPage : Form
    {
        
        public PlayPage()
        {
            InitializeComponent();
            
        }
        static List<Questions> questions;//getting the questions from formplayQuiz
        int scrollCount = 0;//this is for pagination
        FormSearchQuestion formSearchQuestion;
      
           

        private void previousBtn_Click(object sender, EventArgs e)
        {
           
            if (scrollCount >=1)
            {
                scrollCount--;
                selectedoptions.RemoveAt(scrollCount);
            }
            Quiz(scrollCount);
        }
        List<string> selectedoptions = new List<string>();

        /*
         this method display your performance  once you are done answering the questions
        such as the wrong option and the right options a player selected
         */
        void markQuiz()
        {
            
            if (radioButtonA.Checked == true)
            {
                selectedoptions.Add(radioButtonA.Text); 
            }
            if (radioButtonB.Checked == true)
            {
                selectedoptions.Add(radioButtonB.Text);    
            }
            if (radioButtonC.Checked == true)
            {
                selectedoptions.Add(radioButtonC.Text);   
            }
            int WrongAnswer = 0;
            int correctAnswer = 0;
            if (questions.Count <= scrollCount)
            {
                    for (int i = 0; i < selectedoptions.Count; i++)
                    {
                        if (selectedoptions[i] == questions[i].Answer)
                        {
                            correctAnswer++;
                        }
                    }
                WrongAnswer = questions.Count - correctAnswer;
                questionLabel.Text = "Scores\n\nCorrect Answers: " + correctAnswer + "\n\nWrong Answers: " + WrongAnswer + "";
                hideRadioAndBackButton();
                nextBtn.Visible = false;
            }
        }
        private void nextBtn_Click(object sender, EventArgs e)
        {
            //check if a player has select an option else a message should be display to the player to select an option
            if(radioButtonA.Checked==true|| radioButtonB.Checked == true || radioButtonC.Checked == true)
            {
                scrollCount++;//add 1 to the scrollCount variable
                markQuiz(); 
                Quiz(scrollCount);
                uncheckRadioButton();
            }
            else
            {
                MessageBox.Show("Please select your prefere answer");
            }
        }

        //method to hide radio  and back button once you are done answering the questions
        public void hideRadioAndBackButton()
        {
            radioButtonA.Visible = false;
            radioButtonB.Visible = false;
            radioButtonC.Visible = false;
            previousBtn.Visible = false;
            nextBtn.Visible = false;
        }
        //method to uncheck the radio  button 
        public void uncheckRadioButton()
        {
            radioButtonA.Checked = false;
            radioButtonB.Checked = false;
            radioButtonC.Checked = false;         
        }
      
        /*
         this method display your performance  once you are done answering the questions
         */
        void Quiz( int scrollCount)
        {
            try
            {
                if (questions.Count >= scrollCount)
                {

                    if (questions.Count > scrollCount)
                    {
                        questionLabel.Text = questions[scrollCount].Question;
                        radioButtonA.Text = questions[scrollCount].OptionA;
                        radioButtonB.Text = questions[scrollCount].OptionB;
                        radioButtonC.Text = questions[scrollCount].OptionC;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message);
            }
           
        }

        private void backPageBtn_Click(object sender, EventArgs e)
        {
            formSearchQuestion.Show();
            this.Close();
        }
        private void PlayPage_Load(object sender, EventArgs e)
        {
            questions = FormSearchQuestion.questions;
            formSearchQuestion = new FormSearchQuestion();
            if (questions.Count <= 0)
            {
                MessageBox.Show("No question available for this operation");
                formSearchQuestion.Show();
                this.Close(); 
            }
            else
            {
                Quiz(scrollCount);
                uncheckRadioButton();
            }
        }
    }
}
