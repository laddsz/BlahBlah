using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    //宣告區
    public float 速度 = 2f;
    public Transform 位置;
    public GameObject 子彈;
    public Transform 發射點A;
    public Transform 發射點B;
    public int 血量 = 10;

    // Start is called before the first frame update
    void Start()
    {
        //位置 = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //Raycast
        if (Input.GetMouseButton(0))
        {
            // 從攝像機位置發射 Ray
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            Vector3 nPos = Vector3.zero;             
            if (Physics.Raycast(ray, out hit)) // 如果 Raycast 撞擊到物件
            {                
                // 取得被撞擊到的物件
                nPos = hit.point;
                nPos.z = 0;
                nPos.y = hit.point.y + 1.5f;
                this.transform.position = nPos;
            }
        }

        // movement method
        {
            if (Input.GetKey(KeyCode.UpArrow))
            {
                this.transform.Translate(Vector3.back * 速度 * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.DownArrow))
            {
                this.transform.Translate(Vector3.forward * 速度 * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.RightArrow))
            {
                this.transform.Translate(Vector3.right * 速度 * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                this.transform.Translate(Vector3.left * 速度 * Time.deltaTime);
            }
        }
        // set position
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            this.transform.position = 位置.transform.position;
        }
        // fire bullet
        if (Input.GetKey(KeyCode.Mouse0)) 
        {
            //Instantiate(遊戲物件, 發射點position, 旋轉角度);
            GameObject bb = Instantiate(子彈, 發射點A.position, Quaternion.identity);
            bb.GetComponent<Rigidbody>().AddForce(Vector3.up * 12000 * Time.deltaTime);
            Destroy(bb, 2f);

        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "敵方子彈")
        {
            Destroy(other.gameObject);
            血量--;
            if(血量 <= 0)
            {
                Destroy(this.gameObject);
                print("死掉了");
            }
        }
    }

}
