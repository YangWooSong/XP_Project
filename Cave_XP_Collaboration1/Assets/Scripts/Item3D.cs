using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class Item3D : MonoBehaviour
{
  
<<<<<<< Updated upstream
      Image S_image; //���� �̹���
      public Sprite EmptyImage;  //���� �̹���
      public Sprite ItemImage; // ������ �̹���
      public GameObject SlotItem; //�����ۺ� ���� ����
   
=======
      //Image S_image; //���� �̹���
      //public Sprite EmptyImage;  //���� �̹���
     // public Sprite ItemImage; // ������ �̹���
     //public GameObject SlotItem; //�����ۺ� ���� ����
        
>>>>>>> Stashed changes
    void Start()
    {
        SlotItem.GetComponent<Button>().interactable = false;   //���� ��ư ��Ȱ��ȭ
        S_image = SlotItem.GetComponent<Image>();   //���� �̹���

    }

  

    private void OnMouseDown()
    {
        //ui�ڿ� ��ü�� ������ �ʰ� �ϴ� �ڵ�
<<<<<<< Updated upstream
        if (!EventSystem.current.IsPointerOverGameObject())
=======
       if (!EventSystem.current.IsPointerOverGameObject())
>>>>>>> Stashed changes
        {
            //SlotItem.GetComponent<Button>().interactable = true;    //���� ��ư Ȱ��ȭ
            //S_image.sprite = ItemImage;     //���� �̹��� ���������� ����
            if (gameObject.CompareTag("NameTag"))
            {
                GameObject.Find("GameManager 1").GetComponent<MainGameManagerScr>().getNameTag = true;
            }  
            Destroy(gameObject);

        }


    }
}
