using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TentativaSudoku
{
    
    public partial class Principal : Form
    {
        int[,] Sudoku = {{9, 7, 6, 8, 3, 4, 1, 2, 5 },
                         {2, 4, 8, 9, 5, 1, 7, 6, 3 },
                         {3, 1, 5, 2, 7, 6, 9, 4, 8 },
                         {4, 9, 3, 5, 2, 7, 8, 1, 6 },
                         {6, 5, 1, 3, 4, 8, 2, 7, 9 },
                         {7, 8, 2, 6, 1, 9, 5, 3, 4 },
                         {1, 3, 7, 4, 9, 5, 6, 8, 2 },
                         {8, 2, 9, 7, 6, 3, 4, 5, 1 }, };
        public Principal()
        {
            InitializeComponent();
            proMostrar(Sudoku);

        }
        


        public void proMostrar(int[][] grid)
        {
            for (int y = 0; y <= 8; y++)
            {
                for (int x = 0; x <= 8; x++)
                {

                    dataGridSudoku.Rows[y].Cells[x].Value = grid[y][x];
                    dataGridSudoku.Rows[y].Cells[x].Style.ForeColor = Color.Red;
                    dataGridSudoku.Rows[y].Cells[x].ReadOnly = true;
                }

            }
            
        }


    }
}
