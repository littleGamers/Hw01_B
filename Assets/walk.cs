using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walk : MonoBehaviour
{
    // You can change the player's speed from the GUI.
    [SerializeField]
    float speed = 0.5f;

    // The player will stay within the following boundaries:
    float rightBorder = 9.6f;
    float leftBorder = -8f;
    float upBorder = 3.7f;
    float downBorder = -3.2f;
    void Start()
    {
        
    }
    
    void FixedUpdate()
    {
        float x = transform.position.x;
        float y = transform.position.y;
        float z = transform.position.z;

        // For every arrow key pressed, we add 'speed' value the appropriate direction in the X or Y axis.
        // With Min/Max functions and borders we made sure the player stay within the boundaries.
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position = new Vector3(Mathf.Min(x + speed, rightBorder), y, z); 
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position = new Vector3(Mathf.Max(x - speed, leftBorder), y, z);
        }
        else if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position = new Vector3(x, Mathf.Min(y + speed, upBorder) , z);
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position = new Vector3(x, Mathf.Max(y - speed, downBorder), z);
        }
    }
}
