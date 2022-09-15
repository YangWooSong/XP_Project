using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Item : MonoBehaviour
{
    Image B_image; //���� ��ư �̹���
    Image S_image; //���� �̹���
    public Sprite EmptyImage;  //���� �̹���
    public Sprite ItemImage; // ������ �̹���
    public GameObject SlotItem; //�����ۺ� ���� ����
    void Start()
    {
        GetComponent<Button>().interactable = true;     //��ư Ȱ��ȭ
        B_image = GetComponent<Image>();    //���� ��ư �̹��� ������
        SlotItem.GetComponent<Button>().interactable = false;   //���� ��ư ��Ȱ��ȭ
        S_image = SlotItem.GetComponent<Image>();   //���� �̹���

    }

    public void ButtonInput()
    {
        GetComponent<Button>().interactable = false;    //��ư ��Ȱ��ȭ
        B_image.sprite = EmptyImage;   //��ư �̹����� ��������
        SlotItem.GetComponent<Button>().interactable = true;    //���� ��ư Ȱ��ȭ
        S_image.sprite = ItemImage;     //���� �̹��� ���������� ����
    }
}


//������ ���� �� �־��ִ� ��ũ��Ʈ