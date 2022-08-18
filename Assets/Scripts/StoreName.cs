using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class StoreName : MonoBehaviour
{
    public TMP_InputField nameInput;
    public void SaveName()
    {
        DataSaver.Instance.PlayerName = nameInput.text;
    }
    public void NewGame()
    {
        SceneManager.LoadScene(1);
    }
}
