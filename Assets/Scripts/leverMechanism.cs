using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leverMechanism : MonoBehaviour
{
    public bool leverOn = false;
    Animator Lever;


    void Start()
    {
        Lever = gameObject.GetComponent<Animator>();
    }
    
    void Update()
    {
        if (leverOn && Input.GetKeyDown(KeyCode.F))
        {
            Lever.SetBool("lever_On", true);
            doorMechanism.door_Open = true;
        }
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            leverOn = true;
        }
    }
}
