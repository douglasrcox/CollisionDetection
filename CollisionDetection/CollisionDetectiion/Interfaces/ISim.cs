using System;
using System.Collections.Generic;
using System.Text;

namespace CollisionDetectiion.Interfaces
{
    public interface ISim
    {
        void MoveLeft(); // Moves the sim character one unit on the line to the left
        void MoveRight(); // Moves the sim character one unit on the line to the right
        void Relax(); // Commands the sim character to not do anything
        void MarkPosition(); // Puts a mark on the line at the current position of the sim character
        bool IsCurrentPositionMarked(); // Inspects the current position of the sim character for a mark and returns true if one is found, false if one is not found.
    };

}
