using System;
using System.Collections.Generic;
using System.Threading;

// Base Activity
abstract class Activity
{
    protected int duration;

    public Activity(int duration)
    {
        this.duration = duration;
    }

    public void Run()
    {
        DisplayStartingMessage();
        PrepareToBegin();
        PerformActivity();
        DisplayEndingMessage();
    }

    protected virtual void DisplayStartingMessage()
    {
        Console.WriteLine("Welcome to the " + GetType().Name + " Activity!");
        Console.WriteLine(GetDescription());
        Console.WriteLine("Please set the duration of the activity in seconds: " + duration);
        Console.WriteLine("Prepare to begin...");
        Thread.Sleep(3000); // Pause for 3 seconds
    }

    protected virtual void PrepareToBegin()
    {
        // Optional method to be overridden by subclasses
    }

    protected abstract void PerformActivity();

    protected virtual void DisplayEndingMessage()
    {
        Console.WriteLine("Good job! You have completed the " + GetType().Name + " Activity.");
        Console.WriteLine("Activity duration: " + duration + " seconds");
        Thread.Sleep(3000); // Pause for 3 seconds
    }

    protected abstract string GetDescription();
}

    
