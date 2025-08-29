using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
namespace EscapeRoom.Core{
public class EntityLocker : MonoBehaviour,IActivateEntity
{
        public bool isLock=true;
        public UnityEvent OnActivateEvent;
        public void OnActivate()
        {
            isLock=false;
            OnActivateEvent?.Invoke();
            //throw new System.NotImplementedException();
        }
        public bool IsActivate(){
            return !isLock;
        }

        // Start is called before the first frame update
            void Start()
        {
            
        }

        // Update is called once per frame
        void Update()
        {
            
        }
}
}

