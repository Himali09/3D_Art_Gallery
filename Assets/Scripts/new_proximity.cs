using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Proximity : MonoBehaviour
{
    public string newTitle;
    public string newAuthor;
    public string newDesc;
    private TextMeshProUGUI myTitle;
    private TextMeshProUGUI myAuthor;
    private TextMeshProUGUI myDesc;
    private GameObject player;
    private bool check;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player");
        myTitle = GameObject.FindWithTag("ArtTitle").GetComponent<TextMeshProUGUI>();
        myAuthor = GameObject.FindWithTag("Auth").GetComponent<TextMeshProUGUI>();
        myDesc = GameObject.FindWithTag("Description").GetComponent<TextMeshProUGUI>();
        myTitle.text = "";
        myAuthor.text = "";
        myDesc.text = "";
        check = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (player)
        {
            float dist = Vector3.Distance(transform.position, player.transform.position);
            print("Distance to player: " + dist);
            
            if (dist < 6)
            {
                myTitle.text = newTitle;
                myAuthor.text = newAuthor;
                myDesc.text = newDesc;
                check = true;
            }
            else if (dist > 6 && check == true)
            {
                myTitle.text = "";
                myAuthor.text = "";
                myDesc.text = "";
                check = false;
            }
        }
    }
}
