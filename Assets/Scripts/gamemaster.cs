using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gameMaster : MonoBehaviour
{
    public int �ĴX�� = 1;
    private Text level;
    bool isWon = false;
    GameObject[] enemies;
    public GameObject �~��;

    void Start()
    {
        level = GameObject.Find("/Canvas/Text level").GetComponent<Text>();
        level.text = "��" + �ĴX��.ToString() + "��";
        �~��.SetActive(false);
    }
    void Update()
    {
        if (isWon)
        {   
            �~��.SetActive(true);
            return;
        }
        enemies = GameObject.FindGameObjectsWithTag("�ĤH");
        if (enemies.Length <= 0)
        {
            isWon = true;
            //WIN();
        }
    }
    public void WIN()
    {
        print("Ĺ�F");
        if (�ĴX�� == 1)
        {
            SceneManager.LoadScene("L2");
        }
    }
}
