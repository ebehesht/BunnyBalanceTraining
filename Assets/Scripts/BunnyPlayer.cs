using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BunnyPlayer : MonoBehaviour {

    private bool hasCarrot = false;

	// Use this for initialization
	void Start () {

		
	}
	
	// Update is called once per frame
	void Update () {

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Carrot") && !hasCarrot)
        {
            //Destroy(other.gameObject);
            other.gameObject.SetActive(false);
            GlobalVariables.numberOfPickedCarrots++;
            hasCarrot = true;
            //GameObject.FindGameObjectWithTag("Basket").GetComponent<SpriteRenderer>().sprite = GlobalVariables.basketSprites[GlobalVariables.numberOfPickedCarrots - 1];
        }

        if (other.gameObject.CompareTag("Basket") && GlobalVariables.numberOfPickedCarrots > 0)
        {
            //string imagePath = "Sprites/basket-carrot" + GlobalVariables.numberOfPickedCarrots;
            int thisSprite = GlobalVariables.numberOfPickedCarrots - 1;
            other.gameObject.GetComponent<SpriteRenderer>().sprite = GlobalVariables.basketSprites[thisSprite];
            hasCarrot = false;
            
        }
    }

    public void touchUp ()
    {

    }

    /*
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
         * //instead of this, I used layer-based collision detection
        if (collision.gameObject.tag == "Bunny")
        {
            var colliderToIgnore = collision.gameObject.GetComponent<Collider2D>();
            Physics2D.IgnoreCollision(colliderToIgnore, this.GetComponent<Collider2D>());
        }
        
    }
    */
}
