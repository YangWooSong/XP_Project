using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SettingToWare : MonoBehaviour
{
    private void OnMouseDown()
    {
        Debug.Log("â�� ��");
        SceneManager.LoadScene("WarehouseScene");
    }
}
