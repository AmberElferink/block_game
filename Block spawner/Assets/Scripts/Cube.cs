using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public float speed = 5.0f;
    public Rigidbody rb;
    private AudioSource source;

    // Start is called before the first frame update
    void Start()
    {
        //give cube the 'cube' tag

        gameObject.tag = "Cube";

        //add velocity to block in direction of the camera
        Vector3 cameraPos   = Camera.main.transform.position;
        Vector3 cubePos = this.transform.position;
        Vector3 velDirection = (cubePos - cameraPos).normalized;
        rb = GetComponent<Rigidbody>();
        // Debug.Log("hello there");

        rb.velocity = -speed*velDirection;

        source = this.GetComponent<AudioSource>();
        
    }

    // Update is called once per frame
    void Update()
    {
        //destroy block if clicked on
        // if (Input.GetMouseButtonDown(0))
        // {
        //     Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        //     RaycastHit hit;
        //     if (Physics.Raycast(ray, out hit, 100.0f) && hit.transform.gameObject != null)
        //     {
        //         // here you need to insert a check if the object is really a Cube
        //         // for example by tagging all cubes with "Cube" and checking hit.transform.tag
        //         if (hit.transform.tag == "Cube")
        //         {    // play sound
        //             source.Play();
        //             Debug.Log("hit");
        //             GameObject.Destroy(hit.transform.gameObject);
        //         }
        //     }
        // }

        //destroy block when it moves behind the camera
        if (this.transform.position.x > 1)
            Destroy(this.gameObject);
        
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Sword")
        {
            Vector3 swordVelocity = collision.gameObject.GetComponent<Track_velocity>().velocity;

            if(swordVelocity.magnitude >= 0.1)
            {
                collision.gameObject.GetComponent<AudioSource>().Play();
                Destroy(this.gameObject);
            }
        }

    }
}