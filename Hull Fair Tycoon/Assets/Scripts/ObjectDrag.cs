using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDrag : MonoBehaviour
{
    private Vector3 offset;
    private CameraManager cameraManager;
    private void OnMouseDown()
    {
        offset = transform.position - BuildingSystem.GetMouseWorldPosition();
    }

    private void OnMouseDrag()
    {
        cameraManager = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<CameraManager>();
        cameraManager.enabled = false;     
        Vector3 pos = BuildingSystem.GetMouseWorldPosition() + offset;
        transform.position = BuildingSystem.current.SnapCoordinateToGrid(pos);
    }

    private void OnMouseUp()
    {
        cameraManager.enabled = true;
    }
}
