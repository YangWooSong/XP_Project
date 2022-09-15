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

    // Update is called once per frame
    void Update()
    {

    }

    public void GoToAnagramScene()
    {
        SceneManager.LoadScene("AnagramGame");  //다른 Scene으로 넘어가기
    }
    public void GoToMemoryScene()
    {
        SceneManager.LoadScene("MemoryScene");  //다른 Scene으로 넘어가기
    }

    public void GoToWireScene()
    {
        SceneManager.LoadScene("WireScene");  //다른 Scene으로 넘어가기
    }

    public void GoToGameTestScene()
    {
        SceneManager.LoadScene("GameTestScene");  //다른 Scene으로 넘어가기
    }


}