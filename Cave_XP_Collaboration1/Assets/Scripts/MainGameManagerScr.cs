using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainGameManagerScr : MonoBehaviour
{
    public static MainGameManagerScr instance;
    public static float timeLimit= 100f;//�� ���� �ð� 
    public static bool wireClear = false;
    public static bool timeGo = true;


    public GameObject inventoryPanel;   //�κ��丮 �г�
    bool activeInven;       //�κ� �г� Ȱ��ȭ ����
  

    void Start()
    {
        instance = this;
        inventoryPanel.SetActive(activeInven);      //�κ� ��Ȱ��ȭ
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
        Debug.Log("Ŭ��");
        Debug.Log(MainGameManagerScr.timeGo);
        activeInven = !activeInven;     //��ư ������ ���� Ȱ�� or ��Ȱ��
        if(activeInven == true)
        {
            
        }
        inventoryPanel.SetActive(activeInven);      // bool�� ����
        MainGameManagerScr.timeGo = !MainGameManagerScr.timeGo;

    }
}
