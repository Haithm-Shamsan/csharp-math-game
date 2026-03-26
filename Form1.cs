using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Math_Game
{
    public partial class Form1 : Form
    {  enLevel level;
        enOpration opration;
        int FNumber;
        int SNumber;
      enum enOpration {Add,Subtract,Multbli,Divide,All};
        enum enLevel { Easy=1,Mid=2,Hard=3};
        int Resulte;
        int Score;
        short NumberOfQuiztion;


        public void OprationMath()
        {
            Random random = new Random();
            
            switch(opration)
            {

                case enOpration.Add:
                   Resulte= FNumber + SNumber;
                    lblOpration.Text = "+";
                    lblResulte.Text=Resulte.ToString();
                    break;

                case enOpration.Subtract:
                    Resulte = FNumber - SNumber;
                    lblOpration.Text = "-";
                    lblResulte.Text = Resulte.ToString();
                    break;

                case enOpration.Multbli:
                    Resulte = FNumber * SNumber;
                    lblOpration.Text = "*";
                    lblResulte.Text = Resulte.ToString();
                    break;

                case enOpration.Divide:
                    Resulte = FNumber / SNumber;
                    lblOpration.Text = "/";
                    lblResulte.Text = Resulte.ToString();
                    break;
                
                   




            }
             














        }

        public void MathLevels()
        { Random random = new Random();

            switch(level)

            {

                case enLevel.Easy:
                    FNumber=random.Next(1, 10);
                    lblFNumber.Text = FNumber.ToString() ;
                    SNumber = random.Next(1, 8);
                    lblSNumber.Text = SNumber.ToString() ; 
                    break;
                case enLevel.Mid:
                    FNumber = random.Next(11, 50);
                    lblFNumber.Text = FNumber.ToString();
                    SNumber = random.Next(11, 40);
                    lblSNumber.Text = SNumber.ToString();
                    break;
                case enLevel.Hard:
                    FNumber = random.Next(50, 100);
                    lblFNumber.Text = FNumber.ToString();
                    SNumber = random.Next(50, 80);
                    lblSNumber.Text = SNumber.ToString();
                    break;
                   
            }






        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {  
            for(int i=0;i<=NumberOfQuiztion;i++)
            {
              MathLevels();
             OprationMath();
            }
          
           
           

        } 

        private void lblOpration_Click(object sender, EventArgs e)
        {
           
        }

        private void lblResulte_Click(object sender, EventArgs e)
        {
           
            lblResulte.Hide();
        }

        private void lblFNumber_Click(object sender, EventArgs e)
        {
           
        }

        private void lblSNumber_Click(object sender, EventArgs e)
        {
            lblSNumber.Text= SNumber.ToString();
        }

        private void rbEasy_CheckedChanged(object sender, EventArgs e)
        {
            level = enLevel.Easy;
            
        }

        private void rbMid_CheckedChanged(object sender, EventArgs e)
        {
            level = enLevel.Mid;
           
        }

        private void rbHard_CheckedChanged(object sender, EventArgs e)
        {
            level = enLevel.Hard;
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void lblScore_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Resulte.ToString(),"Correct Answer is :",MessageBoxButtons.OK,MessageBoxIcon.Hand);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Tag=Resulte.ToString();

            if(textBox1.Text==textBox1.Tag.ToString())
            {
                Score++;
                lblScore.Text= Score.ToString();
                
            }else
            {
                MessageBox.Show("Wrong Answer ");
            }

            textBox1.Text = "";

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            opration = enOpration.Add;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            opration = enOpration.Subtract;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            opration = enOpration.Multbli;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            opration = enOpration.Add;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            opration = enOpration.All;
        }

        private void lblResulte_Click_1(object sender, EventArgs e)
        {

        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {
             

        }
    }
}
