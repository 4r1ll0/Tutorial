using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerBehaviour : MonoBehaviour
{
    Rigidbody rb;
    public float jumpForce = 10f;
    public float speedMovement = 5f;
    public int coin = 0;
    public TextMeshProUGUI coinsText;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(transform.up * 10f, ForceMode.Impulse);

        }

        Vector3 movement = new Vector3();
        movement.x = Input.GetAxis("Horizontal");
        movement.z = Input.GetAxis("Vertical");
        
        rb.AddForce(movement * Time.deltaTime * jumpForce, ForceMode.Impulse);

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("CoinItem"))
        {
            coin = coin + 1;// es igual coins += 1
            Debug.Log("He chocado con una moneda" + coin);
        }
        else if (other.CompareTag("CoinSpecial"))
        {
            coin = coin + 5; // es igual coins += 5
            Debug.Log("He chocado con una moneda especial" + coin);
        }
        if (other.tag.Contains("Coin")) //la palabra "contains" se refiere a un trozo de texto
        {
            coinsText.text = coin.ToString();  
            other.gameObject.SetActive(false);
        }
        
    }
}
