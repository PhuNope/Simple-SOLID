using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAIInteractions : MonoBehaviour {

    public Transform raycastPoint;

    public void Interact(bool isSpriteFlipped) {
        Debug.DrawRay(raycastPoint.position, isSpriteFlipped ? Vector3.left : Vector3.right, Color.red);
        RaycastHit2D hit = Physics2D.Raycast(raycastPoint.position, isSpriteFlipped ? Vector3.left : Vector3.right, 1);
        if (hit.collider != null) {
            if (hit.collider.TryGetComponent<NPC>(out NPC npcComponent)) {
                npcComponent.Interact();
            }

            var hittable = hit.collider.GetComponent<IHittable>();
            hittable?.GetHit();
        }

    }
}
