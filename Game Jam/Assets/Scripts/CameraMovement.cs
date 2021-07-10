using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public new Rigidbody2D rigidbody;
    public int speed;

    void Update()
    {
        if (Input.mousePosition.x <= 10)
        {
            rigidbody.velocity = new Vector2(-speed, 0);
        } 
        else if (Input.mousePosition.x >= Camera.main.pixelWidth - 10)
        {
            rigidbody.velocity = new Vector2(speed, 0);
        }
        else if (Input.mousePosition.y <= 10)
        {
            rigidbody.velocity = new Vector2(0, -speed);
        }
        else if (Input.mousePosition.y >= Camera.main.pixelHeight - 10)
        {
            rigidbody.velocity = new Vector2(0, speed);
        } 
        else
        {
            rigidbody.velocity = Vector2.zero;
        }

        if (Input.mouseScrollDelta != Vector2.zero)
        {
            float scroll = Input.mouseScrollDelta.y;
            if(scroll < 0 && Camera.main.orthographicSize > 2)
            {
                Camera.main.orthographicSize += scroll;
            }
            else if (scroll > 0 && Camera.main.orthographicSize < 20)
            {
                Camera.main.orthographicSize += scroll;
            }
        }
    }
}
