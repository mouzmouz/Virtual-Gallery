﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Proximity : MonoBehaviour
{
    [SerializeField] string newTitle;
    [SerializeField] string newArtist;
    //public GameObject auto;
    //public string newDesc;
    private Transform other;
    private Text myTitle;
    private Text myAuthor;
    //private Text myDesc;
    private float dist;
    private GameObject player;
    private GameObject message1;
    private GameObject message2;
    private GameObject message3;
    private bool check;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player");
        other = player.GetComponent<Transform>();
        message1 = GameObject.FindWithTag("ArtTitle");
        message2 = GameObject.FindWithTag("Artist");
        //message3 = GameObject.FindWithTag("Description");
        myTitle = message1.GetComponent<Text>();
        myTitle.text = "";
        myAuthor = message2.GetComponent<Text>();
        myAuthor.text = "";
        //myDesc = message3.GetComponent<Text>();
        //myDesc.text = "";
        check = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (other)
        {
            dist = Vector3.Distance(transform.position, other.position);
            //print(auto.name+"Distance to player: " + dist);
            if (dist < 4)
            {
                myTitle.text = newTitle;
                myAuthor.text = newArtist;
                //myDesc.text = newDesc;
                check = true;
            }
            if (dist > 5 && check == true)
            {
                Start();
            }
        }
    }
}
