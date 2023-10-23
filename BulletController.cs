using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{

    public float speed = 10.0f;
    public float maxDistance = 10.0f;
    public float fuerzaEmpuje = 500.0f;
    private Vector3 initalPosition;
    // Start is called before the first frame update
    void Start()
    {
        initalPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        if (Vector3.Distance(initalPosition, transform.position) > maxDistance)
        {
            Destroy(gameObject);
        }
    }
   void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
            Debug.Log("Colisiono1");
        }
        
    }
}
