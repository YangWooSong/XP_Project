using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TouchPuzzle2 : MonoBehaviour
{
    private void OnMouseDown()
    {
        Debug.Log("¼¼ÆÃ·ë °¡");
        SceneManager.LoadScene("MemoryScene");
    }
}


