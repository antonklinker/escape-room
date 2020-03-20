using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Distance : MonoBehaviour
{

    public GameObject Player, Object;

    public static float distance;
    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {

        distance = Vector3.Distance(Player.transform.position, Object.transform.position);
        
        
    }
}
