using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Item3D : MonoBehaviour
{
    public GameObject objectMesh; //item ����
    Image S_image; //���� �̹���
    public Sprite EmptyImage;  //���� �̹���
    public Sprite ItemImage; // ������ �̹���
    public GameObject SlotItem; //�����ۺ� ���� ����
    void Start()
    {
        SlotItem.GetComponent<Button>().interactable = false;   //���� ��ư ��Ȱ��ȭ
        S_image = SlotItem.GetComponent<Image>();   //���� �̹���
    }
    private void OnMouseDown()
    {
        //Debug.Log("���콺");
        SlotItem.GetComponent<Button>().interactable = true;    //���� ��ư Ȱ��ȭ
        S_image.sprite = ItemImage;     //���� �̹��� ���������� ����
        Destroy(objectMesh);   
    }
}
