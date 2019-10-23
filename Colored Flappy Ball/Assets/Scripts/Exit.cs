using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Exit : MonoBehaviour
{
    private Button ExitButton;

    private void Start()
    {
        ExitButton = GetComponent<Button>();
        ExitButton.onClick.AddListener(ExitGame);
    }

    void ExitGame()
    {
        Application.Quit();
        Debug.Log("you do quit, do you?");
    }
}
