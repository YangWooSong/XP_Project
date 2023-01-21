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


    //������ ����
    public bool getNameTag = false;
    private GameObject s_nameTag;
    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        //�� �ε� �� ������ ����
        inventoryPanel = GameObject.Find("Inventory");
<<<<<<< Updated upstream
        inventoryPanel.SetActive(activeInven);      //�κ� ��Ȱ��ȭ
=======
        invenBtn = GameObject.Find("InvenButton");
        s_nameTag = GameObject.Find("S_NameTag");

        if (inventoryPanel)
        {
            inventoryPanel.SetActive(activeInven);      //�κ� ��Ȱ��ȭ    
        }
            
        if (invenBtn)
        {
            invenBtn.GetComponent<Button>().onClick.AddListener(getInvenButton);

        }
>>>>>>> Stashed changes

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
<<<<<<< Updated upstream
   

=======

        //�κ� ���� Ȱ��ȭ �κ�
        s_nameTag.SetActive(getNameTag);
>>>>>>> Stashed changes
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
