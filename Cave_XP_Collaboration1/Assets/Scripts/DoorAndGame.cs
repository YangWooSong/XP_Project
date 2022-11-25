using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class DoorAndGame : MonoBehaviour
{
    public bool cam0, cam1;
    
    void Start()
    {
        cam0 = true;
        cam1 = false;
    }

    private void OnMouseDown()
    {
       
            if (!EventSystem.current.IsPointerOverGameObject())
            {
                if (gameObject.CompareTag("ToSetting"))
                {

                    SceneManager.LoadScene("Setting_room 1");
                }
                else if (gameObject.CompareTag("MonsterRoomDoor"))
                {
                    cam0 = !cam0;
                    cam1 = !cam1;
                }
                else if (gameObject.CompareTag("ToWare"))
                {
                    SceneManager.LoadScene("WarehouseScene");
                }
                /*else if (gameObject.CompareTag("ToControl"))
                {
                    SceneManager.LoadScene("Controll_monstor_room");
                }
                else if (gameObject.CompareTag("Puzzle1"))
                {
                    SceneManager.LoadScene("WireScene");
                }*/
                else if (gameObject.CompareTag("Puzzle2"))
                {
                    SceneManager.LoadScene("MemoryScene");
                }
                else if (gameObject.CompareTag("Puzzle3"))
                {
                    SceneManager.LoadScene("AnagramGame");
                }
            }
        
          
            
    }


    
}
