using UnityEngine;

public class PlayerPosition : MonoBehaviour
{
    public Transform player; // asignar en inspector
    public Renderer targetRenderer; // asignar en inspector

    private MaterialPropertyBlock mpb;

    void Awake()
    {
        mpb = new MaterialPropertyBlock();
    }

    void Update()
    {
        if (player == null || targetRenderer == null) return;

        Debug.Log($"Actualizando posición del player: {player.position}");

        targetRenderer.GetPropertyBlock(mpb);
        mpb.SetVector("_PlayerPosition", player.position);
        targetRenderer.SetPropertyBlock(mpb);
    }
}
