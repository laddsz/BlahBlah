using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletMove : MonoBehaviour
{
    float �t�� = 10;
    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.up * �t��, ForceMode.Impulse);
        //this.gameObject.GetComponent<Rigidbody>().velocity = Vector3.up * �t��;
        Destroy(gameObject,2f);
    }

    // Update is called once per frame
    void Update()
    {
        //this.transform.Translate(Vector3.up * �t�� * Time.deltaTime);
    }
}
