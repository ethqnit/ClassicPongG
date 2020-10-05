using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;

public class PlayerBarCode : MonoBehaviourPun
{
    public PhotonView pv;
    private Color color;
    float speed = 10;

     [SerializeField] private GameObject Controller;

    void Start()
    {

        pv.GetComponent<PhotonView>();

        if (PhotonNetwork.CurrentRoom.PlayerCount == 1)
        {
        transform.position = new Vector3(-4, 0, -1);
        }
        else if (PhotonNetwork.CurrentRoom.PlayerCount == 2)
        {
            transform.position = new Vector3(4, 0, -1);
        }
    }
  
    void Update()
    {
        if (transform.position.x < 0)
        {
            transform.gameObject.GetComponent<Renderer>().material.color = Color.red;
        }
        else if (transform.position.x > 1)
        {
            transform.gameObject.GetComponent<Renderer>().material.color = Color.blue;
        }    

        if (pv.IsMine)
        {
            float translation = Input.GetAxis("Vertical") * speed;
            translation *= Time.deltaTime;
            transform.Translate(0, translation, 0);
        }
        
    }
}