using UnityEngine;

public class CameraController : MonoBehaviour
{

    public GameObject player;//reference to the player GameObject
    private Vector3 offset;//distance between the camera and the player 
                           //offest is a variable of the CameraController class that contains a vector
                           //vector3 is a representation of 3d positions and directions 


    void Start()    // Start is called once before the first execution of Update after the MonoBehaviour is created
    {
        offset = transform.position - player.transform.position;//Calculate the initial offset between the camera's position and the player's position
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;//keep the same offset between the player and the camera throughout the game
    }
}
