using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementBehaviour : MonoBehaviour
{
    //The player speed
    public float speed;

    //the axis the player is moving on
    private Vector3 moveAxis;

    private void Start()
    {
        moveAxis = new Vector3(1, 0, 0);
    }
    // Update is called once per frame
    void Update()
    {
        //Checks to see if the button to go right has been pressed.
        if (Input.GetAxisRaw("Horizontal") == 1)
        {
            //If the button has been pressed add the moveAxis mulitplied by the speed to the position of the game object.
            transform.position += moveAxis* speed * Time.deltaTime;
        }
        //Checks to see if the button to go left has been pressed.
        else if (Input.GetAxisRaw("Horizontal") == -1)
        {
            //If the button was pressed add the moveAxis mulitplied by the speed to the position of the game object.
            transform.position -= moveAxis * speed * Time.deltaTime;
        }
    }
}
