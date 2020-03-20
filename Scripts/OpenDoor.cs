using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{

    public GameObject door;

    private bool coroutineAllowed;

    

    public static float distance;

    public GameObject Player, Object;


    // Start is called before the first frame update
    void Start()
    {
        coroutineAllowed = true;
        
    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector3.Distance(Player.transform.position, Object.transform.position);
    }

    private void OnMouseDown() // left click
    {




        if (distance < 5)
        {

            if (coroutineAllowed)
            {
                coroutineAllowed = false;
                StartCoroutine("OpeningDoor");
            }
        }
        

    }

    private IEnumerator OpeningDoor()
    {

        for (int i = 0; i <= 91; i++)
        {
            door.transform.Rotate(0f, -1f, 0f);
            yield return new WaitForSeconds(0.01f);
        }

        yield return new WaitForSeconds(5f);

        for (int i = 0; i <= 91; i++)
        {
            door.transform.Rotate(0f, 1f, 0f);
            yield return new WaitForSeconds(0.01f);
        }
        yield return new WaitForSeconds(0.5f);
        coroutineAllowed = true;

    }
}
