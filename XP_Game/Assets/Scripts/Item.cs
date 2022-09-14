using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Item : MonoBehaviour
{
    Image B_image; //현재 버튼 이미지
    Image S_image; //슬롯 이미지
    public Sprite EmptyImage;  //투명 이미지
    public Sprite ItemImage; // 아이템 이미지
    public GameObject SlotItem; //아이템별 슬롯 지정
    void Start()
    {
        GetComponent<Button>().interactable = true;     //버튼 활성화
        B_image = GetComponent<Image>();    //현재 버튼 이미지 가져옴
        SlotItem.GetComponent<Button>().interactable = false;   //슬롯 버튼 비활성화
        S_image = SlotItem.GetComponent<Image>();   //슬롯 이미지

    }

    public void ButtonInput()
    {
        GetComponent<Button>().interactable = false;    //버튼 비활성화
        B_image.sprite = EmptyImage;   //버튼 이미지를 투명으로
        SlotItem.GetComponent<Button>().interactable = true;    //슬롯 버튼 활성화
        S_image.sprite = ItemImage;     //슬롯 이미지 아이템으로 변경
    }
}


//아이템 별로 다 넣어주는 스크립트