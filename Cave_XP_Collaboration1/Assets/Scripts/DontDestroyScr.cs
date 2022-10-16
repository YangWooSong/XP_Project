using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyScr : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
        var obj = FindObjectsOfType<DontDestroyScr>();
        if (obj.Length == 1)
        {
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
