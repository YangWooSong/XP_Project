using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvenButton : MonoBehaviour
{
    public GameObject inventoryPanel;   //�κ��丮 �г�
    bool activeInven;       //�κ� �г� Ȱ��ȭ ����

    private void Start()
    {
        
        inventoryPanel.SetActive(activeInven);      //�κ� ��Ȱ��ȭ
    }
    void Update()
    {
        
    }

    public void getButton()
    {
        Debug.Log("Ŭ��");
        Debug.Log(MainGameManagerScr.timeGo);
        activeInven = !activeInven;     //��ư ������ ���� Ȱ�� or ��Ȱ��
        inventoryPanel.SetActive(activeInven);      // bool�� ����
        MainGameManagerScr.timeGo = !MainGameManagerScr.timeGo;
        
    }
}
