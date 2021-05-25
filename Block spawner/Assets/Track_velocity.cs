using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Track_velocity : MonoBehaviour
{
    public Vector3 velocity;
    private Vector3 prevPosition;
    // Start is called before the first frame update
    void Start()
    {
        prevPosition = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        velocity = this.transform.position - prevPosition;
        prevPosition = this.transform.position;
    }
}
