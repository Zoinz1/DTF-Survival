using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{

    public float cameraPanSpeed = 10f;
    public Transform heroModel;
    private bool followHero = false;

    // Update is called once per frame
    void Update()
    {
        //Forward
        if (Input.GetKey("up")){
            transform.position += new Vector3(0, 0, cameraPanSpeed * Time.deltaTime);
        }
        //Backward
        if (Input.GetKey("down"))
        {
            transform.position += new Vector3(0, 0, -cameraPanSpeed * Time.deltaTime);
        }
        //Left
        if (Input.GetKey("left"))
        {
            transform.position += new Vector3(-cameraPanSpeed * Time.deltaTime, 0, 0);
        }
        //Right
        if (Input.GetKey("right"))
        {
            transform.position += new Vector3(cameraPanSpeed * Time.deltaTime, 0, 0);
        }
        //Center camera at hero/player
        if (Input.GetKey(KeyCode.Space) || followHero)
        {
            transform.position = heroModel.position + new Vector3(0, 15, -10);
        }

        //Changes the setting for camera to follow the hero.
        if (Input.GetKeyDown(KeyCode.Y))
        {
            followHero = !followHero;
        }
		
		
		//TODO: Pan camera at edges of game

    }
}
