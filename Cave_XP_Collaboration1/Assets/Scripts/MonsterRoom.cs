using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterRoom : MonoBehaviour
{
    public bool cam0, cam1;
    // Start is called before the first frame update
    void Start()
    {
        cam0 = true;
        cam1 = false;
    }

    // Update is called once per frame
    void Update()
    {
    
    }
    private void OnMouseDown()
    {
        cam0 = !cam0;
        cam1 = !cam1;

    }
}
