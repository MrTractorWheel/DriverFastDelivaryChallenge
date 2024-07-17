using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    int packageNumber = 0;
    [SerializeField] Color32 hasPackageColor;
    [SerializeField] Color32 noPackageColor;
    SpriteRenderer spriteRenderer;

    private void Start(){
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void OnCollisionEnter2D(Collision2D other) 
    {
        if (other != null){
            Debug.Log("Car Crash?! McQueen!!! You are FIRED!!!");
        }
    }

    private void OnTriggerEnter2D(Collider2D other) 
    {
        if (other != null && other.CompareTag("Package"))
        {
            Debug.Log("Package Picked Up!");
            packageNumber++;
            spriteRenderer.color = hasPackageColor;
            Destroy(other.gameObject,0.05f);
        }
        if (other != null && other.CompareTag("Customer"))
        {
            if(packageNumber > 0){
                Debug.Log("Package Delivered!");
                packageNumber--;
                if(packageNumber == 0){
                    spriteRenderer.color = noPackageColor;
                }
                Destroy(other.gameObject,0.05f);
            }
            else{
                Debug.Log("No package to deliver!");
            }
        }
    }
}
