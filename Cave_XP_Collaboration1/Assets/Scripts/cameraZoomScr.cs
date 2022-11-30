using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cameraZoomScr : MonoBehaviour
{
    public Camera mainCam;
    private GameObject telposGameObj;
    private GameObject zoomObj;
    private GameObject backZoomBtn;
    private GameObject cameraDefaultPos;
    // Start is called before the first frame update
    void Start()
    {
        mainCam = Camera.main;
        telposGameObj = GameObject.Find("camera_ZoomPos");
        zoomObj = GameObject.Find("zoom_click");
        backZoomBtn = GameObject.Find("zoomBackBtn");
        backZoomBtn.SetActive(false);
        cameraDefaultPos = GameObject.Find("camera_defaultPos");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if(Physics.Raycast(ray,out hit))
            {
                //Debug.Log(hit.transform.gameObject);
                if (hit.transform.gameObject.tag=="telpos")
                {
                    backZoomBtn.SetActive(true);
                    zoomObj.SetActive(false);
                    mainCam.gameObject.transform.position = telposGameObj.transform.position;
                    mainCam.gameObject.transform.rotation = telposGameObj.transform.rotation;
                    //Debug.Log("¼º°ø");

                }
            }
        }
    }
    public void zoomBackBtn()
    {
        zoomObj.SetActive(true);
        backZoomBtn.SetActive(false);
        mainCam.gameObject.transform.position = cameraDefaultPos.transform.position;
        mainCam.gameObject.transform.rotation = cameraDefaultPos.transform.rotation;

    }
}
