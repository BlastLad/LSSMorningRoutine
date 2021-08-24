using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PaintIn3D;
public class CharDataShowerGame : MonoBehaviour
{

    
    public Collider charCollider;

    
    public List<P3dPaintableTexture> charTextures;

    public List<P3dChannelCounterFill> charFill;//0 head 1 left 2 right
    public List<P3dChannelCounterText> charText;//0 head 1 left 2 right

}
