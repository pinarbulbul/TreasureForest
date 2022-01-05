using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collect : MonoBehaviour
{
    public GameObject collectedLigth; 
    public Text CollectedTreasuresText;
    public Text EndOfGameText;
    private int collectedTreasuresNumber = 0;
    private int totalTreasuresNumber = 30;
    public PlayerWalk PlayerWalk;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "bonus")
        {
            Debug.Log("Congratulations - You Collected A Treasure!");
            Destroy(collision.gameObject);
            Instantiate(collectedLigth, collision.gameObject.transform.position, collision.gameObject.transform.rotation);
            collectedTreasuresNumber++;
            CollectedTreasuresText.text = "Collected Treasures: " + collectedTreasuresNumber.ToString() + "/"+ totalTreasuresNumber.ToString();
            
        }
        if (collectedTreasuresNumber >= totalTreasuresNumber)
        {
            EndOfGameText.text = "All treasures are collected! :)";
            PlayerWalk.endOfGame = true;
        }
    }
}
