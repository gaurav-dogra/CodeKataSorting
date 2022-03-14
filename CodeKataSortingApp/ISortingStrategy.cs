using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeKataSortingApp;

public interface ISortingStrategy
{
    int[] Sort(int[] array);
}
