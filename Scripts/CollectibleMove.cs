using UnityEngine;

public class CollectibleMove : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created


    // Update is called once per frame
    void Update()//runs every frame in the game (EX: 60 frames per second - Update() runs 60 times)
    {
        transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);
        //transform is a class (or struct), rotate is a public method of the transform class 
        // new Vector3 creates a new vector w/ x, y, z components
        //time is a class (struct), deltaTime is a static property that represents The interval in seconds from the last frame to the current one
        //this method (function) rotates vector 3 as the time in seconds changes 
         
    }
}
