using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManager : MonoBehaviour
{
    public int tp; // 토탈포인트
    public int sp; // 스테이지포인트
    public int si;  // 스테이지인덱스
    public int hp; // 체력
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
