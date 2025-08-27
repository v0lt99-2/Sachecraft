// File: VoxelPlayer.cs
using Mirror;
using UnityEngine;

public class VoxelPlayer : NetworkBehaviour {
    public float speed = 5f;

    void Update() {
        if (!isLocalPlayer) return;

        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        Vector3 move = new Vector3(h, 0, v) * speed * Time.deltaTime;
        transform.Translate(move);
    }
}
