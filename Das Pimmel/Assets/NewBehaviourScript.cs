using UnityEngine;
using System.Collections;
using System;

public class NewBehaviourScript : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
        //Load bitmap
        Texture2D testBMP = Resources.Load("Bitmaps/test") as Texture2D;
        var width = testBMP.width;
        var height = testBMP.height;
        string[,] newbmp = new string[width, height];
        //var pix = testBMP.GetPixels();
        for (int y = 0; y < height; y++)
        {
            for(int x = 0; x < width ; x++)
            {
                string colour = (testBMP.GetPixel(x, y)).ToString();
                newbmp[x,y] = colour;
            }
            Debug.Log(y);
        }
        Debug.Log(newbmp[0, 0]);
        Debug.Log(newbmp[19, 19]);
    }
	
	// Update is called once per frame
	void Update ()
    {
	
	}
}
