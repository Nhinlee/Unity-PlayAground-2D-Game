using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UIController : MonoBehaviour
{
    [SerializeField]
    private HealthSystemAttribute playerHealth;
    [SerializeField]
    private Text txtHealth;
    [SerializeField]
    private GameObject panelGameOver;
    [SerializeField]
    private GameObject panelWin;

    private void Update()
    {
        txtHealth.text = playerHealth.health.ToString();
        if(playerHealth.health <=0)
        {
            GameOver();
        }
    }

    private void GameOver()
    {
        panelGameOver.SetActive(true);
    }
}
