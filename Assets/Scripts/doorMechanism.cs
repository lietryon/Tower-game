using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorMechanism : MonoBehaviour
{
    public static bool door_Open = false;
    Animator Door_0;
    // Start is called before the first frame update
    void Start()
    {
        Door_0 = gameObject.GetComponent<Animator>();                
    }

    // Update is called once per frame
    void Update()
    {
        if (door_Open)
        {
            Door_0.SetBool("door_Open", true);
        }        
    }
}
