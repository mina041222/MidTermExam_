using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public Vector2 startposition;
    public float ballSpeed;
    public Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        startposition = transform.position;
        float ballSpeed = 
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(ballSpeed * Time.deltatime);
    }
}
