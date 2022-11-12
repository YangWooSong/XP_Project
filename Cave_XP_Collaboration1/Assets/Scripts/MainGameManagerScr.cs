using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class MainGameManagerScr : MonoBehaviour
{
    public static MainGameManagerScr instance;
    public static float timeLimit= 100f;//총 게임 시간 
    public static bool wireClear = false;
    public static bool timeGo = true;

    public GameObject inventoryPanel;   //인벤토리 패널
    public static bool activeInven = false;       //인벤 패널 활성화 상태
    Button invenBtn;

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        //씬 로드 될 때마다 실행
        inventoryPanel = GameObject.Find("Inventory");
        inventoryPanel.SetActive(activeInven);      //인벤 비활성화

        invenBtn = GameObject.Find("InvenButton").GetComponent<Button>();
        invenBtn.onClick.AddListener(getInvenButton);

    }
    void OnEnable()
    {
        //onLoad랑 세트
        Debug.Log("OnEnable called");
        SceneManager.sceneLoaded += OnSceneLoaded;
    }
    void Start()
    {
        instance = this;
     
    }
 
    // Update is called once per frame
    void Update()
    {
        //Debug.Log(timeGo);
        if (timeGo)
        {
            timeLimit -= Time.deltaTime;
            
        }
        else
        {

        }
   

    }
    public static void TimeSub(int getTime)
    {
        timeLimit -= getTime;
        MemoryTimer.MemorytimeDuration = 0;
    }
    public static void TimeAdd(int getTime)
    {
        timeLimit += getTime;
        MemoryTimer.MemorytimeDuration = 0;
    }
    public void getInvenButton()
    {
        Debug.Log(activeInven);       // Debug.Log(MainGameManagerScr.timeGo);
        activeInven = !activeInven;     //버튼 누를때 마다 활성 or 비활성
        inventoryPanel.SetActive(activeInven);  // bool값 적용
        MainGameManagerScr.timeGo = !MainGameManagerScr.timeGo;
    }
    public void ApplicationQuit()
    {
        Application.Quit();
        Debug.Log("닫힘");
    }

    void OnDisable()
    {
        //씬 종료시, onload랑 세트
        Debug.Log("OnDisable");
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }
}
