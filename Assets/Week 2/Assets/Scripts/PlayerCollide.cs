using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerCollide : MonoBehaviour
{

    bool haveWand = false;

    public TMP_Text speechUI;

    public string chickenDialogue;
    public GameObject textObject;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collided with " + collision.gameObject.name);
        if (collision.gameObject.name == "Chicken")
        {
            textObject.SetActive(true);
            speechUI.text = chickenDialogue;
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Overlapped with " + collision.gameObject.name);
        if(collision.gameObject.name == "Wand")
        {
            haveWand = true;
            Destroy(collision.gameObject);
        }
    }

}
