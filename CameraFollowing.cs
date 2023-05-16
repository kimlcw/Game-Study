using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowing : MonoBehaviour
{

    public GameObject PlayerOBJ = null;

    private float smoothTime = 0.2f;
    private float xVelocity = 0.0f;
    private float zVelocity = 0.0f;

    Vector3 newPosition = Vector3.zero;

    // Start is called before the first frame update
    //void Start()
    //{
        
    //}

    // Update is called once per frame
    void Update()
    {
        if(PlayerOBJ != null)
        {
            newPosition = transform.position;
            newPosition.x = Mathf.SmoothDamp(transform.position.x, PlayerOBJ.transform.position.x, ref xVelocity, smoothTime);
            newPosition.z = Mathf.SmoothDamp(transform.position.z, PlayerOBJ.transform.position.z, ref zVelocity, smoothTime);
            transform.position = newPosition;
        }
    }
}
