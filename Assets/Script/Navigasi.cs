using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Navigasi : MonoBehaviour
{
    public void openScene(int nomor)
    {
        SceneManager.LoadScene(nomor);
    }
    public void keluar()
    {
        Application.Quit();
    }
}
