using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundController : MonoBehaviour
{
    public float verticalBound;
    public float verticalSpeed;

    // Update is called once per frame
    void Update()
    {
        _Move();
        _CheckBounds();
    }

    private void _Reset()
    {
        this.transform.position = new Vector3(0, verticalBound);
    }
    private void _Move()
    {
        transform.position -= new Vector3(0, verticalSpeed);

    }

    private void _CheckBounds()
    {
        //if the background is lower than the bottom of the screen, then reset.
        if (transform.position.y <= -verticalBound) _Reset();

    }
}
