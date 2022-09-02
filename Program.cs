﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace First_lesson
{
    internal class Program
    {
        static int waitTime = 1000;

        static async Task Main(string[] args)
        {
            string hi = "Hello";
            string aFriend = "Bill";
            string bFriend = "Sage";

            writeDelay(hi + " World!");
            await Task.Delay(waitTime);
            Console.Clear();

            writeDelay(hi + $" {aFriend}!");
            await Task.Delay(waitTime);
            Console.Clear();

            aFriend = "Maira";
            writeDelay(hi + $" {aFriend}!");
            await Task.Delay(waitTime);
            Console.Clear();

            writeDelay($"My friends are  {aFriend} and {bFriend}");
            await Task.Delay(waitTime);
            Console.Clear();

            writeDelay($"The name {aFriend} has {aFriend.Length} letters.");
            await Task.Delay(waitTime);
            Console.Clear();

            writeDelay($"The name {bFriend} has {bFriend.Length} letters.");
            await Task.Delay(waitTime);
            Console.Clear();

        }
        private static void writeDelay(string text) 
        {
            foreach (char c in text)
            {
                Console.Write(c);
                Thread.Sleep(100);
            }
        }
       
    }
    
}
