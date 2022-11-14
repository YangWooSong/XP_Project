using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class mainBtnManagerScr : MonoBehaviour
{
    public GameObject startMenu;
    public GameObject optionMenu;
    public GameObject exitMenu;

    public Button startBtn;
    public Button obtionBtn;
    public Button exitBtn;
    public Button optionBackBtn;
    public Button exitGoBtn;
    public Button exitBackBtn;

    // Start is called before the first frame update
    void Start()
    {
        startBtn.onClick.AddListener(btnStart);
        obtionBtn.onClick.AddListener(btnOption);
        exitBtn.onClick.AddListener(btnExit);
        optionBackBtn.onClick.AddListener(btnOptionBack);
        exitGoBtn.onClick.AddListener(BtnExitGo);
        exitBackBtn.onClick.AddListener(BtnExitBack);
        startMenu.SetActive(true);
        optionMenu.SetActive(false);
        exitMenu.SetActive(false);
    }

    void btnStart()
    {
        SceneManager.LoadScene("Controll_monstor_room");
    }
    void btnOption()
    {
        startMenu.SetActive(false);
        optionMenu.SetActive(true);
        exitMenu.SetActive(false);
    }
    void btnExit()
    {
        startMenu.SetActive(false);
        optionMenu.SetActive(false);
        exitMenu.SetActive(true);
    }
    void btnOptionBack()
    {
        startMenu.SetActive(true);
        optionMenu.SetActive(false);
        exitMenu.SetActive(false);
    }
    void BtnExitGo()
    {
        UnityEditor.EditorApplication.isPlaying = false;
        Application.Quit(); 
    }
    void BtnExitBack()
    {
        startMenu.SetActive(true);
        optionMenu.SetActive(false);
        exitMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
