using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    float moveSpeed = 1f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //create a variable of the type Vector3 named newPos
        //set newPos to our current position
        Vector3 newPos = transform.position;

        //when the player presses an arrow key
        //set the x or y to change 
        if(Input.GetKey(KeyCode.UpArrow))
        {
            newPos.y += Time.deltaTime * moveSpeed;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            newPos.y -= Time.deltaTime * moveSpeed;
        }
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            newPos.x -= Time.deltaTime * moveSpeed;
        }
        if(Input.GetKey(KeyCode.RightArrow))
        {
            newPos.x += Time.deltaTime * moveSpeed;
        }

        //set our position to our new position
        transform.position = newPos;
    }
}
