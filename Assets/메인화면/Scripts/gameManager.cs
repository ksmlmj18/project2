using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManager : MonoBehaviour
{
    public int tp; // ��Ż����Ʈ
    public int sp; // ������������Ʈ
    public int si;  // ���������ε���
    public int hp; // ü��
    public Player player;
    public GameObject[] stages;

 


    // Start is called before the first frame update

    public void NextS()
    {
        if (si < stages.Length - 1)
        {
            tp += sp;
            sp = 0;
            stages[si].SetActive(false);
            si++;
            stages[si].SetActive(true);
        }
        else
        {
            Time.timeScale = 0;
        }
    }
    public void hpD()
    {
        if (hp > 0)
            hp--;

    }


    }
