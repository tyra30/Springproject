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
            Raylib.InitWindow(screenWidth, screenHeight, "Namnet pa ditt project");
            Raylib.SetTargetFPS(60);

            string gamestate = "game";

            Rectangle startButton = new Rectangle(900, 350, 90, 30);


            while (!Raylib.WindowShouldClose())
            {
                if (gamestate == "game")
                {
                    //LOGIK
                    if (Raylib.CheckCollisionPointRec(Raylib.GetMousePosition(), startButton) && Raylib.IsMouseButtonPressed(MouseButton.MOUSE_LEFT_BUTTON))
                    {
                        gamestate = "level1";
                    }
                    //DRAW
                    Raylib.BeginDrawing();
                    Raylib.ClearBackground(Color.WHITE);

                    Raylib.DrawRectangleRec(startButton, Color.PINK);
                    Raylib.DrawText("5000 IQ TEST", 250, 150, 200, Color.BLACK);
                    Raylib.DrawText("Press PLAY to begin", 800, 350, 30, Color.BLACK);
                    Raylib.DrawText("PLAY", 1000, 680, 130, Color.MAGENTA);
                    Raylib.DrawText("PLAY", 100, 600, 100, Color.BLUE);
                    Raylib.DrawText("PLAY", 500, 800, 80, Color.GREEN);
                    Raylib.DrawText("PLAY", 800, 500, 90, Color.RED);
                    Raylib.DrawText("PLAY", 1600, 650, 110, Color.YELLOW);

                    Raylib.EndDrawing();
                }

                else if (gamestate == "level1")
                {
                    Raylib.BeginDrawing();
                    Raylib.ClearBackground(Color.WHITE);
                    Raylib.EndDrawing();
                }
            }
        }
    }
}
