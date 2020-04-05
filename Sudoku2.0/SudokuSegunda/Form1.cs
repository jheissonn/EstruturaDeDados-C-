using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SudokuSegunda
{
    public partial class Form1 : Form
    {

        int[,] sudoku ={{0, 7, 0, 0, 0, 0, 0, 2, 0},
                        {2, 0, 0, 0, 0, 0, 0, 0, 3},
                        {3, 0, 5, 2, 0, 6, 9, 0, 8},
                        {0, 9, 0, 0, 2, 0, 0, 1, 0},
                        {0, 0, 0, 0, 4, 0, 0, 0, 0},
                        {0, 8, 0, 0, 1, 0, 0, 3, 0},
                        {1, 0, 7, 4, 0, 5, 6, 0, 2},
                        {8, 0, 0, 0, 0, 0, 0, 0, 1},
                        {0, 6, 0, 0, 0, 0, 0, 9, 0 } };

        private int[,] board;
        public static int empty = 0;
        public static int size = 9;

        public Form1()
        {
            InitializeComponent();        
            dataGridSudoku.RowCount = 9;
            dataGridSudoku.ColumnCount = 9;
            proMostrar(sudoku);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
        public void proMostrar(int[,] board)
        {
            for (int y = 0; y <size; y++)
            {
                for (int x = 0; x < size; x++)
                {
                    dataGridSudoku.Rows[y].Cells[x].Value = board[y, x];
                    dataGridSudoku.Rows[y].Cells[x].Style.ForeColor = Color.Red;
                    dataGridSudoku.Rows[y].Cells[x].ReadOnly = true;
                }
            }
        }

        private void Sudokuresolver (int [,] board)
        {
            this.board = new int[size, size];

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    this.board[i, j] = board[i, j];

                }
            }
        }

        private Boolean isinRow(int Row, int Number)
        {
            for (int i = 0; i < size; i++)
            {
                if (board[Row, i] == Number)
                {
                    return true;
                }
            }
            return false;
        }

        private Boolean isinCol(int Col, int Number)
        {
            for (int i = 0; i < size; i++)
            {
                if (board[i, Col] == Number)
                {
                    return true;
                }
            }
            return false;
        }

        private Boolean isinBOX(int Row, int Col,int Number)
        {
            int r = Row - Row % 3;
            int c = Col - Col % 3;

            for (int i = r; i < r + 3; i++)
            {
            for (int j = c; j < c + 3; j++)
            {
                    if (board[i, j] == Number)
                    {
                        return true;
                    }
            }
            }
            return false;
        }

        private Boolean isok(int Row, int Col, int Number)
        {
            return isinRow(Row, Number) && isinCol(Col, Number) && isinBOX(Row, Col, Number);
        }

        public Boolean Solve()
        {
            for (int row = 0; row < size ; row++)
            {
                for(int col = 0; col < size; col++) 
                {
                    if(board[row,col]== empty)
                    {
                        for(int number= 1;number<=size;number++)
                        {
                            if(isok(row,col,number))
                            {
                                board[row, col] = number;
                            }
                            if(Solve()) // backtracking recursivo;
                            {
                                return true;
                            }
                            else // se não achar a solução retorna e continua;
                            {
                                board[row, col] = empty;
                            }
                        }
                    }
                    return false;
                } 
            }

            return true; // sudoku resolvido;
        }

        private void btnResolver_Click(object sender, EventArgs e)
        {
           Sudokuresolver(sudoku);
            if(Solve()==true)
            {
                MessageBox.Show("Resolvido");
            }
            else
            {
                MessageBox.Show("Sem Solução");
            }
        }

        private void dataGridSudoku_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
        }
        private void dataGridSudoku_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawLine(new Pen(Color.Black, 2), 75, 0, 75, 228);
            e.Graphics.DrawLine(new Pen(Color.Black, 2), 150, 0, 150, 228);
            e.Graphics.DrawLine(new Pen(Color.Black, 2), 0, 66, 228, 66);
            e.Graphics.DrawLine(new Pen(Color.Black, 2), 0, 132, 228, 132);
        }
    }
}

       

