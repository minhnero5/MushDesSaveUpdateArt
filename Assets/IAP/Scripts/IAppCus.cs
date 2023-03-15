using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IAppCus : MonoBehaviour
{
    public void IAPEvent(int id)
    {
        switch (id)
        {
            case 1:
                CoinManager.Instance.AddDmg(10);
                Debug.Log("10");
                break;
            case 2:
                CoinManager.Instance.AddDmg(20);
                Debug.Log("20");
                break;
            case 3:
                CoinManager.Instance.AddDmg(30);
                Debug.Log("30");
                break;
            case 4:
                //CoinManager.Instance.AddDmg(10);
                break;
            case 5:
                CoinManager.Instance.AddDmg(50);
                Debug.Log("40");
                break;
            case 6:
                //CoinManager.Instance.AddDmg(10);
                break;
            case 7:
                CoinManager.Instance.AddDmg(70);
                Debug.Log("70");
                break;
            case 8:
                CoinManager.Instance.AddDmg(100);
                Debug.Log("100");
                break;

        }
    }

}
