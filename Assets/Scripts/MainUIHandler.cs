using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MainUIHandler : MonoBehaviour
{
    public TextMeshProUGUI playerInfo;
    public int BestScore = 0;
    private string username;
    
    void Start()
    {
        username = DataSaver.Instance.PlayerName;
        string userInfo = string.Format("Name: {1}\nBest Score : {0}", BestScore, username);
        playerInfo.text = userInfo;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
