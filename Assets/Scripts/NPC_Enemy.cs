using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NPC_Enemy : NPC, IHittable {
    public string text = "I deal 10 physical damage    ( •̀ᴗ•́ )و ̑̑ ";

    public void GetHit() {
        Debug.Log("Ouch!");
    }

    public override void Interact() {
        base.Interact();

        FindObjectOfType<Player>().ReceiveDamaged();
    }

    protected override string GetText() {
        return text;
    }
}
