using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SlotItem : MonoBehaviour
{
    public GameObject ex_panel;     //���� �г�
    private bool ex_plainPanel_show = false;    // ���� �г� ��Ȱ��ȭ

    // Start is called before the first frame update
    void Start()
    {
        ex_panel.SetActive(ex_plainPanel_show);    // ���� �г� ��Ȱ��ȭ
    }


    public void ButtonInput()
    {
        ex_plainPanel_show = !ex_plainPanel_show;   //��ư ������ ���� Ȱ�� or ��Ȱ��
        ex_panel.SetActive(ex_plainPanel_show);     //bool�� ����
    }
}