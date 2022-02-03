using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class player : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 20;

    private Rigidbody rb;

    private float movementX;
    private float movementY;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

   

    private void FixedUpdate()
    {
        float HorizontalMovement = Input.GetAxis("Horizontal");
        float VerticalMovement = Input.GetAxis("Vertical");

        
        Vector3 movement = new Vector3(HorizontalMovement, 0.0f, VerticalMovement);

        rb.AddForce(movement * speed);
    }
}
