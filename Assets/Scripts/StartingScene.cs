using UnityEngine;
using System.Collections;

public class StartingScene : MonoBehaviour
{
    public Transform instructionMenu;
    public void LoadScene(string name)
    {
        Application.LoadLevel(name);
    }
    public void QuitGame()
    {
        if(Input.GetKey("escape"))
        Application.Quit();
    
}

    public void InstructionMenu(bool click)
    {
        if (click == true)
        {
            instructionMenu.gameObject.SetActive(click);
        }


    }
}
