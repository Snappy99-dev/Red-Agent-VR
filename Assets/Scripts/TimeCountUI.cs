using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
namespace EscapeRoom{
public class TimeCountUI : MonoBehaviour
{
    [SerializeField]
    TMP_Text timeCountTxt;
    string timeCountStr="";
    string min_01="0";
    string min_02="0";
    const string _Colon=":";
    string sec_01 ="0";
    string sec_02 ="0";
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void UpdateTimeCountUI(int miniuteValue,int secondsValue){
        //00:00
        min_01= (miniuteValue/10).ToString();
        min_02=(miniuteValue%10).ToString();
        sec_01=(secondsValue/10).ToString();
        sec_02=(secondsValue%10).ToString();
        timeCountTxt.text=min_01+min_02+_Colon+sec_01+sec_02;
    }
}
}

