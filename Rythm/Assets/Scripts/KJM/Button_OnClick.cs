using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Button_OnClick : Fade
{
    public string sceneName = "Map";



    private void Update()
    {
        if (FadeOff)
        {
            Debug.Log("out");
            SceneManager.LoadScene(sceneName);
            FadeOff = false;
        }
    }



    public void ClickStart()
    {

        if (SceneManager.GetSceneByName(sceneName) == null)
        {
            Debug.Log($"{sceneName}��(��) ã���� �����ϴ�");
            return;
        }
        Init();
        Faded();
    }

    public void ClickLoad()
    {
        Debug.Log("�ε�");
    }

    public void ClickExit()
    {
        Debug.Log("���� ����");
        Application.Quit();
    }





}