using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdsMan_Custom : MonoBehaviour
{
    private const string Key = "RemoveAds";

    private const string ExpireKey = "RemoveAdsExpireWeek";

    private const int durationForKey = 7; // 7 days

    public void ReAdsWeek()
    {
        if (PurchaseChecked())
        {
            // Remove ads logic here
        }
        else
        {
            // Set remove ads flag
            PlayerPrefs.SetInt(Key, 1);
            DateTime expireTime = DateTime.Now.AddDays(durationForKey);
            PlayerPrefs.SetString(ExpireKey, expireTime.ToString());
        }
    }

    private bool PurchaseChecked()
    {
        // Check if remove ads flag is set
        bool removeAdsPurchased = PlayerPrefs.GetInt(Key, 0) == 1;

        // Check if remove ads has expired
        DateTime expireTime;
        if (DateTime.TryParse(PlayerPrefs.GetString(ExpireKey, ""), out expireTime))
        {
            if (expireTime < DateTime.Now)
            {
                removeAdsPurchased = false;
            }
        }

        return removeAdsPurchased;
    }
}
