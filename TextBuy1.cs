﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextBuy1 : MonoBehaviour
{
    int jetupgrade;
    int cost;
    public UnityEngine.UI.Text ScoresText;
    public GameObject start;
    public GameObject starts;
    void Update()
    {

        jetupgrade = PlayerPrefs.GetInt("runupgrade");
        Debug.Log(jetupgrade);

        if (jetupgrade == 0)
        {
            cost = 6;

            

            string a = cost.ToString();

            a = a + " $";

            ScoresText.text = a;

            PlayerPrefs.SetInt("costrunupgrade", cost);
        }

        else
        {
            int z = PlayerPrefs.GetInt("character");
            if (z == 0 && jetupgrade >= 5)
            {
                start.SetActive(false);
                starts.SetActive(true);
            }
            //if (z == 1 && jetupgrade == 10)
            //{
            //    start.SetActive(false);
            //    starts.SetActive(true);
            //}
            //if (z == 2 && jetupgrade == 15)
            //{
            //    start.SetActive(false);
            //    starts.SetActive(true);
            //}
            else
            {
                float timer = PlayerPrefs.GetFloat("run");

                cost = jetupgrade + 2;

                cost = cost * 13;

                string a = cost.ToString();

                a = a + " $";

                ScoresText.text = a;
                PlayerPrefs.SetInt("costrunupgrade", cost);
            }
            
            
        }
    }
}
