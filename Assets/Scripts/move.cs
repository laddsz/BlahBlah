using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    //�ŧi��
    public float �t�� = 2f;
    public Transform ��m;
    public GameObject �l�u;
    public Transform �o�g�IA;
    public Transform �o�g�IB;
    public int ��q = 10;

    // Start is called before the first frame update
    void Start()
    {
        //��m = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //Raycast
        if (Input.GetMouseButton(0))
        {
            // �q�ṳ����m�o�g Ray
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            Vector3 nPos = Vector3.zero;             
            if (Physics.Raycast(ray, out hit)) // �p�G Raycast �����쪫��
            {                
                // ���o�Q�����쪺����
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
                this.transform.Translate(Vector3.back * �t�� * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.DownArrow))
            {
                this.transform.Translate(Vector3.forward * �t�� * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.RightArrow))
            {
                this.transform.Translate(Vector3.right * �t�� * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                this.transform.Translate(Vector3.left * �t�� * Time.deltaTime);
            }
        }
        // set position
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            this.transform.position = ��m.transform.position;
        }
        // fire bullet
        if (Input.GetKey(KeyCode.Mouse0)) 
        {
            //Instantiate(�C������, �o�g�Iposition, ���ਤ��);
            GameObject bb = Instantiate(�l�u, �o�g�IA.position, Quaternion.identity);
            bb.GetComponent<Rigidbody>().AddForce(Vector3.up * 12000 * Time.deltaTime);
            Destroy(bb, 2f);

        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "�Ĥ�l�u")
        {
            Destroy(other.gameObject);
            ��q--;
            if(��q <= 0)
            {
                Destroy(this.gameObject);
                print("�����F");
            }
        }
    }

}
