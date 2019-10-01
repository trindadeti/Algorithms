using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AmazonOnlineAssessment
{
    public class MatrixOperation
    {
        public int[,] mineSweeper(int[][] bombs, int RowNumbers, int CollumnNumbers)
        {
            int[,] fieldMatrix = new int[RowNumbers, CollumnNumbers];

            foreach (int[] bomb in bombs)
            {
                int x = bomb[0];
                int y = bomb[1];
                fieldMatrix[x, y] = -1;

                for (int i = x - 1; i <= x + 1; i++)
                {
                    for (int j = y - 1; j <= y + 1; j++)
                    {
                        if (i >= 0 && i < RowNumbers
                        && j >= 0 && j < CollumnNumbers
                        && fieldMatrix[i, j] != -1)
                        {
                            fieldMatrix[i, j]++;
                        }
                    }
                }
            }
            
            return fieldMatrix;
        }

    }
}