using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class Item3D : MonoBehaviour
{
  
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
        //ui�ڿ� ��ü�� ������ �ʰ� �ϴ� �ڵ�
        if (!EventSystem.current.IsPointerOverGameObject())
        {
            SlotItem.GetComponent<Button>().interactable = true;    //���� ��ư Ȱ��ȭ
            S_image.sprite = ItemImage;     //���� �̹��� ���������� ����
            if (gameObject.CompareTag("NameTag"))
            {
                //�������� �ϴ� �ڵ�
            }  
            Destroy(gameObject);

        }


    }
}
