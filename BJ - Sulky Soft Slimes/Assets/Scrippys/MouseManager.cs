using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseManager : MonoBehaviour
{
    [Header("mous info")]
    public Vector3 clickStartLocation;
    [Header("Physic")]
    public Vector3 LaunchVector;
    public float LaunchForce;
    [Header("slimed out")]
    public Transform SlimeTransform;
    public Rigidbody slimeRigidbody;
    [Header("resst")]
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
    // Update is called once per frame
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
                LaunchVector = new Vector3(
                    mouseDifference.x * 1f,
                    mouseDifference.y * 1.2f,
                    mouseDifference.y * 1.5f
                    );
                SlimeTransform.position = OriginPosition - LaunchVector / 400;
                LaunchVector.Normalize();
            }
        }
        if (Input.GetMouseButtonUp(0))
        {
            slimeRigidbody.isKinematic = false;

            if (rested)
            {
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
