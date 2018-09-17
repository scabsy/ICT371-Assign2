using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VoiceOver : MonoBehaviour {
    public AudioSource audio1;
    private bool aud1;
    public AudioSource audio2;
    private bool aud2;
    public AudioSource audio3;
    private bool aud3;

    // Use this for initialization
    void Start () {
        aud1 = false;
        aud2 = false;
        aud3 = false;
        print(audio1.clip.length + audio2.clip.length);
        print(audio1.clip.length);
        audio1.Play();
        audio2.PlayDelayed(audio1.clip.length);
        audio3.PlayDelayed(audio1.clip.length + audio2.clip.length);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
