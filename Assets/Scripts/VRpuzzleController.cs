using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BNG;
namespace VRPuzzle.Core{
    public class VRpuzzleController : MonoBehaviour
    {
        InputBridge input ; 
        // Start is called before the first frame update
        void Start()
        {
             input = InputBridge.Instance;
        }

        // Update is called once per frame
        void Update()
        {
            
        }
        public bool  VRValidationButtonIsPressed_Down(){
            if (input.RightTriggerDown)
            {
                Debug.Log("RightTriggerDown");
                return true;
            }
            return false;
        }
        public bool VRValidationButtonIsPressed_Up()
        {
            if (input.RightTriggerUp)
            {
                Debug.Log("RightTriggerUp");
                return true;
            }
            return false;
        }

        public bool VRBackButtonIsPressed_Down()
        {
            if (Input.GetKeyDown(KeyCode.D))
            {
                //Debug.Log("Button D is pressed Down");
                return true;
            }
            return false;
        }
    }
}

