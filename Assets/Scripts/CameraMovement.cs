using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    private bool followHero = false;
    public Transform heroModel;
    public float cameraPanSpeed = 10f;
    public float edgeSize = 10f;

    // Update is called once per frame
    void Update()
    {
        //Forward
        if ((Input.GetKey("up") || Input.mousePosition.y > Screen.height - edgeSize) && !followHero){
            transform.position += new Vector3(0, 0, cameraPanSpeed * Time.deltaTime);
        }
        //Backward
        if ((Input.GetKey("down") || Input.mousePosition.y < edgeSize)  && !followHero)
        {
            transform.position += new Vector3(0, 0, -cameraPanSpeed * Time.deltaTime);
        }
        //Left
        if ((Input.GetKey("left") || Input.mousePosition.x < edgeSize) && !followHero)
        {
            transform.position += new Vector3(-cameraPanSpeed * Time.deltaTime, 0, 0);
        }
        //Right
        if ((Input.GetKey("right") || Input.mousePosition.x > Screen.width - edgeSize) && !followHero)
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

        //TODO: Add camera zooming

    }
}
