using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wheel_Of_Fortune
{
    public partial class Form2 : Form
    {
        //Variables
        int character = 0;
        string phrase1 = "ACANOFTOMATOSOUP", phrase2 = "CLOTHESMAKETHEMAN", phrase3 = "AIRTRAFFICCONTROLLER";
        int phrase1Length, phrase2Length, phrase3Length;
        char[] letters1, letters2, letters3;
        int lives = 7;
        Random box = new Random();
        int num;


        public Form2(int x)
        {
            //Randomily chooses a number betwenn 1-3 to decide which puzzle is given
            num = box.Next(1,4);
        
            InitializeComponent();
            character = x;
            phrase1Length = phrase1.Length;
            phrase2Length = phrase2.Length;
            phrase3Length = phrase3.Length;
            letters1 = phrase1.ToCharArray();
            letters2 = phrase2.ToCharArray();
            letters3 = phrase3.ToCharArray();
            addingspaces();
            if (num == 1)
            {
                lblTopic.Text = "IN THE KITCHEN";    
            }
            else if (num == 2)
            {
                lblTopic.Text = "QUOTATION";      
            }
            else if (num == 3)
            {
                lblTopic.Text = "OCCUPATION";
            }

            //Displays the chosen character
            if (character == 1)
            {
                picCharacter.Image = Properties.Resources.bob;
                lblCharacter.Text = "Bob";
            }
            if (character == 2)
            {
                picCharacter.Image = Properties.Resources.sarah;
                lblCharacter.Text = "Sarah";
            }
            if (character == 3)
            {
                picCharacter.Image = Properties.Resources.gilbert;
                lblCharacter.Text = "Gilbert";
            }
            if (character == 4)
            {
                picCharacter.Image = Properties.Resources.emma;
                lblCharacter.Text = "Emma";
            }
        }

        /*private void ChangeColour(object sender, EventArgs e)
        {
            Button oneselected = (Button)sender;
            oneselected.BackColor = Color.Green;
        }*/

        //Creates spaces for phrase1 ("A Can Of Tomato Soup")
        private void addingspaces()
        {
            if (num == 1)
            {
                pic2.Visible = false;
                pic6.Visible = false;
                pic9.Visible = false;
                pic10.Visible = false;
                pic11.Visible = false;
                pic12.Visible = false;
                pic19.Visible = false;
                pic24.Visible = false;
            }
            if (num == 2)
            {
                pic8.Visible = false;
                pic16.Visible = false;
                pic20.Visible = false;
                pic21.Visible = false;
                pic22.Visible = false;
                pic23.Visible = false;
                pic24.Visible = false;
            }
            if (num == 3)
            {
                pic4.Visible = false;
                pic12.Visible = false;
                pic23.Visible = false;
                pic24.Visible = false;
            }
           
        }
        // Checks letters for phrase1 ("A Can Of Tomato Soup")
        private void CheckPhrase1(char given)
        {
            bool gotone = false;

            //for loop that runs through the array and checks for the given letter
            for (int i = 0; i < phrase1.Length; i++)
            {

                //if the given matches the letter in letters
                if (letters1[i] == given)
                {
                    // Subtracting the word length everytime a letter is guessed (helps to determine when user has guessed all the word)
                    phrase1Length = phrase1Length - 1;
                    gotone = true;
                    if (i == 0) pic1.Image = Properties.Resources.A;
                    if (i == 1) pic3.Image = Properties.Resources.C;
                    if (i == 2) pic4.Image = Properties.Resources.A;
                    if (i == 3) pic5.Image = Properties.Resources.N;
                    if (i == 4) pic7.Image = Properties.Resources.O;
                    if (i == 5) pic8.Image = Properties.Resources.F;
                    if (i == 6) pic13.Image = Properties.Resources.T;
                    if (i == 7) pic14.Image = Properties.Resources.O;
                    if (i == 8) pic15.Image = Properties.Resources.M;
                    if (i == 9) pic16.Image = Properties.Resources.A;
                    if (i == 10) pic17.Image = Properties.Resources.T;
                    if (i == 11) pic18.Image = Properties.Resources.O;
                    if (i == 12) pic20.Image = Properties.Resources.S;
                    if (i == 13) pic21.Image = Properties.Resources.O;
                    if (i == 14) pic22.Image = Properties.Resources.U;
                    if (i == 15) pic23.Image = Properties.Resources.P;

                }

            }
            if (phrase1Length == 0)
            {
                // Once all letters are guessed user is notified and is asked if they want to play again
                if (MessageBox.Show("Congratulations you gussed the word, want to play again?", "Play Again?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else
                    this.Close();

            }
            if (gotone == false)
            {
                incorrect();
            }
        }

        // Checks letters for phrase2 ("Clothes Make The Man")
        private void CheckPhrase2(char given2)
        {
            bool gotone = false;
            
                //for loop that runs through the array and checks for the given letter
                for (int i = 0; i < phrase2.Length; i++)
                {
                    
                    //if the given matches the letter in letters
                    if (letters2[i] == given2)
                    {
                        // Subtracting the word length everytime a letter is guessed (helps to determine when user has guessed all the word)
                        phrase2Length = phrase2Length - 1;
                        gotone = true;
                        if (i == 0) pic1.Image = Properties.Resources.C;
                        if (i == 1) pic2.Image = Properties.Resources.L;
                        if (i == 2) pic3.Image = Properties.Resources.O;
                        if (i == 3) pic4.Image = Properties.Resources.T;
                        if (i == 4) pic5.Image = Properties.Resources.H;
                        if (i == 5) pic6.Image = Properties.Resources.E;
                        if (i == 6) pic7.Image = Properties.Resources.S;
                        if (i == 7) pic9.Image = Properties.Resources.M;
                        if (i == 8) pic10.Image = Properties.Resources.A;
                        if (i == 9) pic11.Image = Properties.Resources.K;
                        if (i == 10) pic12.Image = Properties.Resources.E;
                        if (i == 11) pic13.Image = Properties.Resources.T;
                        if (i == 12) pic14.Image = Properties.Resources.H;
                        if (i == 13) pic15.Image = Properties.Resources.E;
                        if (i == 14) pic17.Image = Properties.Resources.M;
                        if (i == 15) pic18.Image = Properties.Resources.A;
                        if (i == 16) pic19.Image = Properties.Resources.N;
                    }
                }
                if (phrase2Length == 0)
                {
                    // Once all letters are guessed user is notified and is asked if they want to play again
                    if (MessageBox.Show("Congratulations you gussed the word, want to play again?", "Play Again?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Application.Restart();
                    }
                    else
                        this.Close();
                }
                if (gotone == false)
                {
                    incorrect();
                }
            
        }

        // Checks letters for phrase3 ("Air Traffic Controller")
        private void CheckPhrase3(char given3)
        {  
            bool gotone = false;
            
                //for loop that runs through the array and checks for the given letter
                for (int i = 0; i < phrase3.Length; i++)
                {
                    
                    //if the given matches the letter in letters
                    if (letters3[i] == given3)
                    {
                        // Subtracting the word length everytime a letter is guessed (helps to determine when user has guessed all the word)
                        phrase3Length -= 1;
                        gotone = true;
                        if (i == 0) pic1.Image = Properties.Resources.A;
                        if (i == 1) pic2.Image = Properties.Resources.I;
                        if (i == 2) pic3.Image = Properties.Resources.R;
                        if (i == 3) pic5.Image = Properties.Resources.T;
                        if (i == 4) pic6.Image = Properties.Resources.R;
                        if (i == 5) pic7.Image = Properties.Resources.A;
                        if (i == 6) pic8.Image = Properties.Resources.F;
                        if (i == 7) pic9.Image = Properties.Resources.F;
                        if (i == 8) pic10.Image = Properties.Resources.I;
                        if (i == 9) pic11.Image = Properties.Resources.C;
                        if (i == 10) pic13.Image = Properties.Resources.C;
                        if (i == 11) pic14.Image = Properties.Resources.O;
                        if (i == 12) pic15.Image = Properties.Resources.N;
                        if (i == 13) pic16.Image = Properties.Resources.T;
                        if (i == 14) pic17.Image = Properties.Resources.R;
                        if (i == 15) pic18.Image = Properties.Resources.O;
                        if (i == 16) pic19.Image = Properties.Resources.L;
                        if (i == 17) pic20.Image = Properties.Resources.L;
                        if (i == 18) pic21.Image = Properties.Resources.E;
                        if (i == 19) pic22.Image = Properties.Resources.R;
                    }
                }
                if (phrase3Length == 0)
                {
                    // Once all letters are guessed user is notified and is asked if they want to play again
                    if (MessageBox.Show("Congratulations you gussed the word, want to play again?", "Play Again?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Application.Restart();
                    }
                    else
                        this.Close();
                }
                if (gotone == false)
                {
                    incorrect();
                }
        }
        //Run this when incorrect letter is guessed
        private void incorrect()
        {
            lives = lives - 1;
            if (lives == 0)
            {
                if (MessageBox.Show("Sorry you are out of chances you lose, want to play again?", "Play Again?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else
                    this.Close();
            }
            else
            {
                MessageBox.Show("Sorry that is incorrect! You have "+ lives +" lives left.");
            }
        }

        private void PressingButtons(object sender, EventArgs e)
        {
            // The text proptery of the button help to determine the letter choosen by the user
            // which is then send over to the checkletter subroutine
            Button oneselected = (Button)sender;
            char letteronbutton = Convert.ToChar(oneselected.Text);
            if (num == 1)
            {
                CheckPhrase1(letteronbutton);
            }
            else if(num == 2)
            {
                CheckPhrase2(letteronbutton);
            }
            else if(num == 3)
            {
                CheckPhrase3(letteronbutton);
            }

            // disables the chosen button
            oneselected.Enabled = false;
        }
    }
}
