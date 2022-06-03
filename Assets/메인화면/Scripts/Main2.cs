using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Main2 : MonoBehaviour
{
    public void ChangeMainBtn()
    {
        switch (this.gameObject.name)
        {
            case "Change1MainBtn":
                SceneManager.LoadScene("SampleScene");
                break;
        }
    }
}
