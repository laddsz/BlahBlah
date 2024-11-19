using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gameMaster : MonoBehaviour
{
    public int 第幾關 = 1;
    private Text level;
    bool isWon = false;
    GameObject[] enemies;
    public GameObject 繼續;

    void Start()
    {
        level = GameObject.Find("/Canvas/Text level").GetComponent<Text>();
        level.text = "第" + 第幾關.ToString() + "關";
        繼續.SetActive(false);
    }
    void Update()
    {
        if (isWon)
        {   
            繼續.SetActive(true);
            return;
        }
        enemies = GameObject.FindGameObjectsWithTag("敵人");
        if (enemies.Length <= 0)
        {
            isWon = true;
            //WIN();
        }
    }
    public void WIN()
    {
        print("贏了");
        if (第幾關 == 1)
        {
            SceneManager.LoadScene("L2");
        }
    }
}
