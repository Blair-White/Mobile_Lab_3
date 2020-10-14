using System.Collections;
using System.Collections.Generic;
using System.Security.AccessControl;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D rigidBody;
    public float horizontalBound, verticalBound, hSpeed, maxSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _Move();
        _CheckBounds();
    }

    private void _Move()
    {
        float direction = 0.0f;

        if(Input.GetAxis("Horizontal") >= 0.1f)
        {
            // dir = right
            direction = 1.0f;

        }

        if(Input.GetAxis("Horizontal") <= -0.1f)
        {
            //dir = left
            direction = -1.0f;
        }

        var newVelocity = rigidBody.velocity + new Vector2(direction * hSpeed, 0.0f);
        rigidBody.velocity = Vector2.ClampMagnitude(newVelocity, maxSpeed);

    }

    private void _CheckBounds()
    {
        //CheckRightBounds
        if (transform.position.x >= horizontalBound)
        {
            transform.position = new Vector3(horizontalBound, transform.position.y, 0.0f);
        }
        //Check LeftBounds
        if (transform.position.x <= -horizontalBound)
        {
            transform.position = new Vector3(-horizontalBound, transform.position.y, 0.0f);
        }
    }
}
