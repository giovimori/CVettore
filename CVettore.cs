using System;
using System.Linq;

public class Vettore {

    private int[] vettore;
    private int idx=0;
    public Vettore () {
        vettore = new int[]{0};
    }
    public Vettore(int n)
    {
        if( n<=0)
            vettore = new int[0];
        else
            vettore = new int[n];
    }
    public bool Aggiungi (int val)
    {
        if(idx>=vettore.Length)
            return false;

        vettore[idx] = val;
        idx++;
        return true;
    }
    public int Somma()
    {
        int RetVal = 0;
        for (int idx = 0; idx < vettore.Length; idx++)
        {
            RetVal += vettore[idx];
        }
        return RetVal;
    }
    public int Ultimo ()
    {
        if(vettore.Length==0)
            return 0;

            if(idx == 0 )
            return vettore[idx];

            return vettore[idx-1];
    }
}