using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class SceneChange : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

 
    public void GoToAnagramScene()
    {
        SceneManager.LoadScene("AnagramGame");  //다른 Scene으로 넘어가기
        MainGameManagerScr.timeGo = false;
    }
    public void GoToMemoryScene()
    {
        SceneManager.LoadScene("MemoryScene");  //다른 Scene으로 넘어가기
        MainGameManagerScr.timeGo = false;
    }

    public void GoToWireScene()
    {
        SceneManager.LoadScene("WireScene");  //다른 Scene으로 넘어가기
        MainGameManagerScr.timeGo = false;
    }

    public void GoToGameTestScene()
    {
        SceneManager.LoadScene("GameTestScene");  //다른 Scene으로 넘어가기
        MainGameManagerScr.timeGo = true;
    }
   

    public void GoToControl() { 
        SceneManager.LoadScene("Controll_monstor_room");  //다른 Scene으로 넘어가기
        MainGameManagerScr.timeGo = true;
    }
    public void GoToSetting()
    {
        SceneManager.LoadScene("Setting_room 1");  //다른 Scene으로 넘어가기
        MainGameManagerScr.timeGo = true;
    }

}