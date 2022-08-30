using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class s1 : MonoBehaviour
{
    public TextAsset textFile;
    string[] line = new string[10];
    string[] names = { "mistery", "kohana"};
    public Text textDisplay;
    int currentLine = 0;

    // Start is called before the first frame update
    void Start()
    {
        string allText = textFile.text;
        line = allText.Split("\n");
        //textDisplay = GameObject.Find("Text").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            
            currentLine++;
            string[] tmp = new string[2];
            tmp = line[currentLine].Split(":");
            string cNumber = int.Parse(tmp[0]);
            string txt = names[cNumber] + ": " + tmp[1];
            textDisplay.text = line[currentLine];
        }
    }
}
