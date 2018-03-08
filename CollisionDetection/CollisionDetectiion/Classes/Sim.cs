using CollisionDetectiion.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CollisionDetectiion.Classes
{

    public class Sim : ISim
    {
        // Constructors
        public Sim(long startPosition)
        {
            StartPosition = startPosition;
        }

        // Properties
        private static List<long> MarkedPositions
        { get; set; }

        private long Position
        { get; set; }

        public long StartPosition
        { get; set; }

        // Methods
        public bool IsCurrentPositionMarked()
        {
            return MarkedPositions.Contains(Position);
        }

        public void MarkPosition()
        {
            MarkedPositions.Add(Position);
        }

        public void MoveLeft()
        {
            Position -= 1;            
        }

        public void MoveRight()
        {
            Position += 1;            
        }

        public void Relax()
        {
            // Do nothing
        }
        
        private void ReturnToStartPosition()
        {
            Position = StartPosition;
            MarkPosition();
        }

        private void RemoveAllMarkedPositions()
        {
            MarkedPositions.Clear();
        }
                

        public void Collide()
        {
            var rnd = new Random();
            var lastMovedRight = true;
            long positionToMoveTo = 0;

            while(!IsCurrentPositionMarked())
            {
                ReturnToStartPosition();

                // For figuring out how many spaces to move.  Random class only returns positive numbers.
                if(lastMovedRight)
                { positionToMoveTo = rnd.Next() * -1; /* Move left */ }
                else
                { positionToMoveTo = rnd.Next(); /* Move right */ }

                // Search for marked position and stop, if found.
                for (long pos = 0; pos < positionToMoveTo; pos++)
                {
                    if (lastMovedRight)
                    { MoveLeft(); }
                    else
                    { MoveRight(); }

                    if(IsCurrentPositionMarked())
                    {
                        Relax();
                        RemoveAllMarkedPositions();  // Since Sim found the other marked position
                        break;
                    }
                }

                lastMovedRight = !lastMovedRight;
            }

            // Reaching this code means collision has occurred.

            // NOTES
            // Once this Sim breaks out of the WHILE loop, the other Sim is still going and "searching" until it finds the other Sim.  
            // Another solution was to simply look at the 2 "marked" positions in the static MarkedPositions property and make the Sims just collide, 
            // but that would be too easy and wouldn't show as much code or thought process.

        }

    }
}
