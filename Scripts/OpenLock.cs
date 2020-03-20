using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;



public class OpenLock : MonoBehaviour
{



    public static event Action<string, int> Rotated = delegate { };

    private bool open;

    // Start is called before the first frame update
    void Start()
    {
        open = false; // tells the program that the lock is closed

    }

    void Update()
    {
        if (LockControl.guessPass) // if the correct combination is entered, open the lock and set the correct password back to false
        {
            LockControl.guessPass = false;
            StartCoroutine("Open");
        }

        if (open) // if the lock is open, call this function described further below
        {
            StartCoroutine("Close");
        }
        
    }

    private IEnumerator Open() // this will open the lock in a realistic manner
    {
        for (int i = 0; i <= 45; i++)
        {
            transform.Rotate(0f, 0f, 2f);
            yield return new WaitForSeconds(0.01f);
            
        }
        open = true;
    }

    private IEnumerator Close() // this will wait 5 seconds before closing the lock again
    {
        open = false;
        
        yield return new WaitForSeconds(5f);
        Debug.Log("The lock will now close again");

        for (int i = 0; i <= 45; i++)
        {
            transform.Rotate(0f, 0f, -2f);
            yield return new WaitForSeconds(0.01f);
        }
    }
}