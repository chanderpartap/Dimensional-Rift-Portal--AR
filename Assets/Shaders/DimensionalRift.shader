Shader "Dimension/DimensionalRift"
{
    Properties
    {
        
    }
    SubShader
    {
        ColorMask 0
        ZWrite Off

        Stencil{
            Ref 1
            Pass replace
        }

        Pass
        {
            
        }
    }
}
