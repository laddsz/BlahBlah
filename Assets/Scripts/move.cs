using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public float �t�� = 2f;
    Vector3 pos;
    public GameObject Bullet;
    public Transform firePosA;
    public Transform firePosB;
    public int HP = 10;
    // Start is called before the first frame update
    void Start()
    {
        //print("Hello world");
        pos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        // movement method
        {
            if (Input.GetKey(KeyCode.UpArrow))
            {
                this.transform.Translate(Vector3.back * �t�� * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.DownArrow))
            {
                this.transform.Translate(Vector3. forward* �t�� * Time.deltaTime);
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
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            pos.y = -3f;
            this.transform.position = pos;
        }
        // fire bullet
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Instantiate(Bullet, firePosA.position, Quaternion.identity);
        }
        {
           
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "enemy's bullet")
        {
            HP--;
            if (HP <= 0) ;
            {
                Destroy(this.gameObject);
                print("you suck");
            }
        }
    }
}
