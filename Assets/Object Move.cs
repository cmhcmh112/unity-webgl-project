using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMove : MonoBehaviour


{
    public Transform targetObject;
    public float moveSpeed = 2.0f; 

    void Update()
    {
        
        float yInput = Input.GetAxis("Vertical");  
        float xInput = Input.GetAxis("Horizontal"); 
        
        Vector3 moveDirection = new Vector3(xInput, yInput, 0) * moveSpeed * Time.deltaTime;

        targetObject.position += moveDirection;

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
}
