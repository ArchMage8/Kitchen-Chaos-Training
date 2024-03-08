using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashCounter : BaseCounter
{
    public override void Interact(PlayerInteractions player)
    {
        if (player.HasKitchenObject())
            {
            player.GetKitchenObject().DestroySelf();
            }
    }
}
