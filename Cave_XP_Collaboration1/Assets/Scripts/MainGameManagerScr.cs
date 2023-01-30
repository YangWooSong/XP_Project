using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
public class MainGameManagerScr : MonoBehaviour
{
    public static MainGameManagerScr instance;
    public static float timeLimit = 100f;//�� ���� �ð� 
    public static bool wireClear = false;
    public static bool timeGo = true;

    private GameObject QuitBtn;

    private GameObject inventoryPanel;   //�κ��丮 �г�
    public static bool activeInven = false;       //�κ� �г� Ȱ��ȭ ����
    private GameObject invenBtn;

    //������ ����
    public bool getNameTag = false;
    public bool getSaw = false;
    public bool getHandcloth = false;
    public bool getMonsterFoot = false;
    public bool getRipHand = false;
    public bool getFoot01 = false;
    public bool getFoot02 = false;
    public bool getFoot03 = false;
    private GameObject s_nameTag;
    private GameObject s_saw;
    private GameObject s_handcloth;
    private GameObject s_monsterFoot;
    private GameObject s_ripHand;
    private GameObject s_foot01;
    private GameObject s_foot02;
    private GameObject s_foot03;
    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        //�� �ε� �� ������ ����
        QuitBtn = GameObject.Find("QuitBtn");
        inventoryPanel = GameObject.Find("Inventory");
        invenBtn = GameObject.Find("InvenButton");
        s_nameTag = GameObject.Find("S_NameTag");
        s_saw = GameObject.Find("S_Saw");
        s_handcloth = GameObject.Find("S_Handcloth");
        s_monsterFoot = GameObject.Find("S_MonsterFoot");
        s_ripHand = GameObject.Find("S_RipHand");
        s_foot01 = GameObject.Find("S_Footprint_01");
        s_foot02 = GameObject.Find("S_Footprint_02");
        s_foot03 = GameObject.Find("S_Footprint_03");
        if (inventoryPanel)
            inventoryPanel.SetActive(activeInven);      //�κ� ��Ȱ��ȭ

        if (invenBtn)
        {
            invenBtn.GetComponent<Button>().onClick.AddListener(getInvenButton);
        }


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
        /* if (activeInven == true)
         {
             QuitBtn.SetActive(false);
         }
         else
         {
             QuitBtn.SetActive(true);
         }*/
        if (timeLimit <= 0)
        {
            SceneManager.LoadScene("gameOverScene");
            Debug.Log("�� ����");


        }
        //Debug.Log(timeGo);
        if (timeGo)
        {
            timeLimit -= Time.deltaTime;

        }
        else
        {

        }

        //�κ� ���� Ȱ��ȭ �κ�
        if(s_nameTag != null)
        {
            s_nameTag.SetActive(getNameTag);
            s_ripHand.SetActive(getRipHand);
            s_monsterFoot.SetActive(getMonsterFoot);
            s_handcloth.SetActive(getHandcloth);
            s_saw.SetActive(getSaw);
            s_foot01.SetActive(getFoot01);
            s_foot02.SetActive(getFoot02);
            s_foot03.SetActive(getFoot03);
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
        if (!EventSystem.current.IsPointerOverGameObject())
        {
            //UI�� �������� �۵� X
            Application.Quit();
            Debug.Log("����");
        }

    }

    void OnDisable()
    {
        //�� �����, onload�� ��Ʈ
        Debug.Log("OnDisable");
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }
}
