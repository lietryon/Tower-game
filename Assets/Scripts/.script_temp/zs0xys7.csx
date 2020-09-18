using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    [SerializeField]
    protected Transform CameraTarget;
    [SerializeField]
    protected bool isXLocked = false;
    [SerializeField]
    protected bool isYLocked = false;

    float xNew = transform.position.x;
    if (!isXLocked)
    {
        xNew = Mathf.Lerp(transform.position.x, xTarget, Time.deltaTime * followSpeed);
    }

    float yNew = transform.position.y;
    if (!isYLocked)
    {
        yNew = Mathf.Lerp(transform.position.y, yTarget, Time.deltaTime * followSpeed);
    }

    void Update()
    {
        transform.position = new Vector3(CameraTarget.position.x, CameraTarget.position.y, transform.position.z);  
    }
}