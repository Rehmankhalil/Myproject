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
      
        private static Timer time;
        public Form1()
        {
            InitializeComponent();

           
            
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        public void myTimer()
        {
                   

            time = new System.Timers.Timer(1000);

            time.Enabled = true;
            time.Elapsed +=time_Elapsed;
          
            
        }

        private void time_Elapsed(object sender, ElapsedEventArgs e)
        {
           
            int mytime = 0;
           e.SignalTime.AddSeconds(1);
           mytime += e.SignalTime.Second;
          
            timerLabel.Text = mytime.ToString();
        }
      

        private void smileyButton_Click(object sender, EventArgs e)
        {
            //Image objectImg = Image.FromFile("C:\\Users\\NCLab-04\\Desktop\\2000px-Day-template.svg.png");
            //smileyButton.Image= objectImg;
            //smileyButton.Width = objectImg.Width;
            //smileyButton.Height = objectImg.Height;
        }

      

        private void Form1_Load(object sender, EventArgs e)
        {
           
         
        }

        

        private void square_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.Visible = false;
            myTimer();
                                                //double interval = 1500.0;
            
                                                //time = new Timer(interval);
                                                //timer.Text = time.ToString();

        }

        public void settingBoard()
        {
             Random rand = new Random();
             
            int[,] arr = new int[8, 8];         // creating an array of 8*8 to represent a board of 8*8 
            int mine = 0;


            for (int row = 0; row < 8; row++)     //iterating through each cell
            {
                for (int column = 0; column < 8; column++)
                {
                    if (mine < 5)
                    {
                        arr[row, column] = rand.Next(0, 2); //either add a mine or not. mine=1,nomine=0.

                        if (arr[row, column] == 1)              
                        {
                            arr[row, column] = 9;               //mine =9
                            mine++;     //when a mine is added
                        }
                    }
                    else
                    {
                        arr[row, column] = 0;      //number of mines reached , make all other cells mine free

                    }
                }
            }

            int cellValue = 0;
            for (int row = 0; row < 8; row++)             //iterating through the array board to 
            {                                       //set non-mine area to show the number of neighbouring mines
                for (int column = 0; column < 8; column++)
                {
                    
                  if (arr[row, column] == 0)
                    {
//----------------------------------------------------------------------------------------------------------------
                        if (row - 1 < 0)            //Top side
                      {
                          if (row - 1 < 0 && column - 1 < 0)          //Top left cell
                          {

                              if (arr[row, column + 1] == 9)        //4
                              {
                                  cellValue++;
                              }
                              if (arr[row + 1, column + 1] == 9)      //5
                              {
                                  cellValue++;
                              }
                              if (arr[row + 1, column] == 9)        //6
                              {
                                  cellValue++;
                              }
                          }
                          else if (row - 1 < 0 && column + 1 > 7)      // top right cell
                          {

                              if (arr[row + 1, column] == 9)        //6
                              {
                                  cellValue++;
                              }
                              if (arr[row + 1, column - 1] == 9)      //7
                              {
                                  cellValue++;
                              }
                              if (arr[row, column - 1] == 9)        //8
                              {
                                  cellValue++;
                              }
                          }
                          else {                                    //Top side cells
                              if (arr[row, column + 1] == 9)        //4
                              {
                                  cellValue++;
                              }
                              if (arr[row + 1, column + 1] == 9)      //5
                              {
                                  cellValue++;
                              }
                              if (arr[row + 1, column] == 9)        //6
                              {
                                  cellValue++;
                              }
                              if (arr[row + 1, column - 1] == 9)      //7
                              {
                                  cellValue++;
                              }
                              if (arr[row, column - 1] == 9)        //8
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

                                if (arr[row, column + 1] == 9)        //4
                                {
                                    cellValue++;
                                }
                                if (arr[row + 1, column + 1] == 9)      //5
                                {
                                    cellValue++;
                                }
                                if (arr[row + 1, column] == 9)        //6
                                {
                                    cellValue++;
                                }
                            }
                            else if (row + 1 > 7 && column - 1 < 0)     //bottom left cell
                            {

                                if (arr[row - 1, column] == 9)        //2
                                {
                                    cellValue++;
                                }
                                if (arr[row - 1, column + 1] == 9)      //3
                                {
                                    cellValue++;
                                }
                                if (arr[row, column + 1] == 9)        //4
                                {
                                    cellValue++;
                                }

                            }
                            else                                //left side  cells
                            {
                                if (arr[row - 1, column] == 9)        //2
                                {
                                    cellValue++;
                                }
                                if (arr[row - 1, column + 1] == 9)      //3
                                {
                                    cellValue++;
                                }
                                if (arr[row, column + 1] == 9)        //4
                                {
                                    cellValue++;
                                }
                                if (arr[row + 1, column + 1] == 9)      //5
                                {
                                    cellValue++;
                                }
                                if (arr[row + 1, column] == 9)        //6
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
                                if (arr[row - 1, column - 1] == 9)        //1
                                {
                                    cellValue++;
                                }
                                if (arr[row - 1, column] == 9)        //2
                                {
                                    cellValue++;
                                }
                       
                                if (arr[row, column - 1] == 9)        //8
                                {
                                    cellValue++;
                                }
                            }
                        else if (row + 1 > 7 && column - 1 < 0)     //bottom left cell
                        {

                            if (arr[row - 1, column] == 9)        //2
                            {
                                cellValue++;
                            }
                            if (arr[row - 1, column + 1] == 9)      //3
                            {
                                cellValue++;
                            }
                            if (arr[row, column + 1] == 9)        //4
                            {
                                cellValue++;
                            }

                        }
                        else {                                      //Bottom side cells
                            if (arr[row - 1, column - 1] == 9)        //1
                            {
                                cellValue++;
                            }
                            if (arr[row - 1, column] == 9)        //2
                            {
                                cellValue++;
                            }
                            if (arr[row - 1, column + 1] == 9)      //3
                            {
                                cellValue++;
                            }
                            if (arr[row, column + 1] == 9)        //4
                            {
                                cellValue++;
                            }
                            if (arr[row, column - 1] == 9)        //8
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

                                  if (arr[row + 1, column] == 9)        //6
                                  {
                                      cellValue++;
                                  }
                                  if (arr[row + 1, column - 1] == 9)      //7
                                  {
                                      cellValue++;
                                  }
                                  if (arr[row, column - 1] == 9)        //8
                                  {
                                      cellValue++;
                                  }
                              }
                     else if (row + 1 > 7 && column + 1 > 7)      // bottom right cell
                            {
                                if (arr[row - 1, column - 1] == 9)        //1
                                {
                                    cellValue++;
                                }
                                if (arr[row - 1, column] == 9)        //2
                                {
                                    cellValue++;
                                }

                                if (arr[row, column - 1] == 9)        //8
                                {
                                    cellValue++;
                                }
                            }
                            
                     else {                                         // Right side cells
                                if (arr[row - 1, column - 1] == 9)        //1
                                {
                                    cellValue++;
                                }
                                if (arr[row - 1, column] == 9)        //2
                                {
                                    cellValue++;
                                }
                                }
                                if (arr[row + 1, column] == 9)        //6
                                {
                                    cellValue++;
                                }
                                if (arr[row + 1, column - 1] == 9)      //7
                                {
                                    cellValue++;
                                }
                                if (arr[row, column - 1] == 9)        //8
                                {
                                    cellValue++;
                                }
                        }
//----------------------------------------------------------------------------------------------------------------
       else{                                                           // All other cells in Mid
                            if (arr[row - 1, column - 1] == 9)        //1
                            {
                                cellValue++;
                            }
                            if (arr[row - 1, column] == 9)        //2
                            {
                                cellValue++;
                            }
                            if (arr[row - 1, column + 1] == 9)      //3
                            {
                                cellValue++;
                            }
                            if (arr[row, column + 1] == 9)        //4
                            {
                                cellValue++;
                            }
                            if (arr[row + 1, column + 1] == 9)      //5
                            {
                                cellValue++;
                            }
                            if (arr[row + 1, column] == 9)        //6
                            {
                                cellValue++;
                            }
                            if (arr[row + 1, column - 1] == 9)      //7
                            {
                                cellValue++;
                            }
                            if (arr[row, column - 1] == 9)        //8
                            {
                                cellValue++;
                            }
                        }
                        arr[row, column] = cellValue;
                        cellValue = 0;

                    }
                }
            }
        }
        
    }
}
