using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class Item3D : MonoBehaviour
{

    private void OnMouseDown()
    {
        //ui�ڿ� ��ü�� ������ �ʰ� �ϴ� �ڵ�
        if (!EventSystem.current.IsPointerOverGameObject())
        {
       
            if (gameObject.name == "nametag")
            {
                GameObject.Find("GameManager 1").GetComponent<MainGameManagerScr>().getNameTag = true;

            }
            else if (gameObject.name == "riphand")
            {
                GameObject.Find("GameManager 1").GetComponent<MainGameManagerScr>().getRipHand = true;
            }
            else if (gameObject.name == "handcloth")
            {
                GameObject.Find("GameManager 1").GetComponent<MainGameManagerScr>().getHandcloth = true;
            }
            else if(gameObject.name == "saw")
            {
               GameObject.Find("GameManager 1").GetComponent<MainGameManagerScr>().getSaw = true;
            }
            Destroy(gameObject);

        }


    }
}
