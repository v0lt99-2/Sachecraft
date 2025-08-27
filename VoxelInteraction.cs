// File: VoxelInteraction.cs
using Mirror;
using UnityEngine;

public class VoxelInteraction : NetworkBehaviour {
    public GameObject voxelPrefab;

    [Command]
    public void CmdPlaceVoxel(Vector3 position) {
        GameObject voxel = Instantiate(voxelPrefab, position, Quaternion.identity);
        NetworkServer.Spawn(voxel);
    }

    void Update() {
        if (!isLocalPlayer) return;

        if (Input.GetMouseButtonDown(0)) {
            Vector3 placePos = transform.position + transform.forward * 2;
            CmdPlaceVoxel(placePos);
        }
    }
}
