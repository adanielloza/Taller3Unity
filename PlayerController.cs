using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5.0f; // Adjust the speed as needed
    public Rigidbody rb;
    public GameObject bulletPrefab;
    public Transform cannnonTransform;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        // Get input from the keyboard
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // Calculate the movement vector
        Vector3 movement = new Vector3(horizontalInput, 0, verticalInput);

        // Apply the movement to the rigidbody
        rb.velocity = movement * moveSpeed;

        if (Input.GetButtonDown("Fire1"))
        {
            FireBullet();
        }

        void FireBullet()
        {
            if(bulletPrefab != null && cannnonTransform != null)
            {
                GameObject bullet = Instantiate(bulletPrefab, cannnonTransform.position, cannnonTransform.rotation);
                
            }
        }
    }
}

