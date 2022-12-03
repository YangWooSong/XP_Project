using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraResolutionScr : MonoBehaviour
{
    // Start is called before the first frame update
    private void Awake()
    {
        Camera camera = GetComponent<Camera>();
        Rect rect = camera.rect;
        float scaleheight = ((float)Screen.width / Screen.height) / ((float)16 / 9);
        float scalewidth = 1f / scaleheight;
        if (scaleheight < 1)
        {
            rect.height = scaleheight;
            rect.y = (1f - scaleheight) / 2f;

        }
        else
        {
            rect.width = scalewidth;
            rect.x = (scaleheight - 1f) / 2f;
        }
        camera.rect = rect;

    }

    private void OnPreCull() => GL.Clear(true, true, Color.black);
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
