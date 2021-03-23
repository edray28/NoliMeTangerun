﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Question8script : MonoBehaviour {
    public Animator anim;
    //  public GameObject triviashow;
    public AudioClip SoundToPlay;
    public float Volume;
    AudioSource audios;

    private void Awake()
    {
        audios = GetComponent<AudioSource>();
        anim = GetComponent<Animator>();


    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            audios.clip = SoundToPlay;
            audios.Play();
            audios.volume = PlayerPrefs.GetFloat("SFX");
            //Collider col = gameObject.GetComponent<Collider>();
            // col.isTrigger = false;

            GameManager.Instance.Showtrivias8();
            GameManager.Instance.isDead = false;
            //     triviashow.SetActive(true);


        }



    }




}
