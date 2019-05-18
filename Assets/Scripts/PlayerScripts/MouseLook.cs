﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;




    public class MouseLook : MonoBehaviour
{
    public enum RotationAxes {MouseX, MouseY}
    public RotationAxes axes = RotationAxes.MouseY;

    float currentSensitivity_X = 1.5f;
    float currentSensitivity_Y = 1.5f;

    float sensitivity_X = 1.5f;
    float sensitivitya_Y = 1.5f;

    float rotation_X, rotation_Y;

    float minimum_X = -360f;
    float maximum_X = 360f;

    float minimum_Y = -60f;
    float maximum_Y = 60f;

    Quaternion originalRotation;

    float mouseSensitivity = 1.7f;




    void Start()
    {
        originalRotation = transform.rotation;
    }





    void Update() { }


    private void FixedUpdate() { }
    
        
    





    private void LateUpdate() //late update is called after update and fixed update
    {
        HandleRotation();
    }







    float ClampAngle (float angle, float min, float max)
    {
        if (angle <-360f)
        {
            angle += 360f;
        }

        if (angle > 360f)
        {
            angle -= 360f;
        }

        return Mathf.Clamp(angle, min, max);
    }






    void HandleRotation()
    {
        if (currentSensitivity_X != mouseSensitivity || currentSensitivity_Y != mouseSensitivity)
        {
            currentSensitivity_X = currentSensitivity_Y = mouseSensitivity;
        }

        sensitivity_X = currentSensitivity_X;
        sensitivitya_Y = currentSensitivity_Y;

        if(axes == RotationAxes.MouseX)
        {
            rotation_X += Input.GetAxis("Mouse X") * sensitivity_X;

            rotation_X = ClampAngle(rotation_X, minimum_X, maximum_X);

            Quaternion xQuaternion = Quaternion.AngleAxis(rotation_X, Vector3.up);

            transform.localRotation = originalRotation * xQuaternion;
        }


        if (axes == RotationAxes.MouseY)
        {
            rotation_Y += Input.GetAxis("Mouse Y") * sensitivitya_Y;

            rotation_Y = ClampAngle(rotation_Y, minimum_Y, maximum_Y);

            Quaternion yQuatermion = Quaternion.AngleAxis(-rotation_Y, Vector3.right);

            transform.localRotation = originalRotation * yQuatermion;
        }


    }





















}

        