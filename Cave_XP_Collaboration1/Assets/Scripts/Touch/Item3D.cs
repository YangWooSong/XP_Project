using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Item3D : MonoBehaviour
{
    //public GameObject objectMesh; //item ����
    // Image S_image; //���� �̹���
    //  public Sprite EmptyImage;  //���� �̹���
    //  public Sprite ItemImage; // ������ �̹���
    //  public GameObject SlotItem; //�����ۺ� ���� ����
   
    void Start()
    {
      //  SlotItem.GetComponent<Button>().interactable = false;   //���� ��ư ��Ȱ��ȭ
      //  S_image = SlotItem.GetComponent<Image>();   //���� �̹���

    }

    private void Update()
    {
        if(this.tag == "Namespace")
        {
            //�밭 �������� ���� �����ͼ� true�� �ض�
        }
    }

    private void OnMouseDown()
    {
       // SlotItem.GetComponent<Button>().interactable = true;    //���� ��ư Ȱ��ȭ
      //  S_image.sprite = ItemImage;     //���� �̹��� ���������� ����
        Destroy(gameObject);
        Debug.Log("��");


    }
}
