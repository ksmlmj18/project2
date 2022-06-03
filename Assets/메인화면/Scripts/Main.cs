using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Main : MonoBehaviour
{
    public void ChangeMainBtn()
    {
        switch (this.gameObject.name)
        {
            case "ChangeMainBtn":
                SceneManager.LoadScene("stage");
                break;
        }
    }

}
