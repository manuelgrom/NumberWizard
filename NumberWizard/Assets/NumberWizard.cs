using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    private float _guess = 0.0f;
    private int _maxNumber = 1000;
    private int _minNumber = 1;
    private float _rndNumber = 1.0f;

    private void Awake()
    {
        _rndNumber = Random.Range(_minNumber, _maxNumber);
        _guess = _rndNumber;
    }

    // Use this for initialization
    void Start()
    {
        StartGame();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            //print("Down arrow was pressed");
            _maxNumber = (int)_guess;
            NextGuess();

        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            //print("Up arrow was pressed");
            _minNumber = (int)_guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            print("I won!");
            StartGame(); // restarts the game 
        }
    }

    private void StartGame()
    {
        _maxNumber = 1000;
        _minNumber = 1;
        //guess number needs to be reset
        _maxNumber += 1; // if 1000 is guessed it can be displayed
        print("===================");
        print("Think of a number");
        print("The maximum number can be " + _maxNumber);
        print("The minimum number can be " + _minNumber);
        print("is your number " + _guess + " ?");
        print("up key for higher, down key for lower");
    }

    private void NextGuess()
    {
        _guess = (_maxNumber + _minNumber) / 2;
        print("Higher or Lower then " + _guess + " ?");
        print("UP key for higher, DOWN key for lower");
    }
}
