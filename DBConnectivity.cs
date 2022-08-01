using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.OleDb;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace LibraryApplication
{
    class DBConnectivity
    {
        // connection to database
        private static OleDbConnection GetConnection()
        {
            string connString;
            string path = System.IO.Directory.GetCurrentDirectory();
            var newpath = Path.Combine(path, "Question.mdb");
            connString = @"Provider=Microsoft.JET.OLEDB.4.0;Data Source="+newpath+"";
            return new OleDbConnection(connString);
        }

        // Method that returns a list of Category objects with the details from the DB
        public static List<Category> LoadCategories()
        {
            List<Category> categs = new List<Category>();
            OleDbConnection myConnection = GetConnection();

            string myQuery = "SELECT * FROM Category";
            OleDbCommand myCommand = new OleDbCommand(myQuery, myConnection);

            try
            {
                myConnection.Open();
                OleDbDataReader myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    Category g = new Category(int.Parse(myReader["ID"].ToString()), myReader["category"].ToString());
                    categs.Add(g);
                }
                return categs;
            }
            catch (Exception ex)
            {
                Console.WriteLine( ex.Message);
                return null;
            }
            finally
            {
                myConnection.Close();
            }
        }

        // Method that returns a list of Question Types objects with the details from the DB
        public static List<Type> LoadType()
        {
            List<Type> types = new List<Type>();
            OleDbConnection myConnection = GetConnection();

            string myQuery = "SELECT ID, type FROM Types";
            OleDbCommand myCommand = new OleDbCommand(myQuery, myConnection);

            try
            {
                myConnection.Open();
                OleDbDataReader myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    Type g = new Type(int.Parse(myReader["ID"].ToString()), myReader["type"].ToString());
                    types.Add(g);
                }
                return types;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
            finally
            {
                myConnection.Close();
            }
        }

        //method that saves Question in the db
        public static void SaveQuestion(string question, string optionA, string optionB, string optionC, string ans,int catId, int typeId)
        {
            OleDbConnection myConnection = GetConnection();
            string myQuery = "INSERT INTO Questions( question,optionA,optionB,OptionC, answer,categId, typeId) VALUES ( '" + question + "' ,'"+optionA+"','"+optionB+"','"+optionC+"','"+ans+ "', '" + catId + "',  '" + typeId + "')";
            OleDbCommand myCommand = new OleDbCommand(myQuery, myConnection);

            try
            {
                myConnection.Open();
                myCommand.ExecuteNonQuery();
                FullQuestion();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                myConnection.Close();
            }
        }

        //Method that returns a list of Question  objects with the same Type 
        public static List<Questions> LoadQuestionByType(int typeId)
        {
            List<Questions> questions = new List<Questions>();
            OleDbConnection myConnection = GetConnection();
            string myQuery = "SELECT * FROM Questions WHERE typeId =@id";
            OleDbCommand myCommand = new OleDbCommand(myQuery, myConnection);
            myCommand.Parameters.AddWithValue("@id", typeId);

            Dictionary<string, string> loadtypes = new Dictionary<string, string>();
            try
            {
                myConnection.Open();
                OleDbDataReader myReaders = myCommand.ExecuteReader();
               
                while (myReaders.Read())
                {
                    int id = (int)myReaders["ID"];
                    string question = (string)myReaders["question"];
                    string optionA = (string)myReaders["optionA"];
                    string optionB = (string)myReaders["optionB"];
                    string optionC = (string)myReaders["optionC"];
                    string answer = (string)myReaders["answer"];
                    int currentCat = (int)myReaders["categId"];
                    int currentType = (int)myReaders["typeId"];
                    
                    Questions v = new Questions(id,question,optionA,optionB,optionC,answer,currentCat,currentType);
                    questions.Add(v);

                }
                return questions;
            }
            catch (Exception ex)
            {
                Console.WriteLine( ex.Message);
                return null;
            }
            finally
            {
                myConnection.Close();
            }
        }


        //Method that returns a list of Question  objects with the same category 
        public static List<Questions> LoadQuestionByCategory(int catId)
        {
            List<Questions> questions = new List<Questions>();
            OleDbConnection myConnection = GetConnection();
            string myQuery = "SELECT * FROM Questions WHERE typeId =@id";
            OleDbCommand myCommand = new OleDbCommand(myQuery, myConnection);
            myCommand.Parameters.AddWithValue("@id", catId);

            try
            {
                myConnection.Open();
                OleDbDataReader myReaders = myCommand.ExecuteReader();


                while (myReaders.Read())
                {
                    int id = (int)myReaders["ID"];
                    string question = (string)myReaders["question"];
                    string optionA = (string)myReaders["optionA"];
                    string optionB = (string)myReaders["optionB"];
                    string optionC = (string)myReaders["optionC"];
                    string answer = (string)myReaders["answer"];
                    int currentCat = (int)myReaders["categId"];
                    int currentType = (int)myReaders["typeId"];

                    Questions v = new Questions(id, question, optionA, optionB, optionC, answer, currentCat, currentType);
                    questions.Add(v);


                }
                return questions;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
            finally
            {
                myConnection.Close();
            }
        }

        //Method that returns a list of Question  objects 
        public static List<Questions> FullQuestion()
        {
            List<Questions> questions = new List<Questions>();
            OleDbConnection myConnection = GetConnection();
            string myQuery = "SELECT * FROM Questions";
            OleDbCommand myCommand = new OleDbCommand(myQuery, myConnection);

            
            try
            {
                myConnection.Open();
                OleDbDataReader myReaders = myCommand.ExecuteReader();

                while (myReaders.Read())
                {
                    int id = (int)myReaders["ID"];
                    string question = (string)myReaders["question"];
                    string optionA = (string)myReaders["optionA"];
                    string optionB = (string)myReaders["optionB"];
                    string optionC = (string)myReaders["optionC"];
                    string answer = (string)myReaders["answer"];
                    int currentCat = (int)myReaders["categId"];
                    int currentType = (int)myReaders["typeId"];

                    Questions v = new Questions(id, question, optionA, optionB, optionC, answer, currentCat, currentType);
                    questions.Add(v);
                }
                return questions;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
            finally
            {
                myConnection.Close();
            }
        }
    }
}
