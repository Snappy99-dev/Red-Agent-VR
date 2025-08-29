using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace EscapeRoom.Extra{
public class SetObjectTransform : MonoBehaviour
{
    [SerializeField]
    Vector3 desPosition= new Vector3();
    [SerializeField]
    Transform targetObject;  
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SetPositionWithDespos(){
        targetObject.position=desPosition;
    }
    public void SetPositionBySelf(){
        targetObject.position=transform.position;
    }
}
}

