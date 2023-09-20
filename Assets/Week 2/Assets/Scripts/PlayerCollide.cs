using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerCollide : MonoBehaviour
{
    //boolean to check if the player has triggered the wand
    bool haveWand = false;

    //public means that variable or function or class is accessible to other scripts
    //as an added bonus, it is also visible in the inspector

    //reference to the text component on our dialog
    public TMP_Text speechUI;

    //reference for what our chicken should say (set in the inspector)
    public string chickenDialogue;
    //reference to the object that has the text component on it
    public GameObject textObject;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //runs when a collision occurs, once, at the start
    void OnCollisionEnter2D(Collision2D collision)
    {
        //print the name of the thing we collided with to the console
        Debug.Log("Collided with " + collision.gameObject.name);
        //if that object was named "chicken"
        if (collision.gameObject.name == "Chicken")
        {
            //turn on the object that has the text component
            textObject.SetActive(true);
            //and set it's text to the chicken's dialog
            speechUI.text = chickenDialogue;
        }
    }

    //runs when some overlaps with this object, once, at the start of the overlap
    void OnTriggerEnter2D(Collider2D collision)
    {
        //name the thing we overlapped with
        Debug.Log("Overlapped with " + collision.gameObject.name);
        //if that object was named "wand"
        if(collision.gameObject.name == "Wand")
        {
            //change the haveWand boolean to true
            haveWand = true;
            //and destroy the wand
            Destroy(collision.gameObject);
        }
    }

}
