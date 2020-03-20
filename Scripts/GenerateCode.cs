using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GenerateCode : MonoBehaviour
{

    private double yPosition = 4.135;

    public static int[] passWord = new int[3];

    public static float distance;

    public GameObject Player, Object;



    void Update()
    {
        distance = Vector3.Distance(Player.transform.position, Object.transform.position);
    }



    private void OnMouseDown()
    {
        if (distance < 3) { 
        StartCoroutine("ButtonPushed");
    }
}

    private IEnumerator ButtonPushed()
    {
        for (int i = 0; i <= 11; i++) // this for loop makes the button push look realistic
        {
            yPosition = yPosition - 0.005;
            transform.position = new Vector3(-48.89f, (float)yPosition, 53.607f);
            yield return new WaitForSeconds(0.01f);
        }

        for (int i = 0; i <= 11; i++) // this for loop makes the button push look realistic
        {
            yPosition = yPosition + 0.005;
            transform.position = new Vector3(-48.89f, (float)yPosition, 53.607f);
            yield return new WaitForSeconds(0.01f);
        }

        for (int i = 0; i < passWord.Length; i++)
        {
            passWord[i] = UnityEngine.Random.Range(0, 9);
        }
        Debug.Log(String.Join("", passWord));
    }
}
