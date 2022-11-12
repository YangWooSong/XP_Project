using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public GameObject[] cameras;
    public bool cam0Activee, cam1Active;
    // Start is called before the first frame update
    void Start()
    {
 
    }

    // Update is called once per frame
    void Update()
    {
        cameras[0].SetActive(GameObject.Find("polySurface3").GetComponent<DoorAndGame>().cam0);
        cameras[1].SetActive(GameObject.Find("polySurface3").GetComponent <DoorAndGame> ().cam1);
    }
}
