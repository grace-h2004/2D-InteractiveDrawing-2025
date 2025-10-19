// Include the namespaces (code libraries) you need below.
using Microsoft.VisualBasic.FileIO;
using System;
using System.Numerics;

// The namespace your code is in.
namespace MohawkGame2D
{
    /// <summary>
    ///     Your game code goes inside this class!
    /// </summary>
    public class Game
    {
        // Place your variables here:
        Color tan = new Color(235, 202, 190);
        Color brown = new Color(81, 52, 15);
        Color purple = new Color(173, 12, 222);
        Color gold = new Color(255, 206, 6);
        Color darkGreen = new Color(0, 102, 51);

        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.SetTitle("Four Links");
            Window.SetSize(800, 600);

            Draw.LineColor = Color.Clear;
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            Window.ClearBackground(darkGreen);

            //Background
            DrawRowOfCircle(darkGreen, 400, 75, 5, 100);
            DrawRowOfCircle(gold, 325, 50, 5, 100);

            void DrawRowOfCircle(Color circleColor, int y, int r, int count, float space)
            {
                
                for (int i = 0; i < 10; i++)
                {
                    Draw.Circle(space * i, y, r);
                }
                

            }

            //Link hat
            Draw.FillColor = Color.Green;
            Draw.Circle(400, 150, 80);

            //Link body
            Draw.Rectangle(350, 230, 100, 130);
            Draw.Triangle(400, 200, 320, 360, 480, 360);

            //Link arms
            Draw.Quad(340, 220, 360, 230, 310, 290, 330, 300);
            Draw.Quad(460, 220, 440, 230, 490, 290, 470, 300);

            if (Input.IsKeyboardKeyDown(KeyboardInput.R)){


                    //Link hat
                    Draw.FillColor = Color.Red;
                    Draw.Circle(400, 150, 80);

                    //Link body
                    Draw.Rectangle(350, 230, 100, 130);
                    Draw.Triangle(400, 200, 320, 360, 480, 360);

                    //Link arms
                    Draw.Quad(340, 220, 360, 230, 310, 290, 330, 300);
                    Draw.Quad(460, 220, 440, 230, 490, 290, 470, 300);

                

            }
            else if (Input.IsKeyboardKeyDown(KeyboardInput.B)){

                //Link hat
                Draw.FillColor = Color.Blue;
                Draw.Circle(400, 150, 80);

                //Link body
                Draw.Rectangle(350, 230, 100, 130);
                Draw.Triangle(400, 200, 320, 360, 480, 360);

                //Link arms
                Draw.Quad(340, 220, 360, 230, 310, 290, 330, 300);
                Draw.Quad(460, 220, 440, 230, 490, 290, 470, 300);

            }
            else if (Input.IsKeyboardKeyDown(KeyboardInput.P)){

                //Link hat
                Draw.FillColor = purple;
                Draw.Circle(400, 150, 80);

                //Link body
                Draw.Rectangle(350, 230, 100, 130);
                Draw.Triangle(400, 200, 320, 360, 480, 360);

                //Link arms
                Draw.Quad(340, 220, 360, 230, 310, 290, 330, 300);
                Draw.Quad(460, 220, 440, 230, 490, 290, 470, 300);

            }
          
             

            //Link belt
            Draw.FillColor = brown;
            Draw.Rectangle(350, 280, 100, 20);
            Draw.FillColor = Color.Yellow;
            Draw.Circle(400, 290, 15);

            //Link hands
            Draw.FillColor = tan;
            Draw.Circle(315, 300, 15);
            Draw.Circle(485, 300, 15);

            //Link shoes
            Draw.FillColor = brown;
            Draw.Triangle(380, 360, 380, 380, 340, 380);
            Draw.Triangle(420, 360, 420, 380, 460, 380);

            //Link head
            Draw.FillColor = tan;
            Draw.Ellipse(400, 180, 150, 130);
            //Link ears
            Draw.Triangle(480, 190, 470, 160, 530, 130);
            Draw.Triangle(320, 190, 330, 160, 270, 130);

            //Link eyes
            //Left Eye
            Draw.FillColor = Color.White;
            Draw.Triangle(350, 170, 350, 200, 390, 200);
            Draw.FillColor = Color.Black;
            Draw.Ellipse(365, 190, 10, 20);
            //Right Eye
            Draw.FillColor = Color.White;
            Draw.Triangle(450, 170, 450, 200, 410, 200);
            Draw.FillColor = Color.Black;
            Draw.Ellipse(435, 190, 10, 20);

            //Link Hair
            Draw.FillColor = Color.Yellow;
            Draw.Triangle(440, 120, 370, 110, 340, 170);
            Draw.Triangle(380, 115, 320, 130, 330, 175);
            Draw.Triangle(320, 130, 335, 145, 320, 220);
            Draw.Quad(435, 120, 430, 130, 485, 150, 475, 170);
            Draw.Quad(485, 150, 470, 150, 485, 200, 470, 200);
        }
    }

}
