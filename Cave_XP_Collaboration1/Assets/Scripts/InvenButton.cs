using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvenButton : MonoBehaviour
{
    public GameObject inventoryPanel;   //�κ��丮 �г�
    bool activeInven = false;       //�κ� �г� Ȱ��ȭ ����

    private void Start()
    {
        inventoryPanel.SetActive(activeInven);      //�κ� ��Ȱ��ȭ
    }
    void Update()
    {

    }

    public void getButton()
    {
        activeInven = !activeInven;     //��ư ������ ���� Ȱ�� or ��Ȱ��
        inventoryPanel.SetActive(activeInven);      // bool�� ����
    }
}
