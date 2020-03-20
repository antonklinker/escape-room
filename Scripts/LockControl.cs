using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class LockControl : MonoBehaviour

{

   
    private int[] result, correctCombination;

    public static bool guessPass;

    

    private void Start()
    {

        



        guessPass = false; // correct combination isn't guessed
        result = new int[] { 5, 5, 5 }; // what the wheels are currently set at
        correctCombination = new int[] {4,2,0};
        
        rotate.Rotated += CheckResults;

       

        

        
        
    }

    private void Update()
    {
        correctCombination = GenerateCode.passWord;
    }

    

    
    private void CheckResults(string wheelName, int number) // this checks if the wheels are at the correct position / if the combination is correct
    {
        switch (wheelName)
        {
            case "wheel1":
                result[2] = number;
                break;

            case "wheel2":
                result[1] = number;
                break;

            case "wheel3":
                result[0] = number;
                break;
        }
        if (result[0] == correctCombination[0] && result[1] == correctCombination[1] && result[2] == correctCombination[2]) { // if everything is correct, set guessPass to true and print "Opened!"
            Debug.Log("Opened!");
           
            guessPass = true; // this is passed on to OpenLock
        }

    }

    private void OnDestroy()
    {
        rotate.Rotated -= CheckResults;
    }
}
