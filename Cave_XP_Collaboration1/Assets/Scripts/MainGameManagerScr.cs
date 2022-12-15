using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
public class MainGameManagerScr : MonoBehaviour
{
    public static MainGameManagerScr instance;
    public static float timeLimit= 100f;//�� ���� �ð� 
    public static bool wireClear = false;
    public static bool timeGo = true;

    private GameObject QuitBtn;

    private GameObject inventoryPanel;   //�κ��丮 �г�
    public static bool activeInven = false;       //�κ� �г� Ȱ��ȭ ����
    private GameObject invenBtn;

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        //�� �ε� �� ������ ����
        QuitBtn = GameObject.Find("QuitBtn");
        inventoryPanel = GameObject.Find("Inventory");
        invenBtn = GameObject.Find("InvenButton");
        if (inventoryPanel)
            inventoryPanel.SetActive(activeInven);      //�κ� ��Ȱ��ȭ
        
        if(invenBtn)
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
