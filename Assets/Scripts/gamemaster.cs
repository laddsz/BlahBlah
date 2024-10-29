using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gamemaster : MonoBehaviour
{
    bool isWon = false;
    GameObject[] enemy;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (isWon) return;
        enemy = (GameObject.FindGameObjectsWithTag("enemy"));
        if (enemy.Length <= 0)
        {
            isWon = true;
            Win();

        }
    }
    void Win()
    {
        print("Won");
  }
}
