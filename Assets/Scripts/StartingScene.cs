using UnityEngine;
using System.Collections;

public class StartingScene : MonoBehaviour
{
    public void ChangeScene(string changeSceneTo)
    {
        Application.LoadLevel("level_01");
    }

    public void ChangeAnotherScene(string goBackScene)
    {
        Application.LoadLevel("Starting Scene");
    }

    public void LoadMap(string loadMap) {
        Application.LoadLevel("LoadMap");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
