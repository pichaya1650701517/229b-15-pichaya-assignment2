using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MoveMB : MonoBehaviour
{
 
    public float force;

    private void Update()
    {
        MoveByKey();
    }
    public void MoveByKey()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        if (Input.GetKey(KeyCode.A))
            rb.AddForce(Vector3.left*force);
        if (Input.GetKey(KeyCode.D))
            rb.AddForce(Vector3.right*force);
        if (Input.GetKey(KeyCode.W))
            rb.AddForce(Vector3.forward*force);
        if (Input.GetKey(KeyCode.S))
            rb.AddForce(Vector3.back*force);
    }
}