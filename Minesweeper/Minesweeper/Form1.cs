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

namespace Minesweeper
{
    public partial class Form1 : Form
    {
      
       
        public Form1()
        {
            InitializeComponent();

           
            
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
           
         
        }

        

        private void square_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.Visible = false;
            

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

        public void settingBoard()
        {
             Random rand = new Random();
             
                    // creating an array of 8*8 to represent a board of 8*8 
            int mine = 0;

            
            for (int row = 0; row < 8; row++)     //iterating through each cell
            {
                for (int column = 0; column < 8; column++)
                {
                    if (mine < 20)
                    {
                        int temp = rand.Next(0, 2);
                        arr[row, column].Text = temp.ToString(); //either add a mine or not. mine=1,nomine=0.

                        if (arr[row, column].Text == "1")              
                        {
                            arr[row, column].Text = "9";               //mine =9
                            mine++;     //when a mine is added
                        }
                    }
                    else
                    {
                        arr[row, column].Text = "0";      //number of mines reached , make all other cells mine free

                    }
                }
            }

            int cellValue = 0;
            for (int row = 0; row < 8; row++)             //iterating through the array board to 
            {                                       //set non-mine area to show the number of neighbouring mines
                for (int column = 0; column < 8; column++)
                {
                    
                  if (arr[row, column].Text == "0")
                    {
//----------------------------------------------------------------------------------------------------------------
                        if (row - 1 < 0)            //Top side
                      {
                          if (row - 1 < 0 && column - 1 < 0)          //Top left cell
                          {

                              if (arr[row, column + 1].Text == "9")        //4
                              {
                                  cellValue++;
                              }
                              if (arr[row + 1, column + 1].Text == "9")      //5
                              {
                                  cellValue++;
                              }
                              if (arr[row + 1, column].Text == "9")        //6
                              {
                                  cellValue++;
                              }
                          }
                          else if (row - 1 < 0 && column + 1 > 7)      // top right cell
                          {

                              if (arr[row + 1, column].Text == "9")        //6
                              {
                                  cellValue++;
                              }
                              if (arr[row + 1, column - 1].Text == "9")      //7
                              {
                                  cellValue++;
                              }
                              if (arr[row, column - 1].Text == "9")        //8
                              {
                                  cellValue++;
                              }
                          }
                          else {                                    //Top side cells
                              if (arr[row, column + 1].Text == "9")        //4
                              {
                                  cellValue++;
                              }
                              if (arr[row + 1, column + 1].Text == "9")      //5
                              {
                                  cellValue++;
                              }
                              if (arr[row + 1, column].Text == "9")        //6
                              {
                                  cellValue++;
                              }
                              if (arr[row + 1, column - 1].Text == "9")      //7
                              {
                                  cellValue++;
                              }
                              if (arr[row, column - 1].Text == "9")        //8
                              {
                                  cellValue++;
                              }
                          }
                      }

//----------------------------------------------------------------------------------------------------------------
                    else if(column -1 < 0)              //left side
                        {
                            if (row - 1 < 0 && column - 1 < 0)          //Top left cell
                            {

                                if (arr[row, column + 1].Text == "9")        //4
                                {
                                    cellValue++;
                                }
                                if (arr[row + 1, column + 1].Text == "9")      //5
                                {
                                    cellValue++;
                                }
                                if (arr[row + 1, column].Text == "9")        //6
                                {
                                    cellValue++;
                                }
                            }
                            else if (row + 1 > 7 && column - 1 < 0)     //bottom left cell
                            {

                                if (arr[row - 1, column].Text == "9")        //2
                                {
                                    cellValue++;
                                }
                                if (arr[row - 1, column + 1].Text == "9")      //3
                                {
                                    cellValue++;
                                }
                                if (arr[row, column + 1].Text == "9")        //4
                                {
                                    cellValue++;
                                }

                            }
                            else                                //left side  cells
                            {
                                if (arr[row - 1, column].Text == "9")        //2
                                {
                                    cellValue++;
                                }
                                if (arr[row - 1, column + 1].Text == "9")      //3
                                {
                                    cellValue++;
                                }
                                if (arr[row, column + 1].Text == "9")        //4
                                {
                                    cellValue++;
                                }
                                if (arr[row + 1, column + 1].Text == "9")      //5
                                {
                                    cellValue++;
                                }
                                if (arr[row + 1, column].Text == "9")        //6
                                {
                                    cellValue++;
                                }
                            }
                    }


//----------------------------------------------------------------------------------------------------------------
                    else if (row +1 > 7)                        //bottom side
                        {
                        if (row + 1 > 7 && column + 1 > 7)      // bottom right cell
                            {
                                if (arr[row - 1, column - 1].Text == "9")        //1
                                {
                                    cellValue++;
                                }
                                if (arr[row - 1, column].Text == "9")        //2
                                {
                                    cellValue++;
                                }

                                if (arr[row, column - 1].Text == "9")        //8
                                {
                                    cellValue++;
                                }
                            }
                        else if (row + 1 > 7 && column - 1 < 0)     //bottom left cell
                        {

                            if (arr[row - 1, column].Text == "9")        //2
                            {
                                cellValue++;
                            }
                            if (arr[row - 1, column + 1].Text == "9")      //3
                            {
                                cellValue++;
                            }
                            if (arr[row, column + 1].Text == "9")        //4
                            {
                                cellValue++;
                            }

                        }
                        else {                                      //Bottom side cells
                            if (arr[row - 1, column - 1].Text == "9")        //1
                            {
                                cellValue++;
                            }
                            if (arr[row - 1, column].Text == "9")        //2
                            {
                                cellValue++;
                            }
                            if (arr[row - 1, column + 1].Text == "9")      //3
                            {
                                cellValue++;
                            }
                            if (arr[row, column + 1].Text == "9")        //4
                            {
                                cellValue++;
                            }
                            if (arr[row, column - 1].Text == "9")        //8
                            {
                                cellValue++;
                            }
                        }
                    }
//----------------------------------------------------------------------------------------------------------------
               else if(column+1 > 7)                        //Right side
                        {
                    if (row - 1 < 0 && column + 1 > 7)      // top right cell
                              {

                                  if (arr[row + 1, column].Text == "9")        //6
                                  {
                                      cellValue++;
                                  }
                                  if (arr[row + 1, column - 1].Text == "9")      //7
                                  {
                                      cellValue++;
                                  }
                                  if (arr[row, column - 1].Text == "9")        //8
                                  {
                                      cellValue++;
                                  }
                              }
                     else if (row + 1 > 7 && column + 1 > 7)      // bottom right cell
                            {
                                if (arr[row - 1, column - 1].Text == "9")        //1
                                {
                                    cellValue++;
                                }
                                if (arr[row - 1, column].Text == "9")        //2
                                {
                                    cellValue++;
                                }

                                if (arr[row, column - 1].Text == "9")        //8
                                {
                                    cellValue++;
                                }
                            }
                            
                     else {                                         // Right side cells
                         if (arr[row - 1, column - 1].Text == "9")        //1
                                {
                                    cellValue++;
                                }
                         if (arr[row - 1, column].Text == "9")        //2
                                {
                                    cellValue++;
                                }
                                }
                    if (arr[row + 1, column].Text == "9")        //6
                                {
                                    cellValue++;
                                }
                    if (arr[row + 1, column - 1].Text == "9")      //7
                                {
                                    cellValue++;
                                }
                    if (arr[row, column - 1].Text == "9")        //8
                                {
                                    cellValue++;
                                }
                        }
//----------------------------------------------------------------------------------------------------------------
       else{                                                           // All other cells in Mid
                            if (arr[row - 1, column - 1].Text == "9")        //1
                            {
                                cellValue++;
                            }
                            if (arr[row - 1, column].Text == "9")        //2
                            {
                                cellValue++;
                            }
                            if (arr[row - 1, column + 1].Text == "9")      //3
                            {
                                cellValue++;
                            }
                            if (arr[row, column + 1].Text == "9")        //4
                            {
                                cellValue++;
                            }
                            if (arr[row + 1, column + 1].Text == "9")      //5
                            {
                                cellValue++;
                            }
                            if (arr[row + 1, column].Text == "9")        //6
                            {
                                cellValue++;
                            }
                            if (arr[row + 1, column - 1].Text == "9")      //7
                            {
                                cellValue++;
                            }
                            if (arr[row, column - 1].Text == "9")        //8
                            {
                                cellValue++;
                            }
                        }
                        arr[row, column].Text = cellValue.ToString();
                        cellValue = 0;

                    }
                }
            }
        }
        
    }
}
