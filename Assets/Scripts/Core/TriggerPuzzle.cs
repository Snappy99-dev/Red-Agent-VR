using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using  EscapeRoom.Puzzle;
namespace EscapeRoom.Core{
public class TriggerPuzzle : MonoBehaviour
{
    [SerializeField]
    List<TriggerChecker> triggerCheckers = new List<TriggerChecker>();
    bool[] passAll;
    public UnityEvent OnPuzzlePass;
    public UnityEvent OnPuzzleWrong;
    // Start is called before the first frame update
    void Start()
    {
        passAll= new bool[triggerCheckers.Count];
        foreach(TriggerChecker triggerChecker in triggerCheckers){
            triggerChecker.OntriggerPass.AddListener(()=>{
                passAll[triggerCheckers.IndexOf(triggerChecker)]=true;
                CheckActivate();
            });
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void CheckActivate(){
        int sumCheck=0;
        foreach(bool p in passAll){
            if(p==true){
                sumCheck++;
            }
        }
        if(sumCheck==passAll.Length){
            OnPuzzlePass?.Invoke();
        }
        
    }
    
    
}
}

