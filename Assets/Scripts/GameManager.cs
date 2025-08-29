using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Events;
namespace EscapeRoom{
public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    [SerializeField]
    float timeCountStart= 15f; //Miniute Source
    float timeCount;
    [SerializeField]
    float timeDecrease=2f;//Miniute Source
    [SerializeField]
    TimeCountUI timeCountUI;

    int miniuteValue;
    int secondsValue;
    public bool startCountDown=false;
    public UnityEvent OnTimeOver;
    // Start is called before the first frame update
    void Start()
    {
        timeCount=timeCountStart*60;
        timeDecrease*=60;
        Instance= this;
    }

    // Update is called once per frame
    void Update()
    {
        if(startCountDown){
            if(timeCount>0){
                timeCount-=Time.deltaTime;
                miniuteValue= (int)timeCount/60;
                secondsValue= (int)timeCount%60;
                timeCountUI.UpdateTimeCountUI(miniuteValue,secondsValue);

               // Debug.Log(miniuteValue +" : "+ secondsValue);
            }
            else{
                OnTimeOver?.Invoke();
                startCountDown=false;
                ResetTime();
            }
            
        }
    }
    public void SaveCurrentScene(){
        PlayerPrefs.SetInt("CurrentScene",UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex);
        PlayerPrefs.Save();
    }
    public void StartTimeCount(){
        startCountDown=true;
    }
    public void StopTimeCount(){
        startCountDown=false;
    }
    public void DecreaseTime(){
        timeCount-=timeDecrease;
    }
    public void ResetTime(){
        timeCount=timeCountStart*60;
    }
}
}

