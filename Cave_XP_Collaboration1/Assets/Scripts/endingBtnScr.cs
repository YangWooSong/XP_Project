using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class endingBtnScr : MonoBehaviour
{
    public Button goToStartBtn;
    // Start is called before the first frame update
    void Start()
    {
        goToStartBtn.onClick.AddListener(BtnGoToStart);
    }
    void BtnGoToStart()
    {
        SceneManager.LoadScene("mainStartScene");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
