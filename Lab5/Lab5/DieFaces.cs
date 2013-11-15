/**
 * DieFaces.cs
 * Author: Ajen Shireman
 * 
 * Cass manages images for die faces.
 * 
 * Contains array of face images, and Methods for retrieving them.
 */

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Lab5
{
    class DieFaces
    {
        /* Class Properties */
        private static System.Drawing.Image[] faces = { null, (System.Drawing.Image)(Properties.Resources.face1), (System.Drawing.Image)(Properties.Resources.face2), (System.Drawing.Image)(Properties.Resources.face3), (System.Drawing.Image)(Properties.Resources.face4), (System.Drawing.Image)(Properties.Resources.face5), (System.Drawing.Image)(Properties.Resources.face6) };
        private static Random rng = new Random();

        /* Constructor */
        private DieFaces ()
        {

        }

        /* Methods */
        // Return a specific face
        public static System.Drawing.Image get ( int sides, int face )
        {
            return faces[face];
        }

        // Return a random face
        public static System.Drawing.Image get ( int sides )
        {
            return faces[rng.Next(1, sides)];
        }
    }
}
