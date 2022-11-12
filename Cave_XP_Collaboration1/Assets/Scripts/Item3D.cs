using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class Item3D : MonoBehaviour
{
  
      Image S_image; //슬롯 이미지
      public Sprite EmptyImage;  //투명 이미지
      public Sprite ItemImage; // 아이템 이미지
      public GameObject SlotItem; //아이템별 슬롯 지정
   
    void Start()
    {
        SlotItem.GetComponent<Button>().interactable = false;   //슬롯 버튼 비활성화
        S_image = SlotItem.GetComponent<Image>();   //슬롯 이미지

    }

  

    private void OnMouseDown()
    {
        //ui뒤에 물체는 눌리지 않게 하는 코드
        if (!EventSystem.current.IsPointerOverGameObject())
        {
            SlotItem.GetComponent<Button>().interactable = true;    //슬롯 버튼 활성화
            S_image.sprite = ItemImage;     //슬롯 이미지 아이템으로 변경
            if (gameObject.CompareTag("NameTag"))
            {
                //문열리게 하는 코드
            }  
            Destroy(gameObject);

        }


    }
}
