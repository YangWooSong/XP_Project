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
        SceneManager.LoadScene("AnagramGame");  //�ٸ� Scene���� �Ѿ��
        MainGameManagerScr.timeGo = false;
    }
    public void GoToMemoryScene()
    {
        SceneManager.LoadScene("MemoryScene");  //�ٸ� Scene���� �Ѿ��
        MainGameManagerScr.timeGo = false;
    }

    public void GoToWireScene()
    {
        SceneManager.LoadScene("WireScene");  //�ٸ� Scene���� �Ѿ��
        MainGameManagerScr.timeGo = false;
    }

    public void GoToGameTestScene()
    {
        SceneManager.LoadScene("GameTestScene");  //�ٸ� Scene���� �Ѿ��
        MainGameManagerScr.timeGo = true;
    }
   

    public void GoToControl() { 
        SceneManager.LoadScene("Controll_monstor_room");  //�ٸ� Scene���� �Ѿ��
        MainGameManagerScr.timeGo = true;
    }
    public void GoToSetting()
    {
        SceneManager.LoadScene("Setting_room 1");  //�ٸ� Scene���� �Ѿ��
        MainGameManagerScr.timeGo = true;
    }

}