using System.Collections;
using System.Collections.Generic;


[System.Serializable]

public class ColorButton{
    public int ID;
    public float r;
    public float g;
    public float b;
}

[System.Serializable]
public class ColorButtons{
    public List<ColorButton> buttons;
}
