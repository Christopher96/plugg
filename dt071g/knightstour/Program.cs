using System;
using System.Collections.Generic;

namespace knightstour
{
    class Program
    { 
        static void Main(string[] args)
        {   
            int size = 5;

            bool[,] disabledMoves = new bool[size, size];

            disabledMoves[0,0] = true;
            Coordinate currentPos = new Coordinate(0, 0);
            
            while(true) {

                bool lRight = currentPos.col + 2 < size;
                bool sRight = currentPos.col + 1 < size;
                bool lLeft = currentPos.col - 2 > 0;
                bool sLeft = currentPos.col - 1 > 0;
                bool lUp = currentPos.row + 2 < size;
                bool sUp = currentPos.row + 1 < size;
                bool lDown = currentPos.row - 2 > 0;
                bool sDown = currentPos.row - 1 > 0;
                
                Coordinate newPos = currentPos;

                if(sUp && lRight && !disabledMoves[currentPos.col + 2, currentPos.row + 1]) {
                    newPos = new Coordinate(currentPos.col + 2, currentPos.row + 1);
                } else if(sUp && lLeft && !disabledMoves[currentPos.col - 2, currentPos.row + 1]) {
                    newPos = new Coordinate(currentPos.col - 2, currentPos.row + 1);
                } else if(lUp && sRight && !disabledMoves[currentPos.col + 1, currentPos.row + 2]) {
                    newPos = new Coordinate(currentPos.col + 1, currentPos.row + 2);
                } else if(lUp && sLeft && !disabledMoves[currentPos.col -1, currentPos.row + 2]) {
                    newPos = new Coordinate(currentPos.col - 1, currentPos.row + 2);
                } else if(sDown && lRight && !disabledMoves[currentPos.col + 2, currentPos.row - 1]) {
                    newPos = new Coordinate(currentPos.col + 2, currentPos.row - 1);
                } else if(sDown && lLeft && !disabledMoves[currentPos.col - 2, currentPos.row - 1]) {
                    newPos = new Coordinate(currentPos.col - 2, currentPos.row - 1);
                } else if(lDown && sRight && !disabledMoves[currentPos.col + 1, currentPos.row - 2]) {
                    newPos = new Coordinate(currentPos.col + 1, currentPos.row - 2);
                } else if(lDown && sLeft && !disabledMoves[currentPos.col -1, currentPos.row - 2]) {
                    newPos = new Coordinate(currentPos.col - 1, currentPos.row - 2);
                }

                Console.WriteLine("Current position {0}, {1}", currentPos.col+1, currentPos.row+1);
                
                for(int row = 0; row < size; row++) {
                    string squares = "";
                    for(int col = 0; col < size; col++) {
                        if(disabledMoves[col, row] == true) squares += "x ";
                        else squares += "■ ";
                    }
                    Console.WriteLine(squares);
                }
                Console.ReadKey();
                Console.WriteLine();
                
                
                if(currentPos != newPos) {
                    disabledMoves[newPos.col, newPos.row] = true;
                    currentPos = newPos;
                } else {
                    break;
                }
            }
        }
    }

    public class Coordinate {
        public int col;
        public int row;

        public Coordinate(int col, int row){
            this.col = col;
            this.row = row;
        }
    }
}
