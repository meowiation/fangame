using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableCosmetic : MonoBehaviour
{

   public GameObject cosmeticToDisable;

   void Update() {
      // Debug.Log("disable: update");
   }

   void OnTriggerEnter()
   {
      Debug.Log("trigger enter Disable cosmetic");
     cosmeticToDisable.SetActive(false);
   }


   void OnTriggerExit()
   {
      cosmeticToDisable.SetActive(false);
   }
}
