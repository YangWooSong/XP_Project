using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class RightWire : MonoBehaviour
{
    public EWireColor WireColor { get; private set; }

    public bool IsConnected { get; private set; }

    [SerializeField]
    private List<Image> mWireImages;

    private List<LeftWire> mConnectedWires = new List<LeftWire>();

    public void SetWireColor(EWireColor wireColor)
    {

        WireColor = wireColor;
        Color color = Color.black;
        switch (WireColor)
        {
            case EWireColor.Red:
                color = Color.red;
                break;

            case EWireColor.Green:
                color = Color.green;
                break;

            case EWireColor.Blue:
                color = Color.blue;
                break;

            case EWireColor.Yellow:
                color = Color.yellow;
                break;
        }
        foreach (var image in mWireImages)
        {
            image.color = color;
        }
    }

    public void ConnectWire(LeftWire leftwire)
    {
        if (mConnectedWires.Contains(leftwire))
        {
            return;
        }
        mConnectedWires.Add(leftwire);
        if(mConnectedWires.Count ==1 && leftwire.WireColor == WireColor)
        {
            IsConnected = true;
            Debug.Log("����2�ߵ�");
        }
        else
        {
            IsConnected = false;
            Debug.Log("����2�ߵ�");
        }

    }
    public void DisconnectedWire(LeftWire leftWire)
    {
        mConnectedWires.Remove(leftWire);

        if (mConnectedWires.Count == 1 && mConnectedWires[0].WireColor == WireColor)
        {
            IsConnected = true;
            Debug.Log("����1�ߵ�");
        }
        else
        {
            IsConnected = false;
            Debug.Log("����1�ȵ�");
        }
    }

}

