using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
namespace EscapeRoom.Puzzle{
public class TriggerChecker : MonoBehaviour
{
    public bool isPass=false;
    public string targetName="";
    public UnityEvent OntriggerPass;
    public UnityEvent OntriggerWrong;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.name==targetName){
            isPass=true;
            OntriggerPass?.Invoke();
        }
        else{
            isPass=false;
            OntriggerWrong?.Invoke();
        }
    }
    private void OnTriggerExit(Collider other) {
        //isPass=false;
    }
    private void OnTriggerStay(Collider other) {
        if(other.gameObject.name==targetName){
            isPass=true;
        }
    }
}
}

