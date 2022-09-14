using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowSpot : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private GameObject mSpot;

    public Button mBtn;
    private void Awake()
    {
        mSpot.SetActive(false);
        Debug.Log("0���Լ�");
    }
    void Start()
    {
        
        
        mBtn.onClick.AddListener(ShowSpot1);
        Debug.Log("1���Լ�");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void ShowSpot1()
    {
        mSpot.SetActive(true);
        Invoke("HideSpot", 0.25f);
    }

    
    void HideSpot()
    {
        mSpot.SetActive(false);
    }
}
