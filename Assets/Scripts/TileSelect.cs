using UnityEngine;

public class TileSelect : MonoBehaviour
{
   public GameObject Tower;
   public GameObject Indicator;
   public bool selected = false;


   public void Select()
   {
      
      Debug.Log(gameObject.name + " selected!");
      selected = true;  
   }

   public void Deselect()
   {
      Debug.Log(gameObject.name + " deselected!");
      selected = false;
   }

   public bool filled = false;
}
