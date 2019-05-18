using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menu : MonoBehaviour
{

	public void Playgame()
    {
        Application.LoadLevel("Scene1");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
		
	
}
