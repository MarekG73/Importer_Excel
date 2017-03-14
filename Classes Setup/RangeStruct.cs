using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

struct RangeStruct
{
    private int for_start;
    private int for_end;

    public RangeStruct(int s, int e)
    {
        for_start = s;
        for_end = e;
    }
    public int start() => for_start;
    public int end() => for_end;
}

