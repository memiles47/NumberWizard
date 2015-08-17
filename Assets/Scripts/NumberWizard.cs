using UnityEngine;
using System.Collections;

public class NumberWizard : MonoBehaviour
{
    //Declaration and initialization of private variables
    int max;
    int min;
    int guess;

    // Use this for initialization
    void Start()
    {
        StartGame();
    }

    // Update is called every frame, if the MonoBehaviour is enabled
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            //print("Up arrow pressed");
            min = guess;
            NextGuess();
        }
        else if(Input.GetKeyDown(KeyCode.DownArrow))
        {
            //print("Down arrow pressed");
            max = guess;
            NextGuess();
        }
        else if(Input.GetKeyDown(KeyCode.Return))
        {
            print("I won!");
            StartGame();
        }
    }

    void StartGame()
    {
        max = 1000;
        min = 1;
        guess = 500;

        print("========================");
        print("Welcome to Number Wizard");
        print("Pick a number in your head but don't tell me.");

        print("The highest number you can pick is " + max);
        print("The lowest number you can pick is " + min);

        print("Is the number higher or lower than " + guess + "?");
        print("Press up arrow for higher, down for lower, return for equal");

        max += 1;
    }

    void NextGuess()
    {
        guess = (min + max) / 2;
        print("Higher or Lower than " + guess + "?");
        print("Press up arrow for higher, down for lower, return for equal");
    }

    void NewGame()
    {
        StartGame();
    }
}