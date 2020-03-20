using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class rotate : MonoBehaviour
{

    public static event Action<string, int> Rotated = delegate { };

    private bool coroutineAllowed;

    private int numberShown;

    
    void Start()
    {
        coroutineAllowed = true; // tells the program that we can click the wheels

        numberShown = 5; // this is the number the wheels are starting on in the game
        
    }


    private void OnMouseOver() // right click
    {
        if (Distance.distance < 3)
        {
            if (Input.GetMouseButtonDown(1))
            {
                if (coroutineAllowed) StartCoroutine("RotateWheelUp");


            }
        }
    }

    private void OnMouseDown() // left click
    {

        if (Distance.distance < 3)
        {


            if (coroutineAllowed)
            {
                StartCoroutine("RotateWheelDown");
            }
        }
        
    }

    private IEnumerator RotateWheelDown() 
    {
        coroutineAllowed = false; // makes the wheel unclickable while the rotation is happening

        for (int i = 0; i <= 11; i++) // this for loop makes the wheels rotation look realistic
        {
            transform.Rotate(0f, 0f, -3f);
            yield return new WaitForSeconds(0.01f);
        }

        coroutineAllowed = true; // makes the wheel clickable again

        numberShown += 1; // tells the program that the number we're seeing is the number that exists

        if (numberShown>9) // wraps around so the numbers can't exceed 9
        {
            numberShown = 0;
        }

        Rotated(name, numberShown);
    }


    private IEnumerator RotateWheelUp() // exactly the opposite of RotateWheelUp
    {
        coroutineAllowed = false;

        for (int i = 0; i <= 11; i++)
        {
            transform.Rotate(0f, 0f, 3f);
            yield return new WaitForSeconds(0.01f);
        }

        coroutineAllowed = true;

        numberShown -= 1;

        if (numberShown < 0)
        {
            numberShown = 9;
        }

        Rotated(name, numberShown);
    }
}
