using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
namespace EscapeRoom.Puzzle{
public class ObjecstCraft : MonoBehaviour
{
    public string targetObject1="";
    public string targetObject2="";
    public UnityEvent OnFinish;
    List<GameObject> targetObjects= new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other) {
        if(other.transform.name==targetObject1||other.transform.name==targetObject2){
            targetObjects.Add(other.gameObject);
            if(targetObjects.Count>=2){
                OnFinish?.Invoke();
                foreach(GameObject g in targetObjects){
                    g.SetActive(false);
                }
            }
        }
    }
    private void OnTriggerStay(Collider other) {
        if(other.transform.name==targetObject1||other.transform.name==targetObject2){
            ///targetObjects.Add(other.gameObject);
            
        }
    }
    private void OnTriggerExit(Collider other) {
        if(other.transform.name==targetObject1||other.transform.name==targetObject2){
            ///targetObjects.Add(other.gameObject);
            targetObjects.Remove(other.gameObject);
        }
    }
}
}

