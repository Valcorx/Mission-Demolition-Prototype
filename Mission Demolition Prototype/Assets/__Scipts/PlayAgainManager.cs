using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayAgainManager : MonoBehaviour
{
    public void press()
    {
        SceneManager.LoadScene("_Scene_0");
    }
}
