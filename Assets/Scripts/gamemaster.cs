using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class gameMaster : MonoBehaviour
{
    bool isWon = false;
    GameObject[] enemies;

    public int �ĴX�� = 1;
    private Text ���d��r;
    public GameObject �~����s;

    void Start()
    {
        ���d��r = GameObject.Find("/Canvas/Text ���d").GetComponent<Text>();
        ���d��r.text = "�� " + �ĴX��.ToString() + " ��";
        �~����s.SetActive(false);
    }
    void Update()
    {
        if (isWon)
        {
            �~����s.SetActive(true);
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
        //���@�U�~��.... ���ӭn��U�@���A�Ϊ̬O�^����
        if (�ĴX�� == 1)
        {
            SceneManager.LoadScene("LV2");
        }
        else 
        {
            SceneManager.LoadScene("LV1");
        }
    }
}
