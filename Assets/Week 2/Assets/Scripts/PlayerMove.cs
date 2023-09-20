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
        Vector3 newPos = transform.position;

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

        transform.position = newPos;
    }
}
