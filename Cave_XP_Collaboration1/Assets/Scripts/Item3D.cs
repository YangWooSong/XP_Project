using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class Item3D : MonoBehaviour
{
  
<<<<<<< Updated upstream
      Image S_image; //슬롯 이미지
      public Sprite EmptyImage;  //투명 이미지
      public Sprite ItemImage; // 아이템 이미지
      public GameObject SlotItem; //아이템별 슬롯 지정
   
=======
      //Image S_image; //슬롯 이미지
      //public Sprite EmptyImage;  //투명 이미지
     // public Sprite ItemImage; // 아이템 이미지
     //public GameObject SlotItem; //아이템별 슬롯 지정
        
>>>>>>> Stashed changes
    void Start()
    {
        SlotItem.GetComponent<Button>().interactable = false;   //슬롯 버튼 비활성화
        S_image = SlotItem.GetComponent<Image>();   //슬롯 이미지

    }

  

    private void OnMouseDown()
    {
        //ui뒤에 물체는 눌리지 않게 하는 코드
<<<<<<< Updated upstream
        if (!EventSystem.current.IsPointerOverGameObject())
=======
       if (!EventSystem.current.IsPointerOverGameObject())
>>>>>>> Stashed changes
        {
            //SlotItem.GetComponent<Button>().interactable = true;    //슬롯 버튼 활성화
            //S_image.sprite = ItemImage;     //슬롯 이미지 아이템으로 변경
            if (gameObject.CompareTag("NameTag"))
            {
                GameObject.Find("GameManager 1").GetComponent<MainGameManagerScr>().getNameTag = true;
            }  
            Destroy(gameObject);

        }


    }
}
