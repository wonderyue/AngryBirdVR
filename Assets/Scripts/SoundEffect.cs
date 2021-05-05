using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundEffect : MonoBehaviour
{
	public AudioClip Sound;  //assign sound to play
    private AudioSource source;   //use AudioSource to play AudioClip


    void Start () {
        source = GetComponent<AudioSource>();  //get the AudioSource Component of this Object
    }

	public void playSound(){
		source.PlayOneShot(Sound, 1F);   //play sound
	}
}
