using System;
using System.Collections.Generic;
using Raylib_cs;

namespace project
{
    class Program
    {
        static void Main(string[] args)
        {
            int screenWidth = 1920;
            int screenHeight = 1000;
            Raylib.InitWindow(screenWidth, screenHeight, "5000 IQ GAME");
            Raylib.SetTargetFPS(60);

            string gamestate = "level1";

            Rectangle startButton = new Rectangle(900, 350, 90, 30);

            Rectangle tree = new Rectangle(1230, 300, 400, 600);

            Rectangle apple = new Rectangle(1500, 350, 50, 50);

            bool appleIsReal = false;

            Rectangle answer2 = new Rectangle(360, 360, 50, 50);


            //KOMPONENTERNA I LISTEN
            List<Rectangle> rectangles = new List<Rectangle>();
            rectangles.Add(new Rectangle(10, 10, 20, 20));
            rectangles.Add(new Rectangle(20, 20, 20, 20));
            rectangles.Add(new Rectangle(30, 30, 20, 20));
            rectangles.Add(new Rectangle(40, 40, 20, 20));



            //VAD SOM HÄNDER NÄR VI ÄR INNE I SPELET
            while (!Raylib.WindowShouldClose())
            {
                if (gamestate == "level1")
                {
                    //LOGIK
                    //OM MAN KLICKAR PÅ startbutton SÅ BYTER VI TILL level2
                    if (Raylib.CheckCollisionPointRec(Raylib.GetMousePosition(), startButton) && Raylib.IsMouseButtonPressed(MouseButton.MOUSE_LEFT_BUTTON))
                    {
                        gamestate = "level2";
                    }
                    //DRAW
                    Raylib.BeginDrawing();
                    Raylib.ClearBackground(Color.WHITE);


                    Raylib.DrawRectangleRec(startButton, Color.WHITE);
                    Raylib.DrawText("5000 IQ TEST", 250, 150, 200, Color.BLACK);
                    Raylib.DrawText("Press PLAY to begin", 800, 350, 30, Color.BLACK);
                    Raylib.DrawText("PLAY", 1000, 680, 130, Color.MAGENTA);
                    Raylib.DrawText("PLAY", 100, 600, 100, Color.BLUE);
                    Raylib.DrawText("PLAY", 500, 800, 80, Color.GREEN);
                    Raylib.DrawText("PLAY", 800, 500, 90, Color.RED);
                    Raylib.DrawText("PLAY", 1600, 650, 110, Color.YELLOW);

                    Raylib.EndDrawing();
                }

                else if (gamestate == "level2")
                {
                    //LOGIK

                    if (Raylib.CheckCollisionPointRec(Raylib.GetMousePosition(), tree) && Raylib.IsMouseButtonPressed(MouseButton.MOUSE_LEFT_BUTTON))
                    {
                        appleIsReal = true;
                    }

                    if (Raylib.CheckCollisionPointRec(Raylib.GetMousePosition(), answer2) && Raylib.IsMouseButtonPressed(MouseButton.MOUSE_LEFT_BUTTON))
                    {
                        gamestate = "level3";
                    }


                    //DRAW
                    Raylib.BeginDrawing();
                    Raylib.ClearBackground(Color.WHITE);
                    Raylib.DrawRectangle(1400, 600, 60, 300, Color.BROWN);
                    Raylib.DrawCircle(1430, 500, 200, Color.DARKGREEN);
                    Raylib.DrawRectangle(1480, 320, 50, 50, Color.RED);
                    Raylib.DrawRectangle(1300, 370, 50, 50, Color.RED);
                    Raylib.DrawRectangle(1400, 420, 50, 50, Color.RED);
                    Raylib.DrawRectangle(1350, 580, 50, 50, Color.RED);

                    DrawKeypad();
                    Raylib.DrawText("How many apples are in the tree?", 120, 250, 30, Color.BLACK);

                    //APPLE FALLING
                    if (appleIsReal)
                    {
                        Raylib.DrawRectangleRec(apple, Color.RED);
                    }

                    if (appleIsReal && apple.y < 600)
                    {
                        apple.y += 3;
                    }
                    Raylib.EndDrawing();



                }
                else if (gamestate == "level3")
                {
                    Raylib.BeginDrawing();
                    Raylib.ClearBackground(Color.WHITE);


                    //VI GÅR FRÅN 0 OCH GÅR UPP ETT STEG VARJE GÅNG TILLS REKTANGLARNA I LISTAN TAR SLUT

                    for (int i = 0; i < rectangles.Count; i++)
                    {
                        Raylib.DrawRectangleRec(rectangles[i], Color.BLACK);

                    }

                    Raylib.EndDrawing();


                }

            }
        }


        //METOD FÖR ATT RITA UT KEYPAD
        private static void DrawKeypad()
        {
            Raylib.DrawRectangle(300, 300, 50, 50, Color.GRAY);
            Raylib.DrawRectangle(360, 300, 50, 50, Color.GRAY);
            Raylib.DrawRectangle(420, 300, 50, 50, Color.GRAY);
            Raylib.DrawRectangle(300, 360, 50, 50, Color.GRAY);
            Raylib.DrawRectangle(360, 360, 50, 50, Color.GRAY);
            Raylib.DrawRectangle(420, 360, 50, 50, Color.GRAY);
            Raylib.DrawRectangle(300, 420, 50, 50, Color.GRAY);
            Raylib.DrawRectangle(360, 420, 50, 50, Color.GRAY);
            Raylib.DrawRectangle(420, 420, 50, 50, Color.GRAY);
            Raylib.DrawRectangle(360, 480, 50, 50, Color.GRAY);
            Raylib.DrawText("1", 315, 300, 50, Color.BLACK);
            Raylib.DrawText("2", 375, 300, 50, Color.BLACK);
            Raylib.DrawText("3", 435, 300, 50, Color.BLACK);
            Raylib.DrawText("4", 315, 360, 50, Color.BLACK);
            Raylib.DrawText("5", 375, 360, 50, Color.BLACK);
            Raylib.DrawText("6", 435, 360, 50, Color.BLACK);
            Raylib.DrawText("7", 315, 420, 50, Color.BLACK);
            Raylib.DrawText("8", 375, 420, 50, Color.BLACK);
            Raylib.DrawText("9", 435, 420, 50, Color.BLACK);
            Raylib.DrawText("10", 365, 480, 50, Color.BLACK);
        }
    }
}
