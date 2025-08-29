using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace  EscapeRoom.Extra
{
    public class FollowCamera : MonoBehaviour
{
    Transform mainCameraTransform;
    // Start is called before the first frame update
    void Start()
    {
        mainCameraTransform= Camera.main.transform;
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(mainCameraTransform);
    }
}
}

