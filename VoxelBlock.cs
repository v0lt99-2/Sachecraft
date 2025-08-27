// File: VoxelBlock.cs
using Mirror;
using UnityEngine;

public class VoxelBlock : NetworkBehaviour {
    [Server]
    public void DestroyBlock() {
        NetworkServer.Destroy(gameObject);
    }

    void OnMouseDown() {
        if (isServer) {
            DestroyBlock();
        }
    }
}
