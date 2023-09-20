using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveArm : MonoBehaviour
{
    //ref for my rigidbody that is on my arm
    Rigidbody2D myBody;

    //ref for the sound manager script (that i wrote) which is on my arm
    SoundManager mySoundManager;

    //how strongly I want to push up my arm
    float armPower = 200f;

    Vector3 leftArmMove = new Vector3(-1, 0, 0);

    // Start is called before the first frame update
    void Start()
    {
        //set the references
        //just "GetComponent" by itself can access any component on the gameobject this script is on
        myBody = GetComponent<Rigidbody2D>();
        mySoundManager = GetComponent<SoundManager>();
    }

    // Update is called once per frame
    void Update()
    {
        //if i press the A key
        if(Input.GetKeyDown(KeyCode.A))
        {
            //play the ding sound
            mySoundManager.myAudioSource.PlayOneShot(mySoundManager.armSound);
            //and push up my arm
            //NOTE: the one i did in class I used transform.up - this looked weird!
            //instead, i'm just directly saying "add the force to the left with the vector (-1,0,0)
            myBody.AddForce(leftArmMove * armPower, ForceMode2D.Impulse);
        }
    }
}
