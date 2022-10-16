using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainGameManagerScr : MonoBehaviour
{
    public static MainGameManagerScr instance;
    public static float timeLimit= 100f;
    public static bool wireClear = false;
    public static bool timeGo = true;
    // Start is called before the first frame update

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
}
