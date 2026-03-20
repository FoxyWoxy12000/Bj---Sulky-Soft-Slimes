using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseManager : MonoBehaviour
{
    [Header("Mouse Info")]
    public Vector3 clickStartLocation;

    [Header("Physics")]
    public Vector3 LaunchVector;
    public float LaunchForce;
    public float MaxDragDistance = 300f;

    [Header("Slime Out")]
    public Transform SlimeTransform;
    public Rigidbody slimeRigidbody;

    [Header("Reset")]
    public Vector3 OriginPosition;
    public Quaternion OriginRotation;
    public bool rested;

    void Start()
    {
        OriginRotation = SlimeTransform.rotation;
        OriginPosition = SlimeTransform.position;
        slimeRigidbody.isKinematic = true;
        rested = true;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            clickStartLocation = Input.mousePosition;
        }

        if (Input.GetMouseButton(0))
        {
            if (rested)
            {
                Vector3 mouseDifference = clickStartLocation - Input.mousePosition;

                float dragMagnitude = Mathf.Clamp(mouseDifference.magnitude, 0f, MaxDragDistance);
                Vector3 dragDirection = mouseDifference.magnitude > 0.01f
                    ? mouseDifference.normalized
                    : Vector3.zero;

                float t = dragMagnitude / MaxDragDistance;

                LaunchVector = new Vector3(
                    dragDirection.x * 1f,
                    dragDirection.y * 1.2f,
                    dragDirection.y * 1.5f
                ) * t;

                
                Vector3 visualOffset = new Vector3(
                    mouseDifference.x * 1f,
                    mouseDifference.y * 1.2f,
                    mouseDifference.y * 1.5f
                );
                SlimeTransform.position = OriginPosition - visualOffset / 400;
            }
            
        }
        if (Input.GetMouseButtonUp(0))
        {
            if (rested)
            {
                slimeRigidbody.isKinematic = false;
                slimeRigidbody.AddForce(LaunchVector * LaunchForce, ForceMode.Impulse);
            }
            rested = false;
        }


        if (Input.GetMouseButtonDown(1) || Input.GetKeyDown(KeyCode.Space))
        {
            slimeRigidbody.isKinematic = true;
            SlimeTransform.position = OriginPosition;
            SlimeTransform.rotation = OriginRotation;
            rested = true;
        }
    }
}