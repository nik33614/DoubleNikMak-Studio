﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextBuyCh1 : MonoBehaviour
{
    int jetupgrade;
    int cost;
    public UnityEngine.UI.Text ScoresText;
    public GameObject start;
    public GameObject starts;

    void Update()
    {
        jetupgrade = PlayerPrefs.GetInt("jet1");

        if(jetupgrade == 0)
        {
            cost = 6;

            PlayerPrefs.SetFloat("timer1", 6);

            string a = cost.ToString();

            a = a + " $";

            ScoresText.text = a;

            PlayerPrefs.SetInt("cost1", cost);
        }

        else
        {
            int z = PlayerPrefs.GetInt("characterbuy1");
            int aa = PlayerPrefs.GetInt("character");
            if (aa == 1)
            {
                if (z == 1 && jetupgrade >= 10)
                {
                    start.SetActive(false);
                    starts.SetActive(true);
                }
            }
            if (z == 1 && jetupgrade == 10)
            {
                start.SetActive(false);
                starts.SetActive(true);
            }
            if (z == 2 && jetupgrade == 15)
            {
               start.SetActive(false);
               starts.SetActive(true);
            }
            else
            {
                cost = jetupgrade + 2;

                cost = cost * 13;

                string a = cost.ToString();

                a = a + " $";

                ScoresText.text = a;
                PlayerPrefs.SetInt("cost1", cost);
            }
        }
    }
}
