using System.Collections.Generic;
using UnityEngine;

// Sript is add to all falling elements prefab
public class Elements : MonoBehaviour
{
    public int pointsElement;
    public int intexElements;
   

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            Destroy(gameObject);
        }
        if (collision.gameObject.CompareTag("Player"))
        {
            HudMenu.instance.SetSpriteElements(intexElements);
          
            HudMenu.instance.BonusSet(intexElements);        
           
            // Taking points and sending to HUD
            HudMenu.instance.AddPoints(pointsElement);
            HudMenu.instance.SetElementFields();
            Destroy(gameObject, 0.03f);
        }
    }
}
