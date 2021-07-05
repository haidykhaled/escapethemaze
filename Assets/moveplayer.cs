using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class moveplayer : MonoBehaviour
{
    // Start is called before the first frame update
        float Horizontal,Vertical,speed=5;
        
 private  Rigidbody rigid;
    // Start is called before the first frame update
    void Start()
    {
        
        rigid = GetComponent<Rigidbody>();
     
    }

    // Update is called once per frame
    void Update()
    {
          Horizontal=Input.GetAxis("Horizontal");
        Vertical=Input.GetAxis("Vertical");
        rigid.velocity=new Vector3(Horizontal*speed,0.0f,Vertical*speed);
    }
    
        
}
