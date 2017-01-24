/* NumberWizards.cs
 * Author: Paige Peck, with help from Udemy Course " "
 * Description: A simple scipt that runs in the Unity Console to 
 *              have the player's number guessed by the computer
 * Date Created: Dec 18, 2016
 * Last Modified: Dec 19, 2016
 */

using UnityEngine;
using System.Collections;

public class NumberWizards : MonoBehaviour {

    // Use this for initialization
    int max, min, guess;
    bool numbersChosen = false, minBuild = true;
    char[] minimum, maximum;

    void Start () {
        StartGame();
    }

    void StartGame()
    {
        print("===================================");
        print("Welcome to Number Wizard");

        max = 1000;
        min = 1;
        guess = Random.Range(min, max);
        
        print("Pick a number in your head, but don't tell me.");

        print("The range of numbers is between " + min + " and " + max + ".");

        print("Is the number higher or lower than " + guess + "?");
        print("Click in scene to interact with game");
        print("Up arrow for higher, down arrow for lower, return for equals.");

        max = max + 1; //To allow rounding up to 1000
    }
	
	// Update is called once per frame
	void Update () {
        if (numbersChosen)
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                min = guess;
                NextGuess();
            }
            else if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                max = guess;
                NextGuess();
            }
            else if (Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.KeypadEnter))
            {
                print("I won!");
                numbersChosen = false;
                StartGame();
            }
        }
        else
        {
            if(Input.GetKeyDown(KeyCode.Alpha0) || Input.GetKeyDown(KeyCode.Keypad0))
            {
                SetRange("0");
            }
            else if(Input.GetKeyDown(KeyCode.Alpha1) || Input.GetKeyDown(KeyCode.Keypad1))
            {
                SetRange("1");
            }
            else if (Input.GetKeyDown(KeyCode.Alpha2) || Input.GetKeyDown(KeyCode.Keypad2))
            {
                SetRange("2");
            }
            else if (Input.GetKeyDown(KeyCode.Alpha3) || Input.GetKeyDown(KeyCode.Keypad3))
            {
                SetRange("3");
            }
            else if (Input.GetKeyDown(KeyCode.Alpha4) || Input.GetKeyDown(KeyCode.Keypad4))
            {
                SetRange("4");
            }
            else if (Input.GetKeyDown(KeyCode.Alpha5) || Input.GetKeyDown(KeyCode.Keypad5))
            {
                SetRange("5");
            }
            else if (Input.GetKeyDown(KeyCode.Alpha6) || Input.GetKeyDown(KeyCode.Keypad6))
            {
                SetRange("6");
            }
            else if (Input.GetKeyDown(KeyCode.Alpha7) || Input.GetKeyDown(KeyCode.Keypad7))
            {
                SetRange("7");
            }
            else if (Input.GetKeyDown(KeyCode.Alpha8) || Input.GetKeyDown(KeyCode.Keypad8))
            {
                SetRange("8");
            }
            else if (Input.GetKeyDown(KeyCode.Alpha9) || Input.GetKeyDown(KeyCode.Keypad9))
            {
                SetRange("9");
            }
            else if (Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.KeypadEnter))
            {
                SetRange("next");
            }
        }
    }

    void NextGuess()
    {
        guess = (max + min) / 2;
        print("Higher or lower than " + guess + "?");
        print("Up arrow for higher, down arrow for lower, return for equals.");
    }

    void SetRange(string a)
    {
        if(a.CompareTo("new") != 0)
            if (minBuild)
            {
                print("Minimum = " + a);
            }
            else
            {
                print("Maximum = " + a);
            }
        else
        {
            print("move to next");
            if (minBuild)
            {
                print("Build Max");
                minBuild = false;
            }
            else
            {
                print("Begin Game");
                numbersChosen = true;
            }
        }
    }
}
