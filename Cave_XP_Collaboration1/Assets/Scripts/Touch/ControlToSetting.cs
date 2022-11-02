using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControlToSetting : MonoBehaviour
{
    
   
    private void OnMouseDown()
    {
        Debug.Log("¼¼ÆÃ·ë °¡");
        SceneManager.LoadScene("Setting_room 1");
    }
}
