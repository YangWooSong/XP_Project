using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainGameManagerScr : MonoBehaviour
{
    public static MainGameManagerScr instance;
    public static float timeLimit= 100f;//총 게임 시간 
    public static bool wireClear = false;
    public static bool timeGo = true;


    public GameObject inventoryPanel;   //인벤토리 패널
    bool activeInven;       //인벤 패널 활성화 상태
  

    void Start()
    {
        instance = this;
        inventoryPanel.SetActive(activeInven);      //인벤 비활성화
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(timeGo);
        if (timeGo)
        {
            timeLimit -= Time.deltaTime;
            
        }
        else
        {

        }
        
    }
    public static void TimeSub(int getTime)
    {
        timeLimit -= getTime;
        MemoryTimer.MemorytimeDuration = 0;
    }
    public static void TimeAdd(int getTime)
    {
        timeLimit += getTime;
        MemoryTimer.MemorytimeDuration = 0;
    }
    public void getInvenButton()
    {
        Debug.Log("클릭");
        Debug.Log(MainGameManagerScr.timeGo);
        activeInven = !activeInven;     //버튼 누를때 마다 활성 or 비활성
        if(activeInven == true)
        {
            
        }
        inventoryPanel.SetActive(activeInven);      // bool값 적용
        MainGameManagerScr.timeGo = !MainGameManagerScr.timeGo;

    }
}
