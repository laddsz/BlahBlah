using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 敵人的行為 : MonoBehaviour
{
    // 移動速度
    public float 移動速度 = 2.0f;
    // 左右移動範圍
    public float 移動範圍 = 5f;
    // 初始位置
    private Vector3 初始位置;
    public int 血量 = 10;

    public GameObject 子彈;
    public Transform 發射點;


    // Start is called before the first frame update
    void Start()
    {
        初始位置 = transform.position;
        血量 = Random.Range(1, 10);
        float 發射頻率 = Random.Range(0.3f, 3);
        InvokeRepeating("發射子彈", 3f, 發射頻率);
      //InvokeRepeating(函式名要雙引號, 第一次調後, 每幾秒調用);
    }

    // Update is called once per frame
    void Update()
    {
        // 使用 Mathf.PingPong 來改變 x 軸的位置
        float x軸 = Mathf.PingPong(Time.time * 移動速度, 移動範圍) - 移動範圍 / 2;
        transform.position = new Vector3(初始位置.x + x軸, 初始位置.y, 初始位置.z);
    }

    private void OnCollisionEnter(Collision collision)
    {        
        if (collision.transform.tag == "我方子彈")
        {            
            血量--; //簡寫
            //血量 = 血量 - 1; //標準寫法

            if(血量 <= 0)
            {
                Destroy(gameObject); 
            }
            Destroy(collision.gameObject);
        }
    }

    void 發射子彈() 
    {
        //Instantiate(遊戲物件, 發射點position, 旋轉角度);
        GameObject bb = Instantiate(子彈, 發射點.position, Quaternion.identity);
        bb.GetComponent<Rigidbody>().AddForce(Vector3.down * 32000 * Time.deltaTime);
        
        Quaternion 旋轉 = Quaternion.Euler(180, 0, 0);
        bb.transform.rotation *= 旋轉;

        Destroy(bb, 2f);
    }

}
