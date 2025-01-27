﻿using System;

namespace PaintballGun
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello in Paintball test app! \n");
            PGun simpleGun = new PGun(0,0,true);
            while (true)
            {
                Console.WriteLine($"{simpleGun.Balls} balls, {simpleGun.BallsLoaded} loaded");
                if (simpleGun.IsEmpty())
                {
                    Console.WriteLine("Space to shoot , r to reload, + to add ammo, q ti quit ");
                }
                char key = Console.ReadKey(true).KeyChar;
                if (key == ' ') Console.WriteLine($"Shooting returned {simpleGun.Shoot()}");
                else if (key == 'r') simpleGun.Reload();
                else if (key == '+') simpleGun.Balls += simpleGun.Magazine_Size;
                else if (key == 'q') return;
            }
        }
    }
}
