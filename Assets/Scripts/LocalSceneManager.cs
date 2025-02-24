using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LocalSceneManager : MonoBehaviour
{
    //시작
    public void OnClickStart()
    {
        SceneManager.LoadScene("");
    }
}
