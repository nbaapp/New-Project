using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public Rigidbody2D rb;
    private float speedX = 0;
    private float speedY = 0;
    public float maxSpeed = 10;
    public float acceleration = 10;
    public float deceleration = 10;
    public float maxHeight = 37.2f;
    public float minHeight = -36.6f;
    public float maxRight = 79.6f;
    public float minLeft = -78.9f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //x axis movement
        if(Input.GetKey("d") && speedX < maxSpeed && transform.position.x < maxRight)
        {
            speedX = speedX + acceleration * Time.deltaTime;
        }
        else if (Input.GetKey("a") && speedX > -maxSpeed && transform.position.x > minLeft)
        {
            speedX = speedX - acceleration * Time.deltaTime;
        }
        else
        {
            if (speedX > deceleration * Time.deltaTime)
            {
                speedX = speedX - deceleration * Time.deltaTime;
            }
            else if (speedX < -deceleration * Time.deltaTime)
            {
                speedX = speedX + deceleration * Time.deltaTime;
            }
            else
            {
                speedX = 0;
            }
        }

        //y axis movement
        if (Input.GetKey("w") && speedY < maxSpeed && transform.position.y < maxHeight)
        {
            speedY = speedY + acceleration * Time.deltaTime;
        }
        else if (Input.GetKey("s") && speedY > -maxSpeed && transform.position.y > minHeight)
        {
            speedY = speedY - acceleration * Time.deltaTime;
        }
        else
        {
            if (speedY > deceleration * Time.deltaTime)
            {
                speedY = speedY - deceleration * Time.deltaTime;
            }
            else if (speedY < -deceleration * Time.deltaTime)
            {
                speedY = speedY + deceleration * Time.deltaTime;
            }
            else
            {
                speedY = 0;
            }
        }

        transform.position += new Vector3(speedX, speedY, 0) * Time.deltaTime;
    }
}
