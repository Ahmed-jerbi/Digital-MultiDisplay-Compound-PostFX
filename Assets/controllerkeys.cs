/*
Simple script for moving an object along the X (sides) and Z (forward) directions with the arrow keys + Rotate with Mouse Axis
- Horizontal  : X axis : left/right 
- Vertical    : Z axis : forward/back
This script is ideal for camera controlling
*/

using UnityEngine;
using System.Collections;

public class controllerkeys : MonoBehaviour
{

    public int moveSpeed = 1;
    public int rotSpeed = 1;
    private float yaw = 0.0f;
    private float pitch = 0.0f;

    void Update()
    {
        // Translation along X and Z
        transform.Translate(moveSpeed * Input.GetAxis("Horizontal") * Time.deltaTime, 0f, moveSpeed * Input.GetAxis("Vertical") * Time.deltaTime);

        //Rotation around X and Y
        yaw += rotSpeed * Input.GetAxis("Mouse X");
        pitch -= rotSpeed * Input.GetAxis("Mouse Y");
        transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);

    }

}