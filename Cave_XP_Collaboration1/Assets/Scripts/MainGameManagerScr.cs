using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class MainGameManagerScr : MonoBehaviour
{
    public static MainGameManagerScr instance;
    public static float timeLimit= 100f;//�� ���� �ð� 
    public static bool wireClear = false;
    public static bool timeGo = true;

    public GameObject inventoryPanel;   //�κ��丮 �г�
    public static bool activeInven = false;       //�κ� �г� Ȱ��ȭ ����
    Button invenBtn;

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        //�� �ε� �� ������ ����
        inventoryPanel = GameObject.Find("Inventory");
        inventoryPanel.SetActive(activeInven);      //�κ� ��Ȱ��ȭ

        invenBtn = GameObject.Find("InvenButton").GetComponent<Button>();
        invenBtn.onClick.AddListener(getInvenButton);

    }
    void OnEnable()
    {
        //onLoad�� ��Ʈ
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
        activeInven = !activeInven;     //��ư ������ ���� Ȱ�� or ��Ȱ��
        inventoryPanel.SetActive(activeInven);  // bool�� ����
        MainGameManagerScr.timeGo = !MainGameManagerScr.timeGo;
    }
    public void ApplicationQuit()
    {
        Application.Quit();
        Debug.Log("����");
    }

    void OnDisable()
    {
        //�� �����, onload�� ��Ʈ
        Debug.Log("OnDisable");
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }
}
