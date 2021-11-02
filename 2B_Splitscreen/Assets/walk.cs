using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walk : MonoBehaviour
{
    // You can change players' speed from the GUI.
    [SerializeField]
    float speed = 0.2f;

    // The players will be able to move only within the following boundaries:
    float player1leftBound = -10.0f;
    float player1rightBound = 5.9f;
    float player2leftBound = -7.8f;
    float player2rightBound = 8.0f;
    void Start()
    {
        
    }

    void FixedUpdate()
    {
        // We got each player's Transform component to change his position.
        // For each player we used different keys to move with.
        // With the Min/Max functions we made sure the players will stay within the boundaries of the background.

        // Player1 - can move with 'A' or 'D' :
        Transform t1 = GameObject.FindGameObjectWithTag("Player1").transform;
        if (Input.GetKey(KeyCode.D))
        {
            t1.position = new Vector3(Mathf.Min(player1rightBound, t1.position.x + speed), t1.position.y, t1.position.z);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            t1.position = new Vector3(Mathf.Max(player1leftBound, t1.position.x - speed), t1.position.y, t1.position.z);
        }

        // Player2 - can move with 'Left Arrow' or 'Right Arrow' :
        Transform t2 = GameObject.FindGameObjectWithTag("Player2").transform;
        if (Input.GetKey(KeyCode.RightArrow))
        {
            t2.position = new Vector3(Mathf.Min(player2rightBound, t2.position.x + speed), t2.position.y, t2.position.z);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            t2.position = new Vector3(Mathf.Max(player2leftBound, t2.position.x - speed), t2.position.y, t2.position.z);
        }
    }
}
