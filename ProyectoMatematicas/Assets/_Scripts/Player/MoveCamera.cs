using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    public Transform cameraPosition;

    private void Update()
    {
        transform.position = Vector3.Lerp(transform.position, cameraPosition.position, Time.deltaTime * 15f);
    }
}
