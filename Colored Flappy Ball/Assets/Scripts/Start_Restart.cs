using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Start_Restart : MonoBehaviour
{


    private Button StartButton;

    private void Start()
    {
        StartButton = GetComponent<Button>();
        StartButton.onClick.AddListener(StartGame);
    }


    public void StartGame()
    {
        SceneManager.LoadScene("Main");
        //Debug.Log("start :)");
    }
}
