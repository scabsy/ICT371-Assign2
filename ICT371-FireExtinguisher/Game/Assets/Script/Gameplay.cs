using UnityEngine;
using System.Collections;

public class Gameplay : MonoBehaviour {

	public GameObject playerPrefab;

	// Use this for initialization
	void Start ()
    {
        Game.current = new Game();
	}

}
