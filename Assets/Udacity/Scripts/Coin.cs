using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour 
{
    //Create a reference to the CoinPoofPrefab

    public void OnCoinClicked(GameObject coinPoof) {
        // Instantiate the CoinPoof Prefab where this coin is located
        // Make sure the poof animates vertically
        // Destroy this coin. Check the Unity documentation on how to use Destroy
        Object.Instantiate(coinPoof, transform.position, Quaternion.Euler(new Vector3(-90, 0, 0)));
        GameObject sign = GameObject.Find("SignPost");
        sign.GetComponent<SignPost>().addCoin(sign);
        Destroy(this.gameObject);
        
    }

}
