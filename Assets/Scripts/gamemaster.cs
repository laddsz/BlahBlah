using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class gameMaster : MonoBehaviour
{
    bool isWon = false;
    GameObject[] enemies;

    public int 第幾關 = 1;
    private Text 關卡文字;
    public GameObject 繼續按鈕;

    void Start()
    {
        關卡文字 = GameObject.Find("/Canvas/Text 關卡").GetComponent<Text>();
        關卡文字.text = "第 " + 第幾關.ToString() + " 關";
        繼續按鈕.SetActive(false);
    }
    void Update()
    {
        if (isWon)
        {
            繼續按鈕.SetActive(true);
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
        //按一下繼續.... 應該要到下一關，或者是回首頁
        if (第幾關 == 1)
        {
            SceneManager.LoadScene("LV2");
        }
        else 
        {
            SceneManager.LoadScene("LV1");
        }
    }
}
