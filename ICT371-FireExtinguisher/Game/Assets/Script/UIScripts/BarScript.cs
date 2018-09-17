using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarScript : MonoBehaviour {
    [SerializeField]
    private float _fillAmount;

    [SerializeField]
    private float lerpSpeed;

    [SerializeField]
    private Image content;

    [SerializeField]
    private Text ammoText;

    public float MaxValue { get; set; }

    public float Value
    {
        set
        {
            string[] tmp = ammoText.text.Split(':');
            ammoText.text = tmp[0] + ": " + value;
            _fillAmount = Map(value, 0, MaxValue, 0, 1);
        }
    }
                                       // Use this for initialization
    void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        HandleBar();
	}

    private float Map(float value, float inMin, float inMax, float outMin, float outMax)
    {
        return (value - inMin) * (outMax - outMin) / (inMax - inMin) + outMin;
        ///(80 - 0) * (1 - 0) / (230 - 0) + 0
        ///80 * 1 / 230 - 0.33
    }

    private void HandleBar()
    {
        if (_fillAmount != content.fillAmount)
            content.fillAmount = Mathf.Lerp(content.fillAmount, _fillAmount, Time.deltaTime * lerpSpeed);
    }
}
