using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameMaster : MonoBehaviour
{
    bool isWon = false;
    GameObject[] enemies;
    void Start()
    {
        
    }
    void Update()
    {
        if(isWon) return;
        enemies = GameObject.FindGameObjectsWithTag("�ĤH");
        if (enemies.Length <= 0)
        {
            isWon = true;
            WIN();
        }
    }
    void WIN()
    {
        print("Ĺ�F");
    }
}
