using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SetTextToPref : MonoBehaviour
{
    public string pref;
    public string pre;
    private TextMeshProUGUI text;
    
    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        text.text = pre + PlayerPrefs.GetInt(pref).ToString();
    }
}
