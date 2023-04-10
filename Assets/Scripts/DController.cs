using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DController : MonoBehaviour
{
    private Rigidbody[] rb_AR;

    void Start()
    {
        rb_AR = GetComponentsInChildren<Rigidbody>();
        foreach(Rigidbody rb in rb_AR)
        {
            rb.isKinematic = true;
        }
    }
    

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.D)) Ragdoll_ON();
    }

    void Ragdoll_ON()
    {
        foreach(Rigidbody rb in rb_AR) rb.isKinematic = false;
        GetComponent<Animator>().enabled = false;
    }
}
