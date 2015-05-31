using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Timers;
using Timer = System.Timers.Timer;
using System.Threading;

namespace Minesweeper
{
    public partial class Form1 : Form
    {
      
       
        public Form1()
        {
            InitializeComponent();

            //HINT For SELF: try using arr[0, 0].ImageKey = "x"; for mine and something else for others.
            
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        

        
      

        private void smileyButton_Click(object sender, EventArgs e)
        {
            //Image objectImg = Image.FromFile("C:\\Users\\NCLab-04\\Desktop\\2000px-Day-template.svg.png");
            //smileyButton.Image= objectImg;
            //smileyButton.Width = objectImg.Width;
            //smileyButton.Height = objectImg.Height;
            set_Buttons();
            settingBoard();
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            settingBoard();
         
        }
        //Form1 newobj = new Form1();
        //public static void myTimer()
        //{

        //    for (int time = 0; time < 999; time++)
        //    {

        //        label1.Text = time.ToString();
        //        Thread.Sleep(1000);
        //    }
        //}

        //public int clickcounter = 0;
        private void square_Click(object sender, EventArgs e)
        {
            //Form1 newobj = new Form1();
            //Thread timeThread = new Thread(Form1.myTimer);

            //while (clickcounter == 0)
            //{
            //    timeThread.Start();
            //    clickcounter++;
            //}
            Button btn = (Button)sender;


            int selColumn;
            int selRow;
            string tempstr = (string)btn.Tag;
            int tempTag = Int32.Parse(tempstr);
            selColumn = tempTag % 8;
            selRow = tempTag / 8;
            btn.Text = value[selRow, selColumn];
            btn.Enabled = false;
            if (value[selRow, selColumn] == "x")
            {
                btn.Text = "";
                Image mineImage = Image.FromFile("D:\\Myproject\\Minesweeper\\images\\mine_minesweeper.PNG");
                btn.BackgroundImage = mineImage;
                MessageBox.Show("You Lost the game");
            }
            else
            {
                int tempvalue = Int32.Parse(value[selRow, selColumn]);
                switch (tempvalue)
                {
                    case 0:
                        Image zeroImage = Image.FromFile("D:\\Myproject\\Minesweeper\\images\\0.PNG");
                        btn.BackgroundImage = zeroImage; 
                        break;
                    case 1:
                         Image oneImage = Image.FromFile("D:\\Myproject\\Minesweeper\\images\\1.PNG");
                        btn.BackgroundImage = oneImage; 
                        break;
                    case 2:
                         Image twoImage = Image.FromFile("D:\\Myproject\\Minesweeper\\images\\2.PNG");
                         btn.BackgroundImage = twoImage; 
                        break;
                    case 3:
                         Image threeImage = Image.FromFile("D:\\Myproject\\Minesweeper\\images\\3.PNG");
                         btn.BackgroundImage = threeImage; 
                        break;
                    case 4:
                         Image fourImage = Image.FromFile("D:\\Myproject\\Minesweeper\\images\\4.PNG");
                         btn.BackgroundImage = fourImage; 
                        break;
                    case 5:
                         Image fiveImage = Image.FromFile("D:\\Myproject\\Minesweeper\\images\\5.PNG");
                         btn.BackgroundImage = fiveImage; 
                        break;
                    case 6:
                         Image sixImage = Image.FromFile("D:\\Myproject\\Minesweeper\\images\\6.PNG");
                         btn.BackgroundImage = sixImage; 
                        break;
                    case 7:
                         Image sevenImage = Image.FromFile("D:\\Myproject\\Minesweeper\\images\\7.PNG");
                         btn.BackgroundImage = sevenImage; 
                        break;
                    case 8:
                         Image eightImage = Image.FromFile("D:\\Myproject\\Minesweeper\\images\\8.PNG");
                         btn.BackgroundImage = eightImage; 
                        break;
                       
                }
            }
        }
        public static Button[,] arr = new Button[8, 8];
        public void set_Buttons()
        {
            
            arr[0, 0] = cell_1;
            arr[0, 1] = cell_2;
            arr[0, 2] = cell_3;
            arr[0, 3] = cell_4;
            arr[0, 4] = cell_5;
            arr[0, 5] = cell_6;
            arr[0, 6] = cell_7;
            arr[0, 7] = cell_8;
            arr[1, 0] = cell_9;
            arr[1, 1] = cell_10;
            arr[1, 2] = cell_11;
            arr[1, 3] = cell_12;
            arr[1, 4] = cell_13;
            arr[1, 5] = cell_14;
            arr[1, 6] = cell_15;
            arr[1, 7] = cell_16;
            arr[2, 0] = cell_17;
            arr[2, 1] = cell_18;
            arr[2, 2] = cell_19;
            arr[2, 3] = cell_20;
            arr[2, 4] = cell_21;
            arr[2, 5] = cell_22;
            arr[2, 6] = cell_23;
            arr[2, 7] = cell_24;
            arr[3, 0] = cell_25;
            arr[3, 1] = cell_26;
            arr[3, 2] = cell_27;
            arr[3, 3] = cell_28;
            arr[3, 4] = cell_29;
            arr[3, 5] = cell_30;
            arr[3, 6] = cell_31;
            arr[3, 7] = cell_32;
            arr[4, 0] = cell_33;
            arr[4, 1] = cell_34;
            arr[4, 2] = cell_35;
            arr[4, 3] = cell_36;
            arr[4, 4] = cell_37;
            arr[4, 5] = cell_38;
            arr[4, 6] = cell_39;
            arr[4, 7] = cell_40;
            arr[5, 0] = cell_41;
            arr[5, 1] = cell_42;
            arr[5, 2] = cell_43;
            arr[5, 3] = cell_44;
            arr[5, 4] = cell_45;
            arr[5, 5] = cell_46;
            arr[5, 6] = cell_47;
            arr[5, 7] = cell_48;
            arr[6, 0] = cell_49;
            arr[6, 1] = cell_50;
            arr[6, 2] = cell_51;
            arr[6, 3] = cell_52;
            arr[6, 4] = cell_53;
            arr[6, 5] = cell_54;
            arr[6, 6] = cell_55;
            arr[6, 7] = cell_56;
            arr[7, 0] = cell_57;
            arr[7, 1] = cell_58;
            arr[7, 2] = cell_59;
            arr[7, 3] = cell_60;
            arr[7, 4] = cell_61;
            arr[7, 5] = cell_62;
            arr[7, 6] = cell_63;
            arr[7, 7] = cell_64;
          
        }

       public static string[,] value = new string[8, 8];
        public static void settingBoard()
        {
            Random rand = new Random();

            // creating an array of 8*8 to represent a board of 8*8 
            int mine = 0;
            

            for (int row = 0; row < 8; row++)     //iterating through each cell
            {
                for (int column = 0; column < 8; column++)
                {
                    if (mine < 15)
                    {
                        int temp = rand.Next(0, 2);
                        value[row, column] = temp.ToString(); //either add a mine or not. mine=1,nomine=0.

                        if (value[row, column] == "1")
                        {

                            value[row, column] = "x";               //mine =9
                            mine++;     //when a mine is added
                        }
                    }
                    else
                    {
                        value[row, column] = "0";
                        //number of mines reached , make all other cells mine free

                    }
                }
            }


            int cellValue = 0;
            for (int row = 0; row < 8; row++)             //iterating through the array board to 
            {                                       //set non-mine area to show the number of neighbouring mines
                for (int column = 0; column < 8; column++)
                {

                    if (value[row, column] == "0")
                    {
                        //----------------------------------------------------------------------------------------------------------------
                        if (row - 1 < 0)            //Top side
                        {
                            if (row - 1 < 0 && column - 1 < 0)          //Top left cell
                            {

                                if (value[row, column + 1] == "x")        //4
                                {
                                    cellValue++;
                                }
                                if (value[row + 1, column + 1] == "x")      //5
                                {
                                    cellValue++;
                                }
                                if (value[row + 1, column] == "x")        //6
                                {
                                    cellValue++;
                                }
                            }
                            else if (row - 1 < 0 && column + 1 > 7)      // top right cell
                            {

                                if (value[row + 1, column] == "x")        //6
                                {
                                    cellValue++;
                                }
                                if (value[row + 1, column - 1] == "x")      //7
                                {
                                    cellValue++;
                                }
                                if (value[row, column - 1] == "x")        //8
                                {
                                    cellValue++;
                                }
                            }
                            else
                            {                                    //Top side cells
                                if (value[row, column + 1] == "x")        //4
                                {
                                    cellValue++;
                                }
                                if (value[row + 1, column + 1] == "x")      //5
                                {
                                    cellValue++;
                                }
                                if (value[row + 1, column] == "x")        //6
                                {
                                    cellValue++;
                                }
                                if (value[row + 1, column - 1] == "x")      //7
                                {
                                    cellValue++;
                                }
                                if (value[row, column - 1] == "x")        //8
                                {
                                    cellValue++;
                                }
                            }
                        }

//----------------------------------------------------------------------------------------------------------------
                        else if (column - 1 < 0)              //left side
                        {
                            if (row - 1 < 0 && column - 1 < 0)          //Top left cell
                            {

                                if (value[row, column + 1] == "x")        //4
                                {
                                    cellValue++;
                                }
                                if (value[row + 1, column + 1] == "x")      //5
                                {
                                    cellValue++;
                                }
                                if (value[row + 1, column] == "x")        //6
                                {
                                    cellValue++;
                                }
                            }
                            else if (row + 1 > 7 && column - 1 < 0)     //bottom left cell
                            {

                                if (value[row - 1, column] == "x")        //2
                                {
                                    cellValue++;
                                }
                                if (value[row - 1, column + 1] == "x")      //3
                                {
                                    cellValue++;
                                }
                                if (value[row, column + 1] == "x")        //4
                                {
                                    cellValue++;
                                }

                            }
                            else                                //left side  cells
                            {
                                if (value[row - 1, column] == "x")        //2
                                {
                                    cellValue++;
                                }
                                if (value[row - 1, column + 1] == "x")      //3
                                {
                                    cellValue++;
                                }
                                if (value[row, column + 1] == "x")        //4
                                {
                                    cellValue++;
                                }
                                if (value[row + 1, column + 1] == "x")      //5
                                {
                                    cellValue++;
                                }
                                if (value[row + 1, column] == "x")        //6
                                {
                                    cellValue++;
                                }
                            }
                        }


    //----------------------------------------------------------------------------------------------------------------
                        else if (row + 1 > 7)                        //bottom side
                        {
                            if (row + 1 > 7 && column + 1 > 7)      // bottom right cell
                            {
                                if (value[row - 1, column - 1] == "x")        //1
                                {
                                    cellValue++;
                                }
                                if (value[row - 1, column] == "x")        //2
                                {
                                    cellValue++;
                                }

                                if (value[row, column - 1] == "x")        //8
                                {
                                    cellValue++;
                                }
                            }
                            else if (row + 1 > 7 && column - 1 < 0)     //bottom left cell
                            {

                                if (value[row - 1, column] == "x")        //2
                                {
                                    cellValue++;
                                }
                                if (value[row - 1, column + 1] == "x")      //3
                                {
                                    cellValue++;
                                }
                                if (value[row, column + 1] == "x")        //4
                                {
                                    cellValue++;
                                }

                            }
                            else
                            {                                      //Bottom side cells
                                if (value[row - 1, column - 1] == "x")        //1
                                {
                                    cellValue++;
                                }
                                if (value[row - 1, column] == "x")        //2
                                {
                                    cellValue++;
                                }
                                if (value[row - 1, column + 1] == "x")      //3
                                {
                                    cellValue++;
                                }
                                if (value[row, column + 1] == "x")        //4
                                {
                                    cellValue++;
                                }
                                if (value[row, column - 1] == "x")        //8
                                {
                                    cellValue++;
                                }
                            }
                        }
                        //----------------------------------------------------------------------------------------------------------------
                        else if (column + 1 > 7)                        //Right side
                        {
                            if (row - 1 < 0 && column + 1 > 7)      // top right cell
                            {

                                if (value[row + 1, column] == "x")        //6
                                {
                                    cellValue++;
                                }
                                if (value[row + 1, column - 1] == "x")      //7
                                {
                                    cellValue++;
                                }
                                if (value[row, column - 1] == "x")        //8
                                {
                                    cellValue++;
                                }
                            }
                            else if (row + 1 > 7 && column + 1 > 7)      // bottom right cell
                            {
                                if (value[row - 1, column - 1] == "x")        //1
                                {
                                    cellValue++;
                                }
                                if (value[row - 1, column] == "x")        //2
                                {
                                    cellValue++;
                                }

                                if (value[row, column - 1] == "x")        //8
                                {
                                    cellValue++;
                                }
                            }

                            else
                            {                                         // Right side cells
                                if (value[row - 1, column - 1] == "x")        //1
                                {
                                    cellValue++;
                                }
                                if (value[row - 1, column] == "x")        //2
                                {
                                    cellValue++;
                                }
                            }
                            if (value[row + 1, column] == "x")        //6
                            {
                                cellValue++;
                            }
                            if (value[row + 1, column - 1] == "x")      //7
                            {
                                cellValue++;
                            }
                            if (value[row, column - 1] == "x")        //8
                            {
                                cellValue++;
                            }
                        }
                        //----------------------------------------------------------------------------------------------------------------
                        else
                        {                                                           // All other cells in Mid
                            if (value[row - 1, column - 1] == "x")        //1
                            {
                                cellValue++;
                            }
                            if (value[row - 1, column] == "x")        //2
                            {
                                cellValue++;
                            }
                            if (value[row - 1, column + 1] == "x")      //3
                            {
                                cellValue++;
                            }
                            if (value[row, column + 1] == "x")        //4
                            {
                                cellValue++;
                            }
                            if (value[row + 1, column + 1] == "x")      //5
                            {
                                cellValue++;
                            }
                            if (value[row + 1, column] == "x")        //6
                            {
                                cellValue++;
                            }
                            if (value[row + 1, column - 1] == "x")      //7
                            {
                                cellValue++;
                            }
                            if (value[row, column - 1] == "x")        //8
                            {
                                cellValue++;
                            }
                        }
                        if (cellValue != 0)
                        {
                            value[row, column] = cellValue.ToString();
                            cellValue = 0;
                        }
                        else { value[row, column] = "0"; }            //to represent cells with 0 value as empty

                    }
                }
            }
        }
        
    }
}
