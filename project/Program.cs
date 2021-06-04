using System;
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


            while (!Raylib.WindowShouldClose())
            {
                if (gamestate == "level1")
                {
                    //LOGIK
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

                    if (appleIsReal && apple.y < 600)
                    {
                        apple.y += 3;
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





                    if (appleIsReal)
                    {
                        Raylib.DrawRectangleRec(apple, Color.RED);
                    }


                    Raylib.EndDrawing();
                }
            }
        }
    }
}
