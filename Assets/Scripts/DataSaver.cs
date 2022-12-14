using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;
public class DataSaver : MonoBehaviour
{
    public static DataSaver Instance;
    public string PlayerName;
    
    private void Awake()
    {
    
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
             
        }
        
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
}
