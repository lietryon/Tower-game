using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    [SerializeField]
    protected Transform CameraTarget;

    [SerializeField]
    float xOffset;

    [SerializeField]
    float yOffset;

    [SerializeField]
    protected float followSpeed;

    [SerializeField]
    protected bool isXLocked = false;

    [SerializeField]
    protected bool isYLocked = false;

    void Update()
    {
        float xTarget = CameraTarget.position.x + xOffset;
        float yTarget = CameraTarget.position.y + yOffset;

        float xNew = Mathf.Lerp(transform.position.x, xTarget, Time.deltaTime * followSpeed);
        float yNew = Mathf.Lerp(transform.position.y, yTarget, Time.deltaTime * followSpeed);

        transform.position = new Vector3(xNew, yNew, transform.position.z);

        if (!isXLocked)
        {
            xNew = Mathf.Lerp(transform.position.x, xTarget, Time.deltaTime * followSpeed);
        }

        if (!isYLocked)
        {
            yNew = Mathf.Lerp(transform.position.y, yTarget, Time.deltaTime * followSpeed);
        }
    }
    
}
